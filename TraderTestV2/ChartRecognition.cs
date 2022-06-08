using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using TraderTestV2.Model;

namespace TraderTestV2
{
    public class ChartRecognition
    {
        public Setting Set { get; set; }
        public Rectangle RecogArea { get; set; }
        public Bitmap CaptureBitmap { get { return bmp; } }
        public byte FromCr { get; set; }
        public int MinRecogSize { get; set; } = 10;
        public bool IsCoiBuy { get { return this._isCoiBuySignaled; } }
        public bool IsCoiSell { get { return this._isCoiSellSignaled; } }

        public bool IsSignaled { get { return (_isBuySignaled || _isSellSignaled || _isBodyPSignaled || _isBodyNSignaled || _isBuyOutSignaled || _isSellOutSignaled); } }
        private bool _isBuySignaled = false;
        private bool _isSellSignaled = false;
        private bool _isBodyPSignaled = false;
        private bool _isBodyNSignaled = false;
        private bool _isBuyOutSignaled = false;
        private bool _isSellOutSignaled = false;
        private bool _isCoiBuySignaled = false;
        private bool _isCoiSellSignaled = false;


        private Timer timer;
        private Bitmap bmp;
        private Graphics g;

        public delegate void deleUpdate();
        public event deleUpdate UpdateEvent;

        public delegate void deleSignal(byte fromCr);
        public delegate void deleClear();
        public event deleSignal Buy;
        public event deleSignal Sell;
        public event deleSignal BodyP;
        public event deleSignal BodyN;
        public event deleSignal BuyOut;
        public event deleSignal SellOut;
        public event deleSignal CoiBuy;
        public event deleSignal CoiSell;
        public event deleClear Clear;

        public ChartRecognition(Setting valSet, double interval, byte fromCr)
        {
            this.Set = valSet;
            // 인식영역 박스만 별도 인스턴스로 관리
            this.RecogArea = new Rectangle(valSet.RecogArea.Location, valSet.RecogArea.Size);
            this.FromCr = fromCr;

            timer = new Timer();
            timer.Interval = interval;
            timer.Elapsed += Timer_Elapsed;

            bitmap();

        }


        private void bitmap(bool reset = false)
        {
            bmp = !reset ?  new Bitmap(this.RecogArea.Width, this.RecogArea.Height, PixelFormat.Format24bppRgb) : new Bitmap(1, 1, PixelFormat.Format24bppRgb); 
            g = Graphics.FromImage(bmp);
        }
         
        public void Update(Setting set)
        {
            this.Set = set;
            this.RecogArea = new Rectangle(Set.RecogArea.Location, Set.RecogArea.Size);
            bitmap();
        }

        public void Update(Rectangle rect)
        {
            this.RecogArea = new Rectangle(rect.Location, rect.Size); ;
            bitmap();
        }

