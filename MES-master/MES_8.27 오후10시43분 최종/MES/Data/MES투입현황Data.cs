using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES
{
    public class MES투입현황Data : EntityData<MES투입현황>
    {
        public List<MES투입현황> Get투입현황()
        {

            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.MES투입현황
                            orderby x.투입일 ascending
                            select x;

                return query.ToList();
            }

        }

        public Dictionary<string,int> Get투입현황_투입개수()
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from p in context.MES투입현황
                            group p by p.제품번호 into g
                            select new
                            {
                                제품번호 = g.Key,
                                ProductCount = g.Count()
                            };
 
                Dictionary<string, int> list = new Dictionary<string, int>();

                foreach (var item in query)
                {
                    list.Add(item.제품번호.Trim(), item.ProductCount); 
                }


                return list;

            }
        }

        public List<MES투입현황> Get투입현황_Rows(string 관리번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var q = from a in context.MES투입현황
                        where a.관리번호 == 관리번호
                        select a;

                return q.ToList();

            }
        }
    }
}
