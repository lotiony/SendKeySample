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
}
