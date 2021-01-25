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
    public partial class WorkStatus : UserControl
    {
        private int 실적현황행번호 = 0;
        private int 불량현황행번호 = 0;
        private int 실적번호순서 = 0;
        List<MES현장실적현황> 현장실적현황list = new List<MES현장실적현황>();
        List<MES불량실적현황> 불량실적현황list = new List<MES불량실적현황>();

        #region 공정별수량c 초기화
        MES공정별수량 공정별수량c = new MES공정별수량()
        {
            제품번호 = null,
            관리번호 = null,
            절단생산수량 = 0,
            절단불량수량 = 0,
            벤딩생산수량 = 0,
            벤딩불량수량 = 0,
            드릴생산수량 = 0,
            드릴불량수량 = 0,
            용접생산수량 = 0,
            용접불량수량 = 0,
            완료유무 = false
        }; 
        #endregion

        public string 투입공정현황 = null;
        bool 공정콤보박스만초기화 = false;

        bool 절단상태 = false;
        bool 벤딩상태 = false;
        bool 드릴상태 = false;
        bool 용접상태 = false;

        int 절단불량수량 = 0;
        int 벤딩불량수량 = 0;
        int 드릴불량수량 = 0;
        int 용접불량수량 = 0;

        public event EventHandler 작업종료;

        public WorkStatus()
        {
            InitializeComponent();
            UserControlList.workStatus = this;
        }

        // 실적등록 버튼이 눌러지면 한번 발생
        private void Btn실적등록_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("실적 등록 하시겠습니까?", "실적등록", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Btn실적등록ed();
            }

            else
            {
                return;
            }
        }

        // 실적등록 버튼이 눌러지면 나오는 확인창 Yes 누르면 발생
        private void Btn실적등록ed()
        {
            if (lbl절단잔량.Text.IsNullOrEmpty())
                lbl절단잔량.Text = "0";

            if (lbl벤딩잔량.Text.IsNullOrEmpty())
                lbl벤딩잔량.Text = "0";

            if (lbl드릴잔량.Text.IsNullOrEmpty())
                lbl드릴잔량.Text = "0";

            #region 실적등록 못하는 모든 경우를 메세지박스로 표시 후 리턴 , 여기에 지시수량,생산수량,불량수량값 있음
            if (UserControlList.workSelect.WorkStart == false)
            {
                MessageBox.Show("작업중이 아닙니다.");
                return;
            }

            if ((tbx생산수량.Text == null) || (tbx불량수량.Text == null))
            {
                MessageBox.Show("수량값을 입력해 주세요.");
                return;
            }

            if ((lbl현재공정.Text == null) || (cbb공정.SelectedItem == null))
            {
                MessageBox.Show("공정을 입력해 주세요.");
                return;
            }

            if (int.Parse(tbx생산수량.Text) <= 0)
            {
                MessageBox.Show("생산수량에는 0이하의 값을 입력할 수 없습니다.");
                return;
            }

            if (int.Parse(tbx불량수량.Text) < 0)
            {
                MessageBox.Show("불량수량에는 0미만의 값을 입력할 수 없습니다.");
                return;
            }

            int 지시수량 = int.Parse(lbl지시수량.Text);
            int 생산수량 = int.Parse(tbx생산수량.Text);
            int 불량수량 = int.Parse(tbx불량수량.Text);

            if (!int.TryParse(tbx생산수량.Text, out 생산수량))
            {
                MessageBox.Show("생산수량에 정수값을 입력해 주세요.");
                return;
            }

            if (!int.TryParse(tbx불량수량.Text, out 불량수량))
            {
                MessageBox.Show("불량수량에 정수값을 입력해 주세요.");
                return;
            }

            if (생산수량 > 지시수량 || 불량수량 > 생산수량)
            {
                MessageBox.Show("초과된 수량입니다");
                return;
            }


            #region 공정별 초과수량 메세지박스 출력과 리턴
            if (int.Parse(tbx생산수량.Text) > int.Parse(lbl절단잔량.Text) && lbl현재공정.Text == "절단현황")
            {
                MessageBox.Show("초과된 수량입니다");
                return;
            }

            else if (int.Parse(tbx생산수량.Text) > int.Parse(lbl벤딩잔량.Text) && lbl현재공정.Text == "벤딩현황")
            {
                MessageBox.Show("초과된 수량입니다");
                return;
            }

            else if (int.Parse(tbx생산수량.Text) > int.Parse(lbl드릴잔량.Text) && lbl현재공정.Text == "드릴현황")
            {
                MessageBox.Show("초과된 수량입니다");
                return;
            }

            else if (int.Parse(tbx생산수량.Text) > int.Parse(lbl용접잔량.Text) && lbl현재공정.Text == "용접현황")
            {
                MessageBox.Show("초과된 수량입니다");
                return;
            } 
            #endregion


            if (cbb공정.Text == null)
            {
                MessageBox.Show("공정을 선택하세요.");
                return;
            }
            #endregion

            int 실적현황ColumnIndex = 0;

            공정별수량c.실적시간 = DateTime.Now;
            if ((string)cbb공정.SelectedItem == "절단")
            {
                공정별수량c.절단생산수량 += (생산수량 - 불량수량);
            }

            else if ((string)cbb공정.SelectedItem == "벤딩")
                공정별수량c.벤딩생산수량 += (생산수량 - 불량수량);

            else if ((string)cbb공정.SelectedItem == "드릴")
                공정별수량c.드릴생산수량 += (생산수량 - 불량수량);

            else if ((string)cbb공정.SelectedItem == "용접")
                공정별수량c.용접생산수량 += (생산수량 - 불량수량);

            #region grid실적현황 값 넣기
            grid실적현황.Rows.Add();
            grid실적현황.Rows[실적현황행번호].Cells[실적현황ColumnIndex++].Value = 생산수량 - 불량수량;
            grid실적현황.Rows[실적현황행번호].Cells[실적현황ColumnIndex++].Value = 불량수량;
            grid실적현황.Rows[실적현황행번호].Cells[실적현황ColumnIndex++].Value = (string)cbb공정.SelectedItem;
            grid실적현황.Rows[실적현황행번호].Cells[실적현황ColumnIndex++].Value = loginMember.EmployeeName;
            grid실적현황.Rows[실적현황행번호].Cells[실적현황ColumnIndex++].Value = DateTime.Now; 
            #endregion

            MES현장실적현황 현장실적현황class = new MES현장실적현황();

            현장실적현황class.실적번호 = $"{lbl관리번호.Text.Trim()}{실적번호순서}";
            현장실적현황class.관리번호 = lbl관리번호.Text.Trim();
            현장실적현황class.제품번호 = lbl품목번호.Text.Trim();
            현장실적현황class.실적수량 = 생산수량 - 불량수량;
            현장실적현황class.불량수량 = 불량수량;
            현장실적현황class.공정명 = (string)cbb공정.SelectedItem;
            현장실적현황class.작업자 = loginMember.EmployeeName;
            현장실적현황class.작업시작 = DateTime.Parse(lbl작업시작시간.Text);
            현장실적현황class.실적등록시간 = DateTime.Now;

            if (cbx공정완료.Checked == true)
                현장실적현황class.완료유무 = true;
            else
                현장실적현황class.완료유무 = false;

            현장실적현황list.Add(현장실적현황class);

            // 공정별수량 업데이트
            DB.MES공정별수량.Update(공정별수량c);
            DB.MES현장실적현황.Insert(현장실적현황class);

            int 불량현황ColumnIndex = 0;

            #region 불량수량 조건은 따로 구현하기
            if (불량수량 != 0)
            {
                if ((string)cbb공정.SelectedItem == "절단")
                {
                    절단불량수량 += 불량수량;
                    공정별수량c.절단불량수량 = 절단불량수량;
                }

                else if ((string)cbb공정.SelectedItem == "벤딩")
                {
                    벤딩불량수량 += 불량수량;
                    공정별수량c.벤딩불량수량 = 벤딩불량수량;
                }

                else if ((string)cbb공정.SelectedItem == "드릴")
                {
                    드릴불량수량 += 불량수량;
                    공정별수량c.드릴불량수량 = 드릴불량수량;
                }

                else if ((string)cbb공정.SelectedItem == "용접")
                {
                    용접불량수량 += 불량수량;
                    공정별수량c.용접불량수량 = 용접불량수량;
                }

                MES불량실적현황 불량실적현황class = new MES불량실적현황();
                불량실적현황class.실적번호 = $"{lbl관리번호.Text.Trim()}{실적번호순서}";
                불량실적현황class.관리번호 = lbl관리번호.Text.Trim();
                불량실적현황class.제품번호 = lbl품목번호.Text.Trim();
                불량실적현황class.불량수량 = 불량수량;
                불량실적현황class.등록시간 = DateTime.Now;
                불량실적현황class.비고 = "";

                #region 불량현황 값넣기
                grid불량현황.Rows.Add();
                grid불량현황.Rows[불량현황행번호].Cells[불량현황ColumnIndex++].Value = 불량수량;
                grid불량현황.Rows[불량현황행번호].Cells[불량현황ColumnIndex++].Value = DateTime.Now;
                grid불량현황.Rows[불량현황행번호].Cells[불량현황ColumnIndex++].Value = null;
                #endregion

                DB.MES불량실적현황.Insert(불량실적현황class);
                불량실적현황list.Add(불량실적현황class);
                불량현황행번호++;
            }
            #endregion


            
            실적현황행번호++;
            실적번호순서++;

            공정상태();

            #region 공정별 작업이 끝날경우 , 잔량이 0일경우
            if (int.Parse(lbl절단잔량.Text) <= 0 && 투입공정현황 == "절단")
            {
                lbl절단잔량.Text = "0";
                투입공정현황 = "벤딩";
                절단상태 = false;
            }

            else if (int.Parse(lbl벤딩잔량.Text) <= 0 && 투입공정현황 == "벤딩")
            {
                lbl벤딩잔량.Text = "0";
                투입공정현황 = "드릴";
                벤딩상태 = false;
            }

            else if (int.Parse(lbl드릴잔량.Text) <= 0 && 투입공정현황 == "드릴")
            {
                lbl드릴잔량.Text = "0";
                투입공정현황 = "용접";
                드릴상태 = false;
            }

            else if (int.Parse(lbl용접잔량.Text) <= 0 && 투입공정현황 == "용접")
            {
                MessageBox.Show("용접까지 전부 완료하셨습니다. 작업을 종료합니다.");
                작업종료ed();
                작업종료(null, null);
                cbb공정.Items.Clear();

                UserControlList.workSelect.WorkStart = false;
            }
            #endregion

            if(cbx공정완료.Checked == true)
            {
                작업종료ed();
                작업종료(null, null);
                cbb공정.Items.Clear();

                MessageBox.Show("작업이 종료되었습니다.");
                UserControlList.workSelect.WorkStart = false;
            }

            공정콤보박스만초기화 = true;
            공정상태();
            공정콤보박스만초기화 = false;

            // 공정별수량 업데이트


            tbx불량수량.Text = null;
            tbx생산수량.Text = null;

        }

        private void Btn작업종료_Click(object sender, EventArgs e)
        {
            실적현황행번호 = 0;
            불량현황행번호 = 0;
            실적번호순서 = 0;

            if (UserControlList.workSelect.WorkStart == false)
            {
                MessageBox.Show("진행중인 작업이 없습니다");
                return;
            }

            else
            {
                if (MessageBox.Show("작업을 종료하시겠습니까?", "작업종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    작업종료ed();
                    작업종료(sender, e);
                    cbb공정.Items.Clear();

                    MessageBox.Show("작업이 종료되었습니다.");
                    UserControlList.workSelect.WorkStart = false;
                }

                else
                {
                    return;
                }
            }
        }

        private void 작업종료ed()
        {
            List<MES투입현황> MES투입현황list = DB.MES투입현황.Get투입현황_Rows(lbl관리번호.Text.Trim());

            MES투입현황list[0].공정 = 투입공정현황.ToString();
            MES투입현황list[0].투입수량 = int.Parse(lbl지시수량.Text);

            DB.MES투입현황.Update(MES투입현황list[0]);

            if ((MES투입현황list[0].투입수량 == 0) || (cbx공정완료.Checked == true))
            {
                MessageBox.Show("공정이 완료되었습니다.");
                for (int i = 0; i < UserControlList.workSelect.grid작업지시목록.Rows.Count - 1; i++)
                    if (UserControlList.workSelect.grid작업지시목록.Rows[i].Cells[3].Value.ToString() ==
                        lbl관리번호.Text.Trim().ToString())
                    {
                        UserControlList.workSelect.grid작업지시목록.Rows[i].Cells[4].Style.BackColor = Color.FromArgb(225, 0, 0);
                        UserControlList.workSelect.grid작업지시목록.Rows[i].Cells[5].Style.BackColor = Color.FromArgb(225, 0, 0);
                        UserControlList.workSelect.grid작업지시목록.Rows[i].Cells[6].Style.BackColor = Color.FromArgb(225, 0, 0);
                        UserControlList.workSelect.grid작업지시목록.Rows[i].Cells[4].Style.ForeColor = Color.FromArgb(0, 0, 0);
                        UserControlList.workSelect.grid작업지시목록.Rows[i].Cells[5].Style.ForeColor = Color.FromArgb(0, 0, 0);
                        UserControlList.workSelect.grid작업지시목록.Rows[i].Cells[6].Style.ForeColor = Color.FromArgb(0, 0, 0);
                    }
                            

            }

            #region label값, 그리드, 리스트, 클래스 초기화

            grid불량현황.Rows.Clear();
            grid실적현황.Rows.Clear();
            cbx공정완료.CheckState = CheckState.Unchecked;
            lbl관리번호.Text = null;
            lbl규격.Text = null;
            lbl작업시작시간.Text = null;
            lbl지시수량.Text = null;
            lbl품목번호.Text = null;
            tbx불량수량.Text = null;
            tbx생산수량.Text = null;
            투입공정현황 = null;
            lbl절단생산수량.Text = null;
            lbl벤딩생산수량.Text = null;
            lbl드릴생산수량.Text = null;
            lbl용접생산수량.Text = null;
            lbl절단잔량.Text = null;
            lbl벤딩잔량.Text = null;
            lbl드릴잔량.Text = null;
            lbl용접잔량.Text = null;
            lbl현재공정.Text = null;

            절단상태 = false;
            벤딩상태 = false;
            드릴상태 = false;
            용접상태 = false;

            공정콤보박스만초기화 = false;

            절단불량수량 = 0;
            벤딩불량수량 = 0;
            드릴불량수량 = 0;
            용접불량수량 = 0;

            실적현황행번호 = 0;
            불량현황행번호 = 0;
            실적번호순서 = 0;

            공정별수량c.제품번호 = null;
            공정별수량c.관리번호 = null;
            공정별수량c.절단생산수량 = 0;
            공정별수량c.절단불량수량 = 0;
            공정별수량c.벤딩생산수량 = 0;
            공정별수량c.벤딩불량수량 = 0;
            공정별수량c.드릴생산수량 = 0;
            공정별수량c.드릴불량수량 = 0;
            공정별수량c.용접생산수량 = 0;
            공정별수량c.용접불량수량 = 0;

            공정별수량c.완료유무 = false;

            현장실적현황list = null;
            불량실적현황list = null;

            현장실적현황list = new List<MES현장실적현황>();
            불량실적현황list = new List<MES불량실적현황>();
            #endregion


        }

        // 실적번호순서 초기화, 실적현황,불량현황 전부 로드
        public void grid저장_호출()
        {
            실적번호순서 = DB.MES현장실적현황.GetALL().Where(x => x.관리번호 == lbl관리번호.Text.Trim().ToString()).Count();

            List<MES현장실적현황> 현장실적현황list =
                 DB.MES현장실적현황.GetALL().Where(x => x.관리번호 == lbl관리번호.Text.Trim().ToString()).ToList();

            int RowIndex = 0;
            int columnIndex = 0;
            foreach (var item in 현장실적현황list)
            {
                columnIndex = 0;
                grid실적현황.Rows.Add();
                grid실적현황.Rows[RowIndex].Cells[columnIndex++].Value = item.실적수량;
                grid실적현황.Rows[RowIndex].Cells[columnIndex++].Value = item.불량수량;
                grid실적현황.Rows[RowIndex].Cells[columnIndex++].Value = item.공정명;
                grid실적현황.Rows[RowIndex].Cells[columnIndex++].Value = item.작업자;
                grid실적현황.Rows[RowIndex].Cells[columnIndex++].Value = item.실적등록시간;
            }

            List<MES불량실적현황> 불량실적현황list =
                DB.MES불량실적현황.GetAll().Where(x => x.관리번호 == lbl관리번호.Text.Trim().ToString()).ToList();

            RowIndex = 0;
            foreach (var item in 불량실적현황list)
            {
                columnIndex = 0;
                grid불량현황.Rows.Add();
                grid불량현황.Rows[RowIndex].Cells[columnIndex++].Value = item.불량수량;
                grid불량현황.Rows[RowIndex].Cells[columnIndex++].Value = item.등록시간;
                grid불량현황.Rows[RowIndex].Cells[columnIndex++].Value = item.비고;
            }
        }
        private void Btn재발행_Click(object sender, EventArgs e)
        {

        }

        private void Cbx공정완료_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void WorkStatus_Load(object sender, EventArgs e)
        {

        }

        // 공정상태는 작업시작 누르면 한번 발생됨
        public void 공정상태()
        {

            cbb공정.Items.Clear();

            #region 공정별Switch 와 cbb공정생성
            if (투입공정현황 == "절단")
            {
                절단상태 = true;
                벤딩상태 = true;
                드릴상태 = true;
                용접상태 = true;

                cbb공정.Items.Add("절단");
                cbb공정.Items.Add("벤딩");
                cbb공정.Items.Add("드릴");
                cbb공정.Items.Add("용접");

            }

            else if (투입공정현황 == "벤딩")
            {
                절단상태 = false;
                벤딩상태 = true;
                드릴상태 = true;
                용접상태 = true;

                cbb공정.Items.Add("벤딩");
                cbb공정.Items.Add("드릴");
                cbb공정.Items.Add("용접");
            }

            else if (투입공정현황 == "드릴")
            {
                절단상태 = false;
                벤딩상태 = false;
                드릴상태 = true;
                용접상태 = true;

                cbb공정.Items.Add("드릴");
                cbb공정.Items.Add("용접");
            }

            else if (투입공정현황 == "용접")
            {
                절단상태 = false;
                벤딩상태 = false;
                드릴상태 = false;
                용접상태 = true;

                cbb공정.Items.Add("용접");
            }

            else
            {
                return;
            }

            #endregion

            if(공정콤보박스만초기화 == true)
            {
                return;
            }

            #region Switch에 따른 공정별불가 조정

            if (절단상태 == false)
            {
                if (cbb공정.Text == "절단")
                {
                    MessageBox.Show("절단은 불가능 합니다.");
                    return;
                }
            }

            else if (벤딩상태 == false)
            {
                if (cbb공정.Text == "벤딩")
                {
                    MessageBox.Show("벤딩은 불가능 합니다");
                    return;
                }
            }

            else if (드릴상태 == false)
            {
                if (cbb공정.Text == "드릴")
                {
                    MessageBox.Show("드릴은 불가능 합니다");
                    return;
                }
            }

            #endregion


            공정별수량c.관리번호 = lbl관리번호.Text;
            공정별수량c.제품번호 = lbl품목번호.Text;

            #region 공정별수량DB에 관리번호가 없으면 새로 Insert, 있으면 그대로 로드해서 사용

            if (DB.MES공정별수량.Get공정별수량(lbl관리번호.Text.Trim().ToString()).관리번호.IsNullOrEmpty())
            {
                DB.MES공정별수량.Insert(공정별수량c);
            }

            else
            {
                공정별수량c = DB.MES공정별수량.Get공정별수량(lbl관리번호.Text);
            }
            #endregion

            #region 전역변수에 각 공정별 불량수량을 먼저 담아놓기
            절단불량수량 = 공정별수량c.절단불량수량;
            벤딩불량수량 = 공정별수량c.벤딩불량수량;
            드릴불량수량 = 공정별수량c.드릴불량수량;
            용접불량수량 = 공정별수량c.용접불량수량;
            #endregion


            #region 생산수량label, 잔량label 값넣기
            if (!DB.MES공정별수량.GetAll().Where(a => a.관리번호 == lbl관리번호.Text.Trim().ToString()).Any())
            {
                lbl절단생산수량.Text = "0";
                lbl벤딩생산수량.Text = "0";
                lbl드릴생산수량.Text = "0";
                lbl용접생산수량.Text = "0";

                if (투입공정현황 == "절단")
                {
                    lbl절단잔량.Text = lbl지시수량.Text;
                    lbl벤딩잔량.Text = "0";
                    lbl드릴잔량.Text = "0";
                    lbl용접잔량.Text = "0";
                }

                else if (투입공정현황 == "벤딩")
                {
                    lbl절단잔량.Text = "0";
                    lbl벤딩잔량.Text = lbl지시수량.Text;
                    lbl드릴잔량.Text = "0";
                    lbl용접잔량.Text = "0";
                }

                else if (투입공정현황 == "드릴")
                {
                    lbl절단잔량.Text = "0";
                    lbl벤딩잔량.Text = "0";
                    lbl드릴잔량.Text = lbl지시수량.Text;
                    lbl용접잔량.Text = "0";
                }

                else if (투입공정현황 == "용접")
                {
                    lbl절단잔량.Text = "0";
                    lbl벤딩잔량.Text = "0";
                    lbl드릴잔량.Text = "0";
                    lbl용접잔량.Text = lbl지시수량.Text;
                }
            }

            else
            {
                lbl절단생산수량.Text = 공정별수량c.절단생산수량.ToString();
                lbl벤딩생산수량.Text = 공정별수량c.벤딩생산수량.ToString();
                lbl드릴생산수량.Text = 공정별수량c.드릴생산수량.ToString();
                lbl용접생산수량.Text = 공정별수량c.용접생산수량.ToString();

                if (절단상태 == true)
                    lbl절단잔량.Text = (int.Parse(lbl지시수량.Text) - int.Parse(lbl절단생산수량.Text)).ToString();

                if (벤딩상태 == true)
                    lbl벤딩잔량.Text = (int.Parse(lbl절단생산수량.Text) - int.Parse(lbl벤딩생산수량.Text)).ToString();

                if (드릴상태 == true)
                    lbl드릴잔량.Text = (int.Parse(lbl벤딩생산수량.Text) - int.Parse(lbl드릴생산수량.Text)).ToString();

                if (용접상태 == true)
                    lbl용접잔량.Text = (int.Parse(lbl드릴생산수량.Text) - int.Parse(lbl용접생산수량.Text)).ToString();
            }
            #endregion

            if (lbl절단잔량.Text.IsNullOrEmpty())
                lbl절단잔량.Text = "0";

            if (lbl벤딩잔량.Text.IsNullOrEmpty())
                lbl벤딩잔량.Text = "0";

            if (lbl드릴잔량.Text.IsNullOrEmpty())
                lbl드릴잔량.Text = "0";
        }


        private void Cbb공정_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region cbb공정 선택시에 이벤트 발생
            if ((string)cbb공정.SelectedItem == "절단")
            {
                lbl현재공정.Text = "절단현황";
                tbx생산수량.Text = $"생산가능수량 : {lbl절단잔량.Text}";
                tbx불량수량.Text = $"현재불량수량 : {절단불량수량}";
            }

            else if ((string)cbb공정.SelectedItem == "벤딩")
            {
                lbl현재공정.Text = "벤딩현황";
                tbx생산수량.Text = $"생산가능수량 : {lbl벤딩잔량.Text}";
                tbx불량수량.Text = $"현재불량수량 : {벤딩불량수량}";
            }

            else if ((string)cbb공정.SelectedItem == "드릴")
            {
                lbl현재공정.Text = "드릴현황";
                tbx생산수량.Text = $"생산가능수량 : {lbl드릴잔량.Text}";
                tbx불량수량.Text = $"현재불량수량 : {드릴불량수량}";
            }

            else if ((string)cbb공정.SelectedItem == "용접")
            {
                lbl현재공정.Text = "용접현황";
                tbx생산수량.Text = $"생산가능수량 : {lbl용접잔량.Text}";
                tbx불량수량.Text = $"현재불량수량 : {용접불량수량}";
            } 
            #endregion
        }

        private bool 절단공정비교(int 앞공정수량, int 뒷공정수량)
        {
            int 비교값 = 앞공정수량 - 뒷공정수량;
            if (비교값 >= 0)
                return true;
            else
                return false;
        }

        private void Tbx생산수량_Click(object sender, EventArgs e)
        {
            tbx생산수량.Text = tbx생산수량.Text.Replace("생산가능수량 : ", "");
        }

        private void Tbx불량수량_Click(object sender, EventArgs e)
        {
            tbx불량수량.Text = tbx불량수량.Text.Replace("현재불량수량 : ", "");
        }
    }
}
