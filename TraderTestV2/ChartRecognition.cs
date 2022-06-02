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
        public bool IsSignaled { get { return (_isBuySignaled || _isSellSignaled); } }
        public byte FromCr { get; set; }
        public int MinRecogSize { get; set; } = 10;
        public bool IsCenter { get { return this.Set.RecogMode == 인식모드.신호인식 ? true : false; } }
        public int BodySize { get { return Math.Max(_buyCount, _sellCount); } }

        private bool _isBuySignaled = false;
        private bool _isSellSignaled = false;


        private Timer timer;
        private Bitmap bmp;
        private Graphics g;

        private int _buyCount = 0;
        private int _sellCount = 0;

        public delegate void deleUpdate();
        public event deleUpdate UpdateEvent;

        public delegate void deleBuy(byte fromCr);
        public delegate void deleSell(byte fromCr);
        public delegate void deleClear();
        public event deleBuy Buy;
        public event deleSell Sell;
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
            bmp = !reset ?  new Bitmap(RecogArea.Width, RecogArea.Height, PixelFormat.Format24bppRgb) : new Bitmap(1, 1, PixelFormat.Format24bppRgb); 
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

            Dictionary<Color, int> detect = new Dictionary<Color, int>();
            switch (Set.RecogMode)
            {
                case 인식모드.몸통인식:
                    detect.Add(Set.Body_P, 0);
                    detect.Add(Set.Body_N, 0);
                    break;

                case 인식모드.신호인식:
                    detect.Add(Set.Buy, 0);
                    detect.Add(Set.Sell, 0);
                    detect.Add(Set.BuyOut, 0);
                    detect.Add(Set.SellOut, 0);
                    break;
            }


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

                            foreach (var item in detect)
                            {
                                Color col = Color.FromArgb(r, g, b);
                                if (detect.Keys.Contains(col))
                                {
                                    
                                }
                            }

                            if ((BuyColor.R == r) && (BuyColor.G == g) && (BuyColor.B == b)) _buyCount += 1;
                            if ((SellColor.R == r) && (SellColor.G == g) && (SellColor.B == b)) _sellCount += 1;

                            p += 3;
                        }
                        p = p + nOffset;
                    }
                    newBmp.UnlockBits(bmpData);
                }
            }


            if (_buyCount > MinRecogSize) { this._isBuySignaled = true; this.Buy(this.FromCr); } else { this._isBuySignaled = false; }
            if (_sellCount > MinRecogSize) { this._isSellSignaled = true; this.Sell(this.FromCr); } else { this._isSellSignaled = false; }


        }



        private void ImageUpdate()
        {
            try
            {
                g.CopyFromScreen(Set.RecogArea.Left, Set.RecogArea.Top, 0, 0, Set.RecogArea.Size, CopyPixelOperation.SourceCopy);

                this.UpdateEvent();
            }
            catch (Exception)
            {
            }
        }

    }
}
