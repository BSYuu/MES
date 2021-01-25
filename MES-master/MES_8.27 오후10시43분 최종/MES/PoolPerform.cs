using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES
{
    public partial class PoolPerform : UserControl
    {
        public PoolPerform()
        {
            InitializeComponent();
        }

        private void Btn조회_Click(object sender, EventArgs e)
        {
            using (ERPEntities context = new ERPEntities())
            {
                grid불량실적조회.Rows.Clear();

                var q = from a in context.MES불량실적현황
                        select a;

                var 실적q = from a in context.MES현장실적현황
                          select a;

                var rq = from a in q
                         join b in 실적q on a.관리번호 equals b.관리번호
                         select new
                         {
                             a.관리번호,
                             a.등록시간,
                             a.불량수량,
                             a.비고,
                             a.실적번호,
                             a.제품번호,
                             b.작업자,
                             b.설비명,
                             b.공정명
                         };


                if (!tbx품목번호.Text.IsNullOrEmpty())
                {
                    rq = from a in rq
                         where a.제품번호.Contains(tbx품목번호.Text.ToString())
                         select a;
                }


                if (dtFirst != null && dtLast != null)
                {
                    DateTime Startday = DateTime.Parse(dtFirst.Value.ToString("yyyy-MM-dd"));
                    DateTime Endday = DateTime.Parse(dtLast.Value.ToString("yyyy-MM-dd"));

                    rq = from b in rq
                         where Startday <= b.등록시간 &&
                         Endday >= b.등록시간
                         select b;
                }


                if (!((string)cbb공정.SelectedItem).IsNullOrEmpty())
                {
                    rq = from a in rq
                        where ((string)cbb공정.SelectedItem).Contains(a.공정명)
                        select a;
                }

                if (!tbx관리번호.Text.IsNullOrEmpty())
                {
                    rq = from a in rq
                         where a.관리번호.Contains(tbx관리번호.Text)
                         select a;
                }


                if (!tbx사원번호.Text.IsNullOrEmpty())
                {
                    rq = from a in rq
                         where (from x in context.사원등록
                                where a.작업자 == x.사원명
                                select x.사원코드).Contains(tbx사원번호.Text)
                         select a;
                }

                if (rq.Count() <= 0)
                {
                    MessageBox.Show("검색된 데이터가 없습니다");
                    return;
                }

                int ColumnIndex = 0;
                int 불량실적행번호 = 0;

                foreach (var item in rq)
                {
                    ColumnIndex = 0;

                    grid불량실적조회.Rows.Add();
                    grid불량실적조회.Rows[불량실적행번호].Cells[ColumnIndex++].Value = item.관리번호;
                    grid불량실적조회.Rows[불량실적행번호].Cells[ColumnIndex++].Value = item.제품번호;
                    grid불량실적조회.Rows[불량실적행번호].Cells[ColumnIndex++].Value = item.불량수량;
                    grid불량실적조회.Rows[불량실적행번호].Cells[ColumnIndex++].Value = item.공정명;
                    grid불량실적조회.Rows[불량실적행번호].Cells[ColumnIndex++].Value = item.작업자;
                    grid불량실적조회.Rows[불량실적행번호].Cells[ColumnIndex++].Value = item.등록시간;
                    grid불량실적조회.Rows[불량실적행번호].Cells[ColumnIndex++].Value = item.비고;

                    불량실적행번호++;
                }
            }

        }
    }
}
