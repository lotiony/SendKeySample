using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraderTestV2
{
    public class Status
    {
        public CType OldPosType { get; set; } = CType.없음;
        public CType PosType { get; set; } = CType.없음;
        public int Contracts { get; set; } = 0;
        public decimal InPrice { get; set; } = decimal.Zero;
        public int Profit { get; set; } = 0;

    }

    public enum CType
    {
        매수,
        매도,
        없음
    }

    public class OneTrade
    {
        public bool 매수거래 { get; set; } = false;
        public bool 매도거래 { get; set; } = false;
        public int 최대익절 { get; set; }
        public bool 매수거래완료 { get; set; } = false;
        public bool 매도거래완료 { get; set; } = false;
    }

    public class AutoProfit
    {
        public bool 손절 { get; set; }
        public bool 익절 { get; set; }
        public bool 최소익절 { get; set; }
        public int 손절타겟 { get; set; }
        public int 익절타겟 { get; set; }
        public int 최소익절타겟 { get; set; }
        public int 감소폭 { get; set; }
    }
}
