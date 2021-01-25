using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES
{
    public class 생산계획Data : EntityData<생산계획현황>
    {
        public int Get생산수량(string 제품번호)
        {
            using(ERPEntities context = new ERPEntities())
            {
                var query = from x in context.생산계획현황
                            select x;

                int 생산수량 = 0;
                
                foreach(var item in query)
                {
                    if (item.제품번호 == 제품번호)
                        생산수량 = item.수량;
                }

                return 생산수량;
            }
        }
    }
}
