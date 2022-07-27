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
    public class BarRecognition
    {
        public Setting Set { get; set; }
        public Rectangle RecogArea { get; set; }
        public Bitmap CaptureBitmap { get { return bmp; } }

        private Timer timer;
        private Bitmap bmp;
        private Graphics g;
        private int[] barColorArr;

        public delegate void deleUpdate();
        public event deleUpdate UpdateEvent;

        public BarRecognition(Setting valSet, double interval, byte fromCr)
        {
            this.Set = valSet;
            // 인식영역 박스만 별도 인스턴스로 관리
            this.RecogArea = new Rectangle(valSet.RecogArea.Location, valSet.RecogArea.Size);

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
                ImageRecognize();
            }
            catch (Exception)
            {
            }
        }


        private void ImageRecognize()
        {
            try
            {
                g.CopyFromScreen(this.RecogArea.Left, this.RecogArea.Top, 0, 0, this.RecogArea.Size, CopyPixelOperation.SourceCopy);

                //int center = IsCenter ? (int)(bmp.Width / 2) : (int)(bmp.Width / 3 * 2);
                int center = (int)(bmp.Width / 2 + 3);
                int[] colorArr = new int[bmp.Height];

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

                                colorArr[y] = Color.FromArgb(r, g, b).ToArgb();

                                p += 3;
                            }
                            p = p + nOffset;
                        }
                        newBmp.UnlockBits(bmpData);
                    }

                    if (barColorArr == null || !barColorArr.SequenceEqual(colorArr))
                    {
                        barColorArr = colorArr;
                        UpdateEvent();
                    }
                    else
                    {
                        
                    }
                }

            }
            catch (Exception)
            {

            }
        }

    }
}
