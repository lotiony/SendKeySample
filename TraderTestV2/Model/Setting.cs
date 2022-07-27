using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace TraderTestV2.Model
{
    public class Setting
    {
        public Rectangle RecogArea { get; set; } = new Rectangle();

        [ScriptIgnore]
        public Color Body_P { get; set; } = Color.White;
        [ScriptIgnore]
        public Color Body_N { get; set; } = Color.White;
        [ScriptIgnore]
        public Color Buy { get; set; } = Color.White;
        [ScriptIgnore]
        public Color Sell { get; set; } = Color.White;
        [ScriptIgnore]
        public Color BuyOut { get; set; } = Color.White;
        [ScriptIgnore]
        public Color SellOut { get; set; } = Color.White;
        [ScriptIgnore]
        public Color COIBuy { get; set; } = Color.White;
        [ScriptIgnore]
        public Color COISell { get; set; } = Color.White;
        [ScriptIgnore]
        public Color HBo { get; set; } = Color.White;



        public int BodySize { get; set; } = 10;

        public 인식모드 RecogMode { get; set; } = 인식모드.몸통인식;

        public string ColorP
        {
            get { return ColorTranslator.ToHtml(Body_P); }
            set { Body_P = ColorTranslator.FromHtml(value); }
        }
        public string ColorN
        {
            get { return ColorTranslator.ToHtml(Body_N); }
            set { Body_N = ColorTranslator.FromHtml(value); }
        }
        public string ColorB
        {
            get { return ColorTranslator.ToHtml(Buy); }
            set { Buy = ColorTranslator.FromHtml(value); }
        }
        public string ColorS
        {
            get { return ColorTranslator.ToHtml(Sell); }
            set { Sell = ColorTranslator.FromHtml(value); }
        }
        public string ColorBO
        {
            get { return ColorTranslator.ToHtml(BuyOut); }
            set { BuyOut = ColorTranslator.FromHtml(value); }
        }
        public string ColorSO
        {
            get { return ColorTranslator.ToHtml(SellOut); }
            set { SellOut = ColorTranslator.FromHtml(value); }
        }
        public string ColorCB
        {
            get { return ColorTranslator.ToHtml(COIBuy); }
            set { COIBuy = ColorTranslator.FromHtml(value); }
        }
        public string ColorCS
        {
            get { return ColorTranslator.ToHtml(COISell); }
            set { COISell = ColorTranslator.FromHtml(value); }
        }
        public string ColorHBo
        {
            get { return ColorTranslator.ToHtml(HBo); }
            set { HBo = ColorTranslator.FromHtml(value); }
        }

        public bool UseHBo { get; set; } = true;

        public Setting() { }

        public Setting(Rectangle recogArea, Color body_P, Color body_N, Color buy, Color sell, Color buyOut, Color sellOut, Color coiBuy, Color coiSell, Color hbo, int bodySize, 인식모드 recogMode, bool useHBo)
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
            HBo = hbo;
            BodySize = bodySize;
            RecogMode = recogMode;
            UseHBo = useHBo;
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
        COI매도,
        횡보신호
    }

    public enum 인식모드
    {
        몸통인식,
        신호인식
    }
}
