using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES
{
    public class 불량상세정보Data : EntityData<불량상세정보>
    {
        public int Get불량수량(string 자재번호)
        {
            using(ERPEntities context = new ERPEntities())
            {
                var query = from x in context.불량상세정보
                            select x;

                int 불량수량 = 0;
                
                foreach(var item in query)
                {
                    if (item.자재번호 == 자재번호)
                        불량수량 = item.불량수량;
                }

                return 불량수량;
            }
        }
    }
}
