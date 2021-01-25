using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES
{
    public class 공정Data : EntityData<공정>
    {
        public string 공정순서_공정번호(string 제품번호)
        {
            using(ERPEntities context = new ERPEntities())
            {
                var query = from x in context.공정순서
                            select x;

                string 공정번호 = null;
                
                foreach(var item in query)
                {
                    if (item.제품번호 == 제품번호)
                        공정번호 = item.공정번호.ToString();
                }

                return 공정번호;
            }
        }

        public string 공정_공정명(string 공정번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.공정
                            select x;



                string 공정명 = null;

                foreach(var item in query)
                {
                    if (item.공정번호.ToString() == 공정번호)
                        공정명 = item.공정명;

                }

                return 공정명;


            }
        }
    }
}
