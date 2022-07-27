using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace TraderTestV2
{
    public class Ocr
    {
        private TesseractEngine engine;

        public Ocr()
        {
            engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default);
            engine.SetVariable("tessedit_char_whitelist", "0123456789.-");
        }

        public string RecogNumber(System.Drawing.Bitmap bitmap)
        {
            try
            {
                using (var page = engine.Process(bitmap))
                {
                    return page.GetText();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
