using System;
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
        public Form1()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 200;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (lbl_handle_포지션.Text != "0") lbl_포지션.Text = GetHandleText(new IntPtr(Int64.Parse(lbl_handle_포지션.Text)));
            if (lbl_handle_수량.Text != "0") lbl_수량.Text = GetHandleText(new IntPtr(Int64.Parse(lbl_handle_수량.Text)));
            if (lbl_handle_진입단가.Text != "0") lbl_진입단가.Text = GetHandleText(new IntPtr(Int64.Parse(lbl_handle_진입단가.Text)));
            if (lbl_handle_평가손익.Text != "0") lbl_평가손익.Text = GetHandleText(new IntPtr(Int64.Parse(lbl_handle_평가손익.Text)));
        }

        ObservableCollection<ApplicationInfo> applicationInfos;
        ApplicationInfo selectedItem;
        Timer timer;

        IntPtr selectedHandle { get { return selectedItem?.Handle ?? IntPtr.Zero; } }
        IntPtr orderCountHandle { get; set; }

        private void UpdateProcessList()
        {
            applicationInfos = WinAppServices.GetHts();
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

        /// <summary>
        /// 매도
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            selectedItem = comboBox1.SelectedItem as ApplicationInfo;
            if (selectedItem != null)
            {
                int baseCount = (int)numericUpDown1.Value;
                SendOrder(VKeys.KEY_F12, selectedHandle, orderCountHandle, baseCount);
                //sendKey(selectedItem.Handle, VKeys.KEY_F12, true);
                //vkey2.SendK(selectedItem.Handle, VKeys.KEY_F12);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 청산
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            selectedItem = comboBox1.SelectedItem as ApplicationInfo;
            if (selectedItem != null)
            {
                int baseCount = (int)numericUpDown1.Value;
                SendOrder(VKeys.KEY_F11, selectedHandle, orderCountHandle, baseCount);
                //sendKey(selectedItem.Handle, VKeys.KEY_F11, true);
                //vkey2.SendK(selectedItem.Handle, VKeys.KEY_F11);
            }
        }

        /// <summary>
        /// 매수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            selectedItem = comboBox1.SelectedItem as ApplicationInfo;
            if (selectedItem != null)
            {
                int baseCount = (int)numericUpDown1.Value;
                SendOrder(VKeys.KEY_F9, selectedHandle, orderCountHandle, baseCount);

                //sendKey(selectedItem.Handle, VKeys.KEY_F9, true);
                //vkey2.SendK(selectedItem.Handle, VKeys.KEY_F9);
            }
        }

        private void btn_매도스위칭_Click(object sender, EventArgs e)
        {
            selectedItem = comboBox1.SelectedItem as ApplicationInfo;
            if (selectedItem != null)
            {
                int baseCount = (int)numericUpDown1.Value;
                SendOrder(VKeys.KEY_F12, selectedHandle, orderCountHandle, baseCount * 2);
                //sendKey(selectedItem.Handle, VKeys.KEY_F9, true);
                //vkey2.SendK(selectedItem.Handle, VKeys.KEY_F9);
            }

        }

        private void btn_매수스위칭_Click(object sender, EventArgs e)
        {
            selectedItem = comboBox1.SelectedItem as ApplicationInfo;
            if (selectedItem != null)
            {
                int baseCount = (int)numericUpDown1.Value;

                SendOrder(VKeys.KEY_F9, selectedHandle, orderCountHandle, baseCount*2);
                //sendKey(selectedItem.Handle, VKeys.KEY_F9, true);
                //vkey2.SendK(selectedItem.Handle, VKeys.KEY_F9);
            }

        }

        SelectArea areaForm;
        Rectangle rect;
        private void btn_인식영역선택_Click(object sender, EventArgs e)
        {
            

            if (btn_인식영역선택.Text == "인식영역 선택")
            {
                btn_인식영역선택.Text = "선택 완료";

                areaForm = new SelectArea();
                areaForm.TopMost = true;
                areaForm.Show();
            }
            else
            {
                btn_인식영역선택.Text = "인식영역 선택";
                rect = new Rectangle(areaForm.Location, areaForm.Size);

                lbl_영역좌표.Text = $"({rect.X},{rect.Y}) ~ ({rect.Right},{rect.Bottom})";
                lbl_영역크기.Text = $"X = {rect.Width} Y = {rect.Height}";
                areaForm.Hide();

                PreviewPicture();
            }
            
            
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

        }

        private void chk_자동주문_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_매수설정_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
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
                    break;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }

            return true;

        }


        Timer colorTm;
        Label colorLb;
        Label signalLb;

        private void ColorTm_Tick(object sender, EventArgs e)
        {
            Point cursor = new Point();
            NativeWin32.GetCursorPos(ref cursor);

            var c = GetColorAt(cursor);
            colorLb.BackColor = c;
            signalLb.Text = $"{RGBConverter(c)} / {HexConverter(c)}";
        }

        private static String HexConverter(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        private static String RGBConverter(System.Drawing.Color c)
        {
            return "RGB(" + c.R.ToString() + "," + c.G.ToString() + "," + c.B.ToString() + ")";
        }

        Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
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
