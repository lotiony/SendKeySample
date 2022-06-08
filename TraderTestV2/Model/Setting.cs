using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraderTestV2.Model
{
    public class Setting
    {
        public Rectangle RecogArea { get; set; }
        public Color Body_P { get; set; }
        public Color Body_N { get; set; }
        public Color Buy { get; set; }
        public Color Sell { get; set; }
        public Color BuyOut { get; set; }
        public Color SellOut { get; set; }
        public Color COIBuy { get; set; }
        public Color COISell { get; set; }
        public int BodySize { get; set; }
        public 인식모드 RecogMode { get; set; }

        public Setting(Rectangle recogArea, Color body_P, Color body_N, Color buy, Color sell, Color buyOut, Color sellOut, Color coiBuy, Color coiSell, int bodySize, 인식모드 recogMode)
        {
            RecogArea = recogArea;
            Body_P = body_P;
            Body_N = body_N;
            Buy = buy;
            Sell = sell;
            BuyOut = buyOut;
            SellOut = sellOut;
            COIBuy = coiBuy;
            COISell = coiSell;
            BodySize = bodySize;
            RecogMode = recogMode;
        }
    }

    public enum 컬러설정
    {
        양봉,
        음봉,
        매수,
        매도,
        매수청산,
        매도청산,
        COI매수,
        COI매도
    }

    public enum 인식모드
    {
        몸통인식,
        신호인식
    }
}
