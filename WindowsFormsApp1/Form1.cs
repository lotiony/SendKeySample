﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.WinAppServices;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        protected Status _status;
        protected ChartRecognition cr;

        ObservableCollection<ApplicationInfo> applicationInfos;
        ApplicationInfo selectedItem;
        Timer timer;
        Timer buyTimer;
        Timer sellTimer;
        Timer colorTm;
        Timer RunTm;
        Label colorLb;
        Label signalLb;
        bool 자동매수, 자동매도, 자동스위칭, 진입중 = false;
        bool 매도체크, 매수체크, 자동실행중 = false;
        int 기준계약수 = 1;
        IntPtr selectedHandle { get { return selectedItem?.Handle ?? IntPtr.Zero; } }
        IntPtr orderCountHandle { get; set; }
        Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);

        public Form1()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 200;
            timer.Tick += Timer_Tick;

            buyTimer = new Timer();
            buyTimer.Interval = 3000;
            buyTimer.Tick += BuyTimer_Tick;

            sellTimer = new Timer();
            sellTimer.Interval = 3000;
            sellTimer.Tick += SellTimer_Tick;

            RunTm = new Timer();
            RunTm.Interval = 1000;
            RunTm.Tick += RunTm_Tick;
            RunTm.Start();

            _status = new Status();

            LoadInfo();
        }

        private void RunTm_Tick(object sender, EventArgs e)
        {
            this.lbl_현재시간.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            
            // 종료시간이 되면 자동 멈춤
            if (dtp_종료시간.Value < DateTime.Now && 자동실행중)
            {
                btn_자동주문_Click(null, null);
            }
        }

        private void SellTimer_Tick(object sender, EventArgs e)
        {
            lbl_매도발생.Invoke(new MethodInvoker(delegate () { lbl_매도발생.Visible = false; }));
            sellTimer.Stop();
        }

        private void BuyTimer_Tick(object sender, EventArgs e)
        {
            lbl_매수발생.Invoke(new MethodInvoker(delegate () { lbl_매수발생.Visible = false; }));
            buyTimer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            포지션정보업데이트();
        }

        private void 포지션정보업데이트()
        {
            if (lbl_handle_포지션.Text != "0")
            {
                switch (GetHandleText(new IntPtr(Int64.Parse(lbl_handle_포지션.Text))))
                {
                    case "": _status.PosType = CType.없음; break;
                    case "매수": _status.PosType = CType.매수; break;
                    case "매도": _status.PosType = CType.매도; break;
                }
                lbl_포지션.Text = _status.PosType.ToString();

                if (_status.OldPosType != _status.PosType)
                {
                    진입중 = false;
                    lbl_진입중.Visible = false;
                    _status.OldPosType = _status.PosType;
                }
            }

            if (lbl_handle_수량.Text != "0")
            {
                if (Int32.TryParse(GetHandleText(new IntPtr(Int64.Parse(lbl_handle_수량.Text))), out int cnt))
                {
                    _status.Contracts = cnt;
                    lbl_수량.Text = cnt.ToString();
                }
                else
                {
                    _status.Contracts = 0;
                    lbl_수량.Text = "0";
                }
            }
            if (lbl_handle_진입단가.Text != "0")
            {
                if (decimal.TryParse(GetHandleText(new IntPtr(Int64.Parse(lbl_handle_진입단가.Text))), out decimal price))
                {
                    _status.InPrice = price;
                    lbl_진입단가.Text = price.ToString("#,##0.00");
                }
                else
                {
                    _status.InPrice = 0m;
                    lbl_진입단가.Text = "0";
                }
            }
            if (lbl_handle_평가손익.Text != "0")
            {
                if (decimal.TryParse(GetHandleText(new IntPtr(Int64.Parse(lbl_handle_평가손익.Text))), out decimal profit))
                {
                    _status.Profit = (int)profit;
                    lbl_평가손익.Text = ((int)profit).ToString();
                }
                else
                {
                    _status.Profit = 0;
                    lbl_평가손익.Text = "0";
                }
            }
        }

        private void UpdateProcessList()
        {
            applicationInfos = WinAppServices.GetHts("해외선옵");
            if (applicationInfos.Count > 0)
            {
                comboBox1.DataSource = applicationInfos;
                comboBox1.DisplayMember = "Name";
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox1.DataSource = null;
                MessageBox.Show("프로그램 리스트 감지 실패.");
            }
        }
        
        /// <summary>
        /// HTS의 각 컨트롤 서브핸들값 찾기
        /// </summary>
        private void FindSubHandles()
        {
            lbl_handle_계약수.Text = FindSubHandle(selectedHandle, HtsControls.EDITBOX).ToString();
            lbl_handle_포지션.Text = FindSubHandle(selectedHandle, HtsControls.LBL_POS).ToString();
            lbl_handle_수량.Text = FindSubHandle(selectedHandle, HtsControls.LBL_CONT).ToString();
            lbl_handle_진입단가.Text = FindSubHandle(selectedHandle, HtsControls.LBL_PRICE).ToString();
            lbl_handle_평가손익.Text = FindSubHandle(selectedHandle, HtsControls.LBL_PGSI).ToString();

            

            if (lbl_handle_계약수.Text != "0")
            {
                orderCountHandle = new IntPtr(Int64.Parse(lbl_handle_계약수.Text));
                timer.Start();
            }
            else
                timer.Stop();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = comboBox1.SelectedItem as ApplicationInfo;
            FindSubHandles();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateProcessList();
        }

        private void 매도_Click(object sender, EventArgs e)
        {
            selectedItem = comboBox1.SelectedItem as ApplicationInfo;
            if (selectedItem != null)
            {
                if (_status.Contracts == 0)
                    SendOrder(VKeys.KEY_F12, selectedHandle, orderCountHandle, 기준계약수);
            }
        }

        private void 매수_Click(object sender, EventArgs e)
        {
            selectedItem = comboBox1.SelectedItem as ApplicationInfo;
            if (selectedItem != null)
            {
                if (_status.Contracts == 0)
                    SendOrder(VKeys.KEY_F9, selectedHandle, orderCountHandle, 기준계약수);
            }
        }

        private void 청산_Click(object sender, EventArgs e)
        {
            selectedItem = comboBox1.SelectedItem as ApplicationInfo;
            if (selectedItem != null)
            {
                SendOrder(VKeys.KEY_F11, selectedHandle, orderCountHandle, 기준계약수);
            }
        }


        private void btn_매도스위칭_Click(object sender, EventArgs e)
        {
            selectedItem = comboBox1.SelectedItem as ApplicationInfo;
            if (selectedItem != null)
            {
                int 스위칭계약수 = 기준계약수 * 2;
                if (_status.PosType == CType.없음) 스위칭계약수 = 기준계약수;

                SendOrder(VKeys.KEY_F12, selectedHandle, orderCountHandle, 스위칭계약수);
            }

        }

        private void btn_매수스위칭_Click(object sender, EventArgs e)
        {
            selectedItem = comboBox1.SelectedItem as ApplicationInfo;
            if (selectedItem != null)
            {
                int 스위칭계약수 = 기준계약수 * 2;
                if (_status.PosType == CType.없음) 스위칭계약수 = 기준계약수;

                SendOrder(VKeys.KEY_F9, selectedHandle, orderCountHandle, 스위칭계약수);
            }

        }

        SelectArea areaForm;
        Rectangle rect = new Rectangle();
        private void btn_인식영역선택_Click(object sender, EventArgs e)
        {
            

            if (btn_인식영역선택.Text == "인식영역 선택")
            {
                Ctrl_자동주문(false);
                btn_인식영역선택.Text = "선택 완료";
                cr?.Stop();
                areaForm = new SelectArea();
                areaForm.TopMost = true;
                areaForm.Show();
                if (rect.Location.X > 0 && rect.Location.Y > 0)
                    areaForm.Location = rect.Location;

                if (rect.Width > 10 && rect.Height > 10)
                    areaForm.ClientSize = rect.Size;
            }
            else
            {
                btn_인식영역선택.Text = "인식영역 선택";
                rect = new Rectangle(areaForm.Location, areaForm.Size);

                lbl_영역좌표.Text = $"({rect.X},{rect.Y}) ~ ({rect.Right},{rect.Bottom})";
                lbl_영역크기.Text = $"X = {rect.Width} Y = {rect.Height}";

                SaveInfo();
                areaForm.Hide();
                PreviewPicture();
                cr?.Update(rect, lbl_매수컬러.BackColor, lbl_매도컬러.BackColor);
                cr?.Start();
            }
            
            
        }

        private void SaveInfo()
        {
            Properties.Settings.Default.LocX = rect.X;
            Properties.Settings.Default.LocY = rect.Y;
            Properties.Settings.Default.AreaW = rect.Width;
            Properties.Settings.Default.AreaH = rect.Height;
            Properties.Settings.Default.ColorB = lbl_매수컬러.BackColor;
            Properties.Settings.Default.ColorS = lbl_매도컬러.BackColor;

            Properties.Settings.Default.Save();
        }

        private void LoadInfo()
        {
            if (Properties.Settings.Default.LocX != 0 && Properties.Settings.Default.AreaW > 0)
            {
                rect = new Rectangle(
                        Properties.Settings.Default.LocX,
                        Properties.Settings.Default.LocY,
                        Properties.Settings.Default.AreaW,
                        Properties.Settings.Default.AreaH
                    );

                lbl_영역좌표.Text = $"({rect.X},{rect.Y}) ~ ({rect.Right},{rect.Bottom})";
                lbl_영역크기.Text = $"X = {rect.Width} Y = {rect.Height}";
                PreviewPicture();
            }

            if (Properties.Settings.Default.ColorB != Color.FromArgb(0,0,0,0))
            {
                Color c = Properties.Settings.Default.ColorB;
                lbl_매수컬러.BackColor = c;
                lbl_매수신호.Text = $"{RGBConverter(c)} / {HexConverter(c)}";
            }

            if (Properties.Settings.Default.ColorS != Color.FromArgb(0, 0, 0, 0))
            {
                Color c = Properties.Settings.Default.ColorS;
                lbl_매도컬러.BackColor = c;
                lbl_매도신호.Text = $"{RGBConverter(c)} / {HexConverter(c)}";
            }
            기준계약수 = (int)numericUpDown1.Value;
            진입중 = false;
            lbl_진입중.Visible = false;
        }

        private void PreviewPicture()
        {
            var bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, rect.Size, CopyPixelOperation.SourceCopy);
            pictureBox1.Image = bmp;
        }


        private void btn_자동주문_Click(object sender, EventArgs e)
        {
            if (btn_자동주문.Text == "작동시작")
            {
                if (dtp_시작시간.Value < DateTime.Now)
                {
                    dtp_시작시간.Value = DateTime.Now;
                    dtp_종료시간.Value = DateTime.Now.AddHours(4);
                }
                
                Ctrl_자동주문(true);
                cr = new ChartRecognition(rect, lbl_매수컬러.BackColor, lbl_매도컬러.BackColor);
                cr.UpdateEvent += Cr_UpdateEvent;
                cr.Buy += Cr_Buy;
                cr.Sell += Cr_Sell;
                cr.Clear += Cr_Clear;
                cr.Start();
                진입중 = false;
                lbl_진입중.Visible = false;
            }
            else
            {
                Ctrl_자동주문(false);
                cr.Stop();
                PreviewPicture();
                cr = null;
                청산_Click(null, null);
            }

        }

        
        private void Ctrl_자동주문(bool v)
        {
            if (v)
            {
                btn_자동주문.Text = "작동중지";
                자동실행중 = true;
                chk_자동매도.Enabled = true;
                chk_자동매수.Enabled = true;
                chk_자동스위칭.Enabled = true;
                chk_자동매도.Checked = true;
                chk_자동매수.Checked = true;
                chk_자동스위칭.Checked = true;
            }
            else
            {
                btn_자동주문.Text = "작동시작";
                자동실행중 = false;
                chk_자동매도.Enabled = false;
                chk_자동매수.Enabled = false;
                chk_자동스위칭.Enabled = false;
                chk_자동매도.Checked = false;
                chk_자동매수.Checked = false;
                chk_자동스위칭.Checked = false;
            }
        }

        private void Cr_Clear()
        {
            this.Invoke(new MethodInvoker(delegate () { lbl_매도발생.Visible = false; }));
            this.Invoke(new MethodInvoker(delegate () { lbl_매수발생.Visible = false; }));
        }

        private void Cr_Sell()
        {
            this.Invoke(new MethodInvoker(delegate () { 
                lbl_매도발생.Visible = true;
                if (!진입중)       // 이미 주문이 실행중이라면  패스한다.
                {
                    if (자동매도)   // chk_자동매도 = true 인 경우에만 진행
                    {
                        매도체크 = true;
                        // 현재 포지션을 들고 있는지 여부에 따라서 다르게 처리
                        switch (_status.PosType)
                        {
                            case CType.매수:
                                if (자동스위칭) 매도스위칭();
                                else 일괄청산();
                                break;
                            case CType.매도:
                                // 매도 포지션 들고 있을때 또 매도가 들어오면 아무것도 하지 않음
                                break;
                            case CType.없음:
                                매도진입();
                                break;
                        }
                    }
                }
            }));
        }
        private void Cr_Buy()
        {
            this.Invoke(new MethodInvoker(delegate () { 
                lbl_매수발생.Visible = true;
                if (!진입중)       // 이미 주문이 실행중이라면  패스한다.
                {
                    if (자동매수)   // chk_자동매수 = true 인 경우에만 진행
                    {
                        매수체크 = true;
                        // 현재 포지션을 들고 있는지 여부에 따라서 다르게 처리
                        switch (_status.PosType)
                        {
                            case CType.매수:
                                // 매수 포지션 들고 있을때 또 매수가 들어오면 아무것도 하지 않음
                                break;
                            case CType.매도:
                                if (자동스위칭) 매수스위칭();
                                else 일괄청산();
                                break;
                            case CType.없음:
                                매수진입();
                                break;
                        }
                    }
                }
            }));
        }
        private void 매도진입()
        {
            진입중 = true;
            lbl_진입중.Visible = true;
            매도_Click(null, null);
            //this.btn_매도.PerformClick();
            //if (selectedItem != null)
            //{
            //    진입중 = true;
            //    SendOrder(VKeys.KEY_F12, selectedHandle, orderCountHandle, 기준계약수);
            //}
        }
        private void 매도스위칭()
        {
            진입중 = true;
            lbl_진입중.Visible = true;
            btn_매도스위칭_Click(null, null);
            //this.btn_매도스위칭.PerformClick();
            //if (selectedItem != null)
            //{
            //    진입중 = true;
            //    SendOrder(VKeys.KEY_F12, selectedHandle, orderCountHandle, 기준계약수 * 2);
            //}
        }
        private void 일괄청산()
        {
            진입중 = true;
            lbl_진입중.Visible = true;
            청산_Click(null, null);
            //this.btn_청산.PerformClick();
            //if (selectedItem != null)
            //{
            //    진입중 = true;
            //    SendOrder(VKeys.KEY_F11, selectedHandle, orderCountHandle, 기준계약수);
            //}
        }
        private void 매수스위칭()
        {
            진입중 = true;
            lbl_진입중.Visible = true;
            btn_매수스위칭_Click(null, null);
            //this.btn_매수스위칭.PerformClick();
            //if (selectedItem != null)
            //{
            //    진입중 = true;
            //    SendOrder(VKeys.KEY_F9, selectedHandle, orderCountHandle, 기준계약수 * 2);
            //}
        }
        private void 매수진입()
        {
            진입중 = true;
            lbl_진입중.Visible = true;
            매수_Click(null, null);
            //this.btn_매수.PerformClick();
            //if (selectedItem != null)
            //{
            //    진입중 = true;
            //    SendOrder(VKeys.KEY_F9, selectedHandle, orderCountHandle, 기준계약수);
            //}
        }




        private void Cr_UpdateEvent()
        {
            this.Invoke(new MethodInvoker(delegate () { pictureBox1.Image = cr?.CaptureBitmap ?? null; }));
        }

        private void chk_자동주문_CheckedChanged(object sender, EventArgs e)
        {
            this.자동매수 = chk_자동매수.Checked;
        }

        private void chk_자동스위칭_CheckedChanged(object sender, EventArgs e)
        {
            this.자동스위칭 = chk_자동스위칭.Checked;
        }

        private void chk_자동매도_CheckedChanged(object sender, EventArgs e)
        {
            this.자동매도 = chk_자동매도.Checked;
        }


        private void btn_매수설정_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            Ctrl_자동주문(false);
            colorTm = new Timer();
            colorTm.Interval = 50;
            colorTm.Tick += ColorTm_Tick;

            colorLb = lbl_매수컬러;
            signalLb = lbl_매수신호;

            colorTm.Start();
        }

        private void btn_매도설정_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            Ctrl_자동주문(false);
            colorTm = new Timer();
            colorTm.Interval = 50;
            colorTm.Tick += ColorTm_Tick;

            colorLb = lbl_매도컬러;
            signalLb = lbl_매도신호;

            colorTm.Start();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Keys key = keyData & ~(Keys.Shift | Keys.Control);

            switch (key)
            {
                //case Keys.F:
                //    // 조합키 사용 시
                //    if ((keyData & Keys.Control) != 0)
                //    {
                //        MessageBox.Show("Ctrl+F");
                //    }
                //    break;
                //case Keys.F5:
                //    // 단일키 사용시
                //    MessageBox.Show("f5");
                //    break;
                case Keys.Escape:
                    this.Cursor = Cursors.Default;
                    colorTm.Stop();
                    SaveInfo();
                    break;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }

            return true;

        }

        private void btn_일괄취소_Click(object sender, EventArgs e)
        {
            selectedItem = comboBox1.SelectedItem as ApplicationInfo;
            if (selectedItem != null)
            {
                SendOrder(VKeys.KEY_F6, selectedHandle, orderCountHandle, 기준계약수);

                진입중 = false;
                lbl_진입중.Visible = false;
            }

        }

        private void ColorTm_Tick(object sender, EventArgs e)
        {
            Point cursor = new Point();
            NativeWin32.GetCursorPos(ref cursor);

            var c = GetColorAt(cursor);
            colorLb.BackColor = c;
            signalLb.Text = $"{RGBConverter(c)} / {HexConverter(c)}";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            기준계약수 = (int)numericUpDown1.Value;
        }



        private static String HexConverter(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        private static String RGBConverter(System.Drawing.Color c)
        {
            return "RGB(" + c.R.ToString() + "," + c.G.ToString() + "," + c.B.ToString() + ")";
        }



        
        public Color GetColorAt(Point location)
        {
            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = NativeWin32.BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }

            return screenPixel.GetPixel(0, 0);
        }

    }
}
