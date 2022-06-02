using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraderTestV2
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrm());
        }
    }
    
    public enum HtsControls
    {
        EDITBOX = 1,
        LBL_POS = 2,
        LBL_CONT = 3,
        LBL_PRICE = 4,
        LBL_PGSI = 5,
    }
}