        public void Start()
        {
            bitmap();
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
            bitmap(true);
        }


        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                ImageUpdate();
                ImageRecognize();
            }
            catch (Exception)
            {
            }
        }


        private void ImageRecognize()
        {
            this.Clear();
            //int center = IsCenter ? (int)(bmp.Width / 2) : (int)(bmp.Width / 3 * 2);
            int center = (int)(bmp.Width / 3 * 2);

            int _count1 = 0;
            int _count2 = 0;
            int _count3 = 0;
            int _count4 = 0;
            int _count5 = 0;
            int _count6 = 0;
            int _count7 = 0;
            int _count8 = 0;
            _isBuySignaled = false;
            _isSellSignaled = false;
            _isBodyPSignaled = false;
            _isBodyNSignaled = false;
            _isBuyOutSignaled = false;
            _isSellOutSignaled = false;
            _isCoiBuySignaled = false;
            _isCoiSellSignaled = false;


            using (Bitmap newBmp = bmp.Clone(new Rectangle(center, 0, 1, bmp.Height), bmp.PixelFormat))
            {
                BitmapData bmpData = newBmp.LockBits(new Rectangle(0, 0, 1, newBmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                int stride = bmpData.Stride; //<2>
                IntPtr scan0 = bmpData.Scan0; //<3>

                unsafe
                {
                    byte* p = (byte*)(void*)scan0;
                    int nOffset = stride - newBmp.Width * 3;
                    int nWidth = newBmp.Width * 3;

                    for (int y = 0; y < bmpData.Height; y++)
                    {
                        for (int x = 0; x < newBmp.Width; x++)
                        {
                            byte b = p[0];
                            byte g = p[1];
                            byte r = p[2];

                            switch (Set.RecogMode)
                            {
                                case 인식모드.몸통인식:
                                    if ((Set.Body_P.R == r) && (Set.Body_P.G == g) && (Set.Body_P.B == b)) _count1 += 1;
                                    if ((Set.Body_N.R == r) && (Set.Body_N.G == g) && (Set.Body_N.B == b)) _count2 += 1;
                                    if ((Set.COIBuy.R == r) && (Set.COIBuy.G == g) && (Set.COIBuy.B == b)) _count7 += 1;
                                    if ((Set.COISell.R == r) && (Set.COISell.G == g) && (Set.COISell.B == b)) _count8 += 1;
                                    break;

                                case 인식모드.신호인식:
                                    if ((Set.Buy.R == r) && (Set.Buy.G == g) && (Set.Buy.B == b)) _count3 += 1;
                                    if ((Set.Sell.R == r) && (Set.Sell.G == g) && (Set.Sell.B == b)) _count4 += 1;
                                    if ((Set.BuyOut.R == r) && (Set.BuyOut.G == g) && (Set.BuyOut.B == b)) _count5 += 1;
                                    if ((Set.SellOut.R == r) && (Set.SellOut.G == g) && (Set.SellOut.B == b)) _count6 += 1;
                                    break;
                            }

                            p += 3;
                        }
                        p = p + nOffset;
                    }
                    newBmp.UnlockBits(bmpData);
                }
            }

            switch (Set.RecogMode)
            {
                /// 몸통인식일 땐 메인 영역만 체크한다.
                case 인식모드.몸통인식:
                    /// 몸통인식일때 COI 신호를 보고 진입신호를 구분한다.
                    if (_count7 > this.MinRecogSize && FromCr == 1) { this._isCoiBuySignaled = true; } else { this._isCoiBuySignaled = false; }
                    if (_count8 > this.MinRecogSize && FromCr == 1) { this._isCoiSellSignaled = true; } else { this._isCoiSellSignaled = false; }

                    if (_count1 > this.Set.BodySize && FromCr == 1) { this._isBodyPSignaled = true; this.BodyP(this.FromCr); } else { this._isBodyPSignaled = false; }
                    if (_count2 > this.Set.BodySize && FromCr == 1) { this._isBodyNSignaled = true; this.BodyN(this.FromCr); } else { this._isBodyNSignaled = false; }
                    break;

                case 인식모드.신호인식:
                    if (_count3 > this.MinRecogSize) { this._isBuySignaled = true; this.Buy(this.FromCr); return; } else { this._isBuySignaled = false; }
                    if (_count4 > this.MinRecogSize) { this._isSellSignaled = true; this.Sell(this.FromCr); return; } else { this._isSellSignaled = false; }
                    if (_count5 > this.MinRecogSize) { this._isBuyOutSignaled = true; this.BuyOut(this.FromCr); } else { this._isBuyOutSignaled = false; }
                    if (_count6 > this.MinRecogSize) { this._isSellOutSignaled = true; this.SellOut(this.FromCr); } else { this._isSellOutSignaled = false; }
                    break;
            }


            //if (_buyCount > MinRecogSize) { this._isBuySignaled = true; this.Buy(this.FromCr); } else { this._isBuySignaled = false; }
            //if (_sellCount > MinRecogSize) { this._isSellSignaled = true; this.Sell(this.FromCr); } else { this._isSellSignaled = false; }


        }



        private void ImageUpdate()
        {
            try
            {
                g.CopyFromScreen(this.RecogArea.Left, this.RecogArea.Top, 0, 0, this.RecogArea.Size, CopyPixelOperation.SourceCopy);

                this.UpdateEvent();
            }
            catch (Exception)
            {
            }
        }

    }
}
