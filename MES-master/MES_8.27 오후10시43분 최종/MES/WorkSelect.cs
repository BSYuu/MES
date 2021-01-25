using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace MES
{
    public partial class WorkSelect : UserControl
    {
        int MaxRow;
        const int PageCnt = 10; // 한페이지에 나올 행의 개수
        int TotPageCnt;
        int 현재페이지 = 1;


        public bool WorkStart = false;
        public event EventHandler UcWorkStart;
        public event EventHandler GridUpdate;
        public event EventHandler ButtonChanged;

        public WorkSelect()
        {
            InitializeComponent();
            grid작업지시목록.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void BtnWorkStart_Click(object sender, EventArgs e)
        {
            if (WorkStart == false)
            {
                if (lbl관리번호.Text == "")
                {
                    MessageBox.Show("작업할 Item을 선택하세요");
                    return;
                }

                string 품번 = grid작업지시목록.Rows[grid작업지시목록.CurrentCell.RowIndex].Cells[0].Value.ToString();
                string 관리번호 = lbl관리번호.Text;
                int i = 0;
                string 제품번호 = null;
                while (i < 11)
                {
                    if (grid작업지시목록.Rows[grid작업지시목록.CurrentCell.RowIndex].Cells[0].Value.ToString() != null
                        && grid작업지시목록.Rows[grid작업지시목록.CurrentCell.RowIndex].Cells[i + 1].Value.ToString() != null)
                    {
                        제품번호 = grid작업지시목록.Rows[grid작업지시목록.CurrentCell.RowIndex].Cells[i + 1].Value.ToString();
                        break;
                    }

                    i = i + 5;
                }

                UserControlList.workStatus.lbl품목번호.Text = 품번;
                UserControlList.workStatus.lbl관리번호.Text = 관리번호;

                using (ERPEntities entity = new ERPEntities())
                {
                    var 품목정보list = entity.품목정보.Where(x => x.품목번호 == 품번).ToList();
                    var 투입현황list = entity.MES투입현황.Where(x => x.관리번호 == 관리번호).ToList();
                    var 제품list = entity.제품.Where(x => x.제품번호 == 제품번호).ToList();

                    UserControlList.workStatus.lbl지시수량.Text = 투입현황list[0].투입수량.ToString();
                    UserControlList.workStatus.lbl규격.Text = 품목정보list[0].외경.ToString();
                    UserControlList.workStatus.lbl작업시작시간.Text = DateTime.Now.ToString();

                    if (제품list.Count != 0)
                        UserControlList.workStatus.lbl품명.Text = 제품list[0].제품명.ToString();

                    UserControlList.workStatus.투입공정현황 = 투입현황list[0].공정.ToString();


                }

                if (UcWorkStart != null)
                    UcWorkStart(sender, e);

                WorkStart = true;
                UserControlList.workStatus.공정상태();
                UserControlList.workStatus.grid저장_호출();

            }

            else
            {
                MessageBox.Show("작업이 진행중입니다.");
                UcWorkStart("진행", e);
                WorkStart = true;
            }
        }

        private void WorkSelect_Load(object sender, EventArgs e)
        {

            UserControlList.workSelect.라인별작업지시("전체");
        }

        private void Grid작업지시목록_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            int yPoint = grid작업지시목록.CurrentCell.ColumnIndex;
            int xPoint = grid작업지시목록.CurrentCell.RowIndex;


            if (yPoint == 0)
            {
                lbl관리번호.Text = "";
                lbl투입일자.Text = "";
            }

            if (yPoint >= 1 && yPoint < 7)
            {
                if (grid작업지시목록.Rows[xPoint].Cells[3].Value == null)
                {
                    lbl관리번호.Text = "";
                    lbl투입일자.Text = "";
                    return;
                }
                lbl관리번호.Text = grid작업지시목록.Rows[xPoint].Cells[3].Value.ToString().Trim();
                lbl투입일자.Text = grid작업지시목록.Rows[xPoint].Cells[6].Value.ToString().Substring(3, 5);
            }

            if (yPoint >= 7 && yPoint < 10)
            {
                if (grid작업지시목록.Rows[xPoint].Cells[7].Value == null)
                {
                    lbl관리번호.Text = "";
                    lbl투입일자.Text = "";
                    return;
                }

                else
                {
                    lbl관리번호.Text = grid작업지시목록.Rows[xPoint].Cells[7].Value.ToString().Trim();
                    lbl투입일자.Text = grid작업지시목록.Rows[xPoint].Cells[10].Value.ToString().Substring(3, 5);
                }

            }

        }

        private void BtnGridPageUp_Click(object sender, EventArgs e)
        {
            int selectCells = 0;
            if (현재페이지 > 1)
                현재페이지--;

            if (현재페이지 == 1)
                selectCells = 0;
            else
                selectCells = ((현재페이지 - 1) * PageCnt) + (PageCnt - 1);

            grid작업지시목록.CurrentCell = grid작업지시목록.Rows[selectCells].Cells[0];
            lbl현재페이지.Text = 현재페이지.ToString();

        }

        private void BtngridListDown_Click(object sender, EventArgs e)
        {
            int selectCells;

            if (현재페이지 < TotPageCnt)
                현재페이지++;

            if (현재페이지 == TotPageCnt)
                selectCells = grid작업지시목록.Rows.Count - 1;

            else
                selectCells = ((현재페이지 - 1) * PageCnt) + (PageCnt - 1);


            grid작업지시목록.CurrentCell = grid작업지시목록.Rows[selectCells].Cells[0];
            lbl현재페이지.Text = 현재페이지.ToString();

        }


        public void 라인별작업지시(string Line)
        {

            List<공정시작수량Data> 공정시작수량list = new List<공정시작수량Data>();
            공정시작수량list = DB.수주.Get공정시작수량();
            var 필요한품번 = 공정시작수량list.Select(G => G.제품번호).ToList();

            grid작업지시목록.Rows.Clear();
            ButtonChanged(Line, null);


            int x = grid작업지시목록.Size.Height;
            int y = grid작업지시목록.ColumnHeadersHeight;

            x = x - y;
            x = x / PageCnt;

            grid작업지시목록.RowTemplate.Height = x;
            grid작업지시목록.DefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);

            #region Visible
            //grid작업지시목록.Columns[2].Visible = false;
            //grid작업지시목록.Columns[6].Visible = false;
            //grid작업지시목록.Columns[11].Visible = false;
            #endregion

            int cnt = 0;

            List<MES투입현황> TOTlist = DB.MES투입현황.Get투입현황();

            Dictionary<string, int> list = new Dictionary<string, int>();
            list = DB.MES투입현황.Get투입현황_투입개수();
            List<품목정보> 품목정보 = DB.품목정보.GetAll();
            Dictionary<string, int> BlockList = new Dictionary<string, int>();

            if (Line != "전체")
            {
                for (int i = 0; i < 품목정보.Count(); i++)
                {
                    if ((품목정보[i].전공정.ToString() == Line) ||
                          (품목정보[i].최종공정.ToString() == Line) ||
                          (품목정보[i].후공정.ToString() == Line))
                    {
                        if (list.ContainsKey(품목정보[i].품목번호))
                        {
                            int value = list[품목정보[i].품목번호];
                            BlockList.Add(품목정보[i].품목번호, value);
                        }
                    }
                }
            }

            else
                BlockList = list;

            int itemCnt = 0;
            int ColumnIndex = 0;
            List<MES현장실적현황> 작업현황List = new List<MES현장실적현황>();
            작업현황List = DB.MES현장실적현황.GetALL();

            #region 배경색
            List<Color> 배경색list = new List<Color>();
            배경색list.Add(Color.FromArgb(17, 138, 140));
            배경색list.Add(Color.FromArgb(239, 71, 111));
            배경색list.Add(Color.FromArgb(255, 209, 102));
            배경색list.Add(Color.FromArgb(6, 214, 160));
            배경색list.Add(Color.FromArgb(182, 224, 128));
            배경색list.Add(Color.FromArgb(163, 211, 213));
            배경색list.Add(Color.FromArgb(232, 235, 183));
            #endregion

            List<MES투입현황> 투입현황list = DB.MES투입현황.Get투입현황();
            var BlockList1 = BlockList.Where(g => 필요한품번.Contains(g.Key)).ToList();
            foreach (var 블럭item in BlockList1)
            {
                ColumnIndex = 0;

                grid작업지시목록.Rows.Add();

                var Info = 공정시작수량list.Where(z => z.제품번호.Trim() == 블럭item.Key.Trim()).ToList();
                grid작업지시목록.Rows[itemCnt].Cells[ColumnIndex++].Value = 블럭item.Key.ToString();
                grid작업지시목록.Rows[itemCnt].Cells[ColumnIndex++].Value = Info[0].순위;

                if (Info[0].순위 == 1)
                {
                    grid작업지시목록.Rows[itemCnt].Cells[0].Style.ForeColor = 배경색list[0];
                    grid작업지시목록.Rows[itemCnt].Cells[1].Style.ForeColor = 배경색list[0];
                }

                grid작업지시목록.Rows[itemCnt].Cells[ColumnIndex++].Value = Info[0]._1차필요수량 + Info[0]._2차필요수량;
                List<MES투입현황> MaterialList = TOTlist.Where(z => z.제품번호.Trim() == 블럭item.Key.Trim()).ToList();

                cnt = 0;

                foreach (var items in MaterialList)
                {
                    if (Info[0]._2차공정시작 == true)
                    {
                        grid작업지시목록.Rows[itemCnt].Cells[ColumnIndex++].Value = items.관리번호.ToString();
                        grid작업지시목록.Rows[itemCnt].Cells[7].Style.BackColor = Color.FromArgb(255, 255, 0);
                        grid작업지시목록.Rows[itemCnt].Cells[7].Style.ForeColor = Color.FromArgb(0, 0, 0);
                        grid작업지시목록.Rows[itemCnt].Cells[ColumnIndex++].Value = items.공정.ToString();
                        grid작업지시목록.Rows[itemCnt].Cells[8].Style.BackColor = Color.FromArgb(255, 255, 0);
                        grid작업지시목록.Rows[itemCnt].Cells[8].Style.ForeColor = Color.FromArgb(0, 0, 0);
                        grid작업지시목록.Rows[itemCnt].Cells[ColumnIndex++].Value = items.투입수량.ToString();
                        grid작업지시목록.Rows[itemCnt].Cells[9].Style.BackColor = Color.FromArgb(255, 255, 0);
                        grid작업지시목록.Rows[itemCnt].Cells[9].Style.ForeColor = Color.FromArgb(0, 0, 0);

                        grid작업지시목록.Rows[itemCnt].Cells[ColumnIndex++].Value = items.투입일.ToString().Substring(2, 8).ToString();
                        grid작업지시목록.Rows[itemCnt].Cells[10].Style.BackColor = Color.FromArgb(255, 255, 0);
                        grid작업지시목록.Rows[itemCnt].Cells[10].Style.ForeColor = Color.FromArgb(0, 0, 0);
                    }
                    else
                    {
                        grid작업지시목록.Rows[itemCnt].Cells[ColumnIndex++].Value = items.관리번호.ToString();
                        grid작업지시목록.Rows[itemCnt].Cells[ColumnIndex++].Value = items.공정.ToString();
                        grid작업지시목록.Rows[itemCnt].Cells[ColumnIndex++].Value = items.투입수량.ToString();
                        grid작업지시목록.Rows[itemCnt].Cells[ColumnIndex++].Value = items.투입일.ToString().Substring(2, 8).ToString();
                    }
                    //셀위치 = cnt * 5 + 2;
                    //foreach (var 배경색 in 배경색list)
                    //{
                    //    if (items.작업순위 == 순위cnt)
                    //    {
                    //        grid작업지시목록.Rows[itemCnt].Cells[셀위치].Style.ForeColor = 배경색;
                    //        셀위치++;
                    //    }
                    //    순위cnt++;
                    //}


                    cnt++;
                    if (cnt > 1) break;
                }

                //if ((int)grid작업지시목록.Rows[itemCnt].Cells[5].Value > 6)
                //{
                //    grid작업지시목록.Rows.Remove(grid작업지시목록.Rows[itemCnt]);
                //}

                itemCnt++;

            }

            grid작업지시목록.Sort(grid작업지시목록.Columns[1], ListSortDirection.Ascending);

            MaxRow = grid작업지시목록.Rows.Count;

            TotPageCnt = MaxRow / PageCnt;

            int ModA = MaxRow % PageCnt;

            for (int i = 0; i < ModA; i++)
            {
                grid작업지시목록.Rows.Add();
            }

            if ((MaxRow % PageCnt) > 0)
            {
                TotPageCnt = (MaxRow / PageCnt) + 1;
            }
            else
            {
                TotPageCnt = MaxRow / PageCnt;
            }

            lbl현재페이지.Text = 현재페이지.ToString();
            lbl전체페이지.Text = TotPageCnt.ToString();


        }

        private void Grid작업지시목록_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                BtngridListDown_Click(null, null);
            }
            if (e.KeyCode == Keys.Up)
            {
                e.Handled = true;
                BtnGridPageUp_Click(null, null);
            }
        }
    }
}

