using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WindowsFormsApp1
{
    public class ChartRecognition
    {
        public Rectangle ChartArea { get; set; }
        public Color BuyColor { get; set; }
        public Color SellColor { get; set; }
        public Bitmap CaptureBitmap { get { return bmp; } }


        private Timer timer;
        private Bitmap bmp;
        private Graphics g;

        private int _buyCount = 0;
        private int _sellCount = 0;

        public delegate void deleUpdate();
        public event deleUpdate UpdateEvent;

        public delegate void deleBuy();
        public delegate void deleSell();
        public delegate void deleClear();
        public event deleBuy Buy;
        public event deleSell Sell;
        public event deleClear Clear;

        public ChartRecognition(Rectangle chartArea, Color buyColor, Color sellColor)
        {
            ChartArea = chartArea;
            BuyColor = buyColor;
            SellColor = sellColor;

            timer = new Timer();
            timer.Interval = 100;
            timer.Elapsed += Timer_Elapsed;

            bmp = new Bitmap(ChartArea.Width, ChartArea.Height, PixelFormat.Format24bppRgb);
            g = Graphics.FromImage(bmp);
        }
        public void Update(Rectangle chartArea, Color buyColor, Color sellColor)
        {
            ChartArea = chartArea;
            BuyColor = buyColor;
            SellColor = sellColor;

            bmp = new Bitmap(ChartArea.Width, ChartArea.Height, PixelFormat.Format24bppRgb);
            g = Graphics.FromImage(bmp);

        }

        public void Start() => timer.Start();

        public void Stop() => timer.Stop();



        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            ImageUpdate();
            ImageRecognize();
        }

        private void ImageRecognize()
        {
            this.Clear();
            int center = (int)(bmp.Width / 2);
            this._buyCount = 0;
            this._sellCount = 0;

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

                            if ((BuyColor.R == r) && (BuyColor.G == g) && (BuyColor.B == b)) _buyCount += 1;
                            if ((SellColor.R == r) && (SellColor.G == g) && (SellColor.B == b)) _sellCount += 1;

                            p += 3;
                        }
                        p = p + nOffset;
                    }
                    newBmp.UnlockBits(bmpData);
                }
            }


            if (_buyCount > 10) this.Buy();
            if (_sellCount > 10) this.Sell();
            

        }

        private void ImageUpdate()
        {
            g.CopyFromScreen(ChartArea.Left, ChartArea.Top, 0, 0, ChartArea.Size, CopyPixelOperation.SourceCopy);
            
            this.UpdateEvent();
        }
    }
}
