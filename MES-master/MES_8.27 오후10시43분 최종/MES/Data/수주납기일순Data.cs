using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES
{
    public class 수주납기일순Data
    {
        public string 제품번호 { get; set; }
        public DateTime 납기일 { get; set; }
        public int 주문수량 { get; set; }
        public int 순위 { get; set; }
        public int 리드타임 { get; set; }
        public DateTime 리드타임_납기일 { get; set; }
    }
}
