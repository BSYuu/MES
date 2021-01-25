using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES
{
    public class 제품Data : EntityData<제품>
    {
        public int Get제품_규격(string 제품번호)
        {
            using(ERPEntities context = new ERPEntities())
            {
                var query = from x in context.제품
                            select x;

                int 규격 = 0;

                foreach(var item in query)
                {
                    if (item.제품번호 == 제품번호)
                        규격 = item.외경;
                }

                return 규격;
            }
        }

        public string Get제품_제품명(string 제품번호)
        {
            using(ERPEntities context = new ERPEntities())
            {
                var query = from x in context.제품
                            select x;

                string 제품명 = null;
                
                foreach(var item in query)
                {
                    if (item.제품번호 == 제품번호)
                        제품명 = item.제품명;
                }

                return 제품명;
            }
        }
        
        public List<제품> Get제품_All()
        {
            using (ERPEntities context = new ERPEntities())
            {
                var q = from x in context.제품
                        select x;


                return q.ToList();
            }
        }

        
    }
}
