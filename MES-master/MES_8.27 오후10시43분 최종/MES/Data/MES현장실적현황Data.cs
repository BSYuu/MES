using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES
{
    public class MES현장실적현황Data : EntityData<MES현장실적현황>
    {
        public string Get현장실적현황_설비명(string 관리번호)
        {
            using (ERPEntities context = new ERPEntities())
            {

                var 현장실적query = from x in context.MES현장실적현황
                                select x;


                return 현장실적query.Where(w => w.관리번호 == 관리번호).Select(s => s.설비명).ToString();
                //string 설비명 = null;

                //foreach(var item in 현장실적query)
                //{
                //    if (item.관리번호 == 관리번호)
                //        설비명 = item.설비명;
                //}

                //return 설비명;
            }
        }

        public List<MES현장실적현황> GetALL()
        {
            using (ERPEntities context = new ERPEntities())
            {

                var 현장실적query = from x in context.MES현장실적현황
                                select x;


                return 현장실적query.ToList();
            }
        }

        public DateTime Get작업시작()
        {
             DateTime 작업시작 = DateTime.Now;
             return 작업시작;
        }

        public void Set현장실적현황()
        {
            using (ERPEntities context = new ERPEntities())
            {
                //context.SaveChanges
            }
        }
        
    }
}
