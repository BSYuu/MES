using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES
{
    public class 공정시작수량Data
    {
        //제품번호, 1차공정시작, 1차필요수량, 1차공정시작날짜, 2차공정시작, 2차필요수량, 2차공정시작날짜, LOT수량
        //string, boolean, int, DateTime, boolean, int, DateTime, int
        
        public string 제품번호 { get; set; }
        public Boolean _1차공정시작 { get; set; }
        public string _1차관리번호 { get; set; }
        public int _1차필요수량 { get; set; }
        public DateTime _1차공정시작날짜 { get; set; }
        public int 순위 { get; set; }
        public Boolean _2차공정시작 { get; set; }
        public string _2차관리번호 { get; set; }
        public int _2차필요수량 { get; set; }
        public DateTime _2차공정시작날짜 { get; set; }
        public int LOT수량 { get; set; }
        public int 재고량 { get; set; }

    }
}
