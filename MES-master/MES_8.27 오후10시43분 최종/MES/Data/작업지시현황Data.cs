using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES
{
    public class 작업지시현황Data : EntityData<작업지시현황>
    {
        public int Get지시수량(string 제품번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.작업지시현황
                            select x;

                int 지시수량 = 0;

                foreach(var item in query)
                {
                    if (item.제품번호 == 제품번호)
                        지시수량 = item.수량;
                }

                return 지시수량;
            }
        }

        public List<작업지시현황> GetAll2()
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.작업지시현황
                            select x;

                return query.ToList();
            }
        }
    }
}
