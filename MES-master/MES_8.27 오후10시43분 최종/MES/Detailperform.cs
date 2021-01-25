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
    public partial class Detailperform : UserControl
    {
        public Detailperform()
        {
            InitializeComponent();
        }

        private void Detailperform_Load(object sender, EventArgs e)
        {

        }

        private void Btn조회_Click(object sender, EventArgs e)
        {
            using (ERPEntities context = new ERPEntities())
            {
                grid상세실적조회.Rows.Clear();

                var q = from a in context.MES현장실적현황
                        select a;

                if (!tbx제품번호.Text.IsNullOrEmpty())
                {
                    q = from a in q
                        where a.제품번호.Contains(tbx제품번호.Text.ToString())
                        select a;
                }

                if (!((string)cbb공정.SelectedItem).IsNullOrEmpty())
                {
                    q = from a in q
                        where ((string)cbb공정.SelectedItem).Contains(a.공정명)
                        select a;
                }


                if (dtFirst != null && dtLast != null)
                {
                    DateTime Startday = DateTime.Parse(dtFirst.Value.ToString("yyyy-MM-dd"));
                    DateTime Endday = DateTime.Parse(dtLast.Value.ToString("yyyy-MM-dd"));

                    q = from b in q
                        where Startday <= b.실적등록시간 &&
                        Endday >= b.실적등록시간
                        select b;
                }

                if (!tbx관리번호.Text.IsNullOrEmpty())
                {
                    q = from a in q
                        where a.관리번호.Contains(tbx관리번호.Text.ToString())
                        select a;
                }

                if (!tbx사원번호.Text.IsNullOrEmpty())
                {
                    q = from a in q
                        where (from x in context.사원등록
                               where a.작업자 == x.사원명
                               select x.사원코드).Contains(tbx사원번호.Text.ToString())
                        select a;
                }

                var 완료관리번호 = q.Where(a => a.완료유무 == true).Select(a => a.관리번호).Distinct().ToList();

                List<MES현장실적현황> 현장실적헌황s = new List<MES현장실적현황>();
                foreach (var 완료item in 완료관리번호)
                {
                    foreach (var 실적item in q)
                    {
                        if (실적item.관리번호 == 완료item)
                        {
                            현장실적헌황s.Add(실적item);
                        }
                    }
                }

                int ColumnIndex = 0;
                int 생산실적행번호 = 0;
                
                if(현장실적헌황s.Count() <= 0)
                {
                    MessageBox.Show("검색된 데이터가 없습니다");
                    return;
                }

                foreach (var item in 현장실적헌황s)
                {
                    ColumnIndex = 0;

                    grid상세실적조회.Rows.Add();
                    grid상세실적조회.Rows[생산실적행번호].Cells[ColumnIndex++].Value = item.관리번호;
                    grid상세실적조회.Rows[생산실적행번호].Cells[ColumnIndex++].Value = item.제품번호;
                    grid상세실적조회.Rows[생산실적행번호].Cells[ColumnIndex++].Value = item.실적수량;
                    grid상세실적조회.Rows[생산실적행번호].Cells[ColumnIndex++].Value = item.불량수량;
                    grid상세실적조회.Rows[생산실적행번호].Cells[ColumnIndex++].Value = item.공정명;
                    grid상세실적조회.Rows[생산실적행번호].Cells[ColumnIndex++].Value = item.작업자;
                    grid상세실적조회.Rows[생산실적행번호].Cells[ColumnIndex++].Value = item.실적등록시간;

                    생산실적행번호++;
                }

            }
        }


    }
}
