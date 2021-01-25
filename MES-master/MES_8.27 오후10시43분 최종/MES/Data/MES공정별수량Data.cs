using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES

{
    public class MES공정별수량Data : EntityData<MES공정별수량>
    {
        public MES공정별수량 Get공정별수량(string 관리번호)
        {
            using(ERPEntities context = new ERPEntities())
            {
                var q = from x in context.MES공정별수량
                        where x.관리번호 == 관리번호
                        select x;

                MES공정별수량 MES공정별수량c = new MES공정별수량();

                foreach (var item in q)
                {
                    MES공정별수량c.제품번호 = item.제품번호;
                    MES공정별수량c.관리번호 = item.관리번호;
                    MES공정별수량c.절단생산수량 = item.절단생산수량;
                    MES공정별수량c.절단불량수량 = item.절단불량수량;
                    MES공정별수량c.벤딩생산수량 = item.벤딩생산수량;
                    MES공정별수량c.벤딩불량수량 = item.벤딩불량수량;
                    MES공정별수량c.드릴생산수량 = item.드릴생산수량;
                    MES공정별수량c.드릴불량수량 = item.드릴불량수량;
                    MES공정별수량c.용접생산수량 = item.용접생산수량;
                    MES공정별수량c.용접불량수량 = item.용접불량수량;
                    MES공정별수량c.실적시간 = item.실적시간;
                    MES공정별수량c.완료유무 = item.완료유무;
                }

                return MES공정별수량c;
            }
        }
    }
}
