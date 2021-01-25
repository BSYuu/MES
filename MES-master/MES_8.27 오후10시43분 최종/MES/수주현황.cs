using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES
{
    class 수주현황
    {

        public string 제품번호 { get; set; }
        public int 주문수량 { get; set; }
        public DateTime 납기일 { get; set; }
        public int 순위정보 { get; set; }
    }
}
