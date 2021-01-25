using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES
{
    public class 자재명세서Data : EntityData<자재명세서>
    {
        public string Get자재번호(string 제품번호)
        {
            using(ERPEntities context = new ERPEntities())
            {
                var query = from x in context.자재명세서
                            select x;

                string 자재번호 = null;
                
                foreach(var item in query)
                {
                    if (item.제품번호 == 제품번호)
                        자재번호 = item.자재번호;

                }

                return 자재번호;
            }
        }
    }
}
