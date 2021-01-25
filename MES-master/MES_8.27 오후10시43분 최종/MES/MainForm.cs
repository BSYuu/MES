using MetroFramework.Components;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace MES
{
    public partial class MainForm : MetroForm
    {
        Dictionary<Button,UserControl> usercontrolList = new Dictionary<Button, UserControl>();
        private int Timer = 0;

        public MainForm()
        {
            InitializeComponent();

            dic_UserControl();

            if (!pnlMiddle.Controls.ContainsKey("WorkSelect"))
            {
                pnlMiddle.Controls.Add(UserControlList.workSelect);
                UserControlList.workSelect.Dock = DockStyle.Fill;
            }
            pnlMiddle.Controls["WorkSelect"].BringToFront();

            UserControlList.workSelect.UcWorkStart += new System.EventHandler(this.UcWorkStart_Click);
            UserControlList.workStatus.작업종료 += new System.EventHandler(this.UcWorkFinish_Click);
            UserControlList.workSelect.GridUpdate += new System.EventHandler(this.Btn새로고침_Click);
            UserControlList.workSelect.ButtonChanged += new System.EventHandler(this.라인Changed);
        }

        LoginForm loginForm;
        public void RecieveLoginForm(LoginForm loginForm)
        {
            this.loginForm = loginForm;
        }

        private void UcWorkStart_Click(object sender, EventArgs e)
        {

            if (!pnlMiddle.Controls.ContainsKey("WorkStatus"))
            {    
                pnlMiddle.Controls.Add(UserControlList.workStatus);
                UserControlList.workStatus.Dock = DockStyle.Fill;
            }

            pnlMiddle.Controls["WorkStatus"].BringToFront();

        }

        private void UcWorkFinish_Click(object sender, EventArgs e)
        {
            pnlMiddle.Controls["WorkSelect"].BringToFront();
            Btn새로고침_Click(sender, e);
        }

        public void TopButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            foreach (var item in usercontrolList)
            {
                if (button == item.Key)
                {
                    if (!pnlMiddle.Controls.ContainsKey(item.Value.Name))
                    {
                        pnlMiddle.Controls.Add(item.Value);
                        item.Value.Dock = DockStyle.Fill;
                    }
                    pnlMiddle.Controls[item.Value.Name].BringToFront();
                }
            }
        }

        private void LblPlus_Click(object sender, EventArgs e)
        {

            MakeButtonForm makeButtonForm = new MakeButtonForm();
            makeButtonForm.확인 += new System.EventHandler(this.SetBottombtnName);
            makeButtonForm.label1.Text = "분류추가";
            makeButtonForm.ShowDialog();
        }

        public void SetBottombtnName(object sender, EventArgs e)
        {
            string btnName = (string)sender;

            if (e != null)
            {
                UcBottomButton bottomButton = new UcBottomButton();
                bottomButton.Name = btnName;
                bottomButton.btn1.Text = btnName;
                bottomButton.WorkSelected(UserControlList.workSelect);
                if (fpnlBottom.Controls.ContainsKey(btnName))
                {
                    MessageBox.Show("이미 추가된 버튼 입니다.");
                    return;
                }

                fpnlBottom.Controls.Add(bottomButton);

            }
            else fpnlBottom.Controls.RemoveByKey(btnName);

        }

        private void LblMinus_Click(object sender, EventArgs e)
        {
            MakeButtonForm makeButtonForm = new MakeButtonForm();
            makeButtonForm.확인 += new System.EventHandler(this.SetBottombtnName);
            makeButtonForm.label1.Text = "분류삭제";
            makeButtonForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UcBottomButton bottomButton = new UcBottomButton();
            bottomButton.Name = "전체";
            bottomButton.btn1.Text = "전체";
            bottomButton.WorkSelected(UserControlList.workSelect);
            fpnlBottom.Controls.Add(bottomButton);
            timer1.Start();
            timer1.Interval = 1000;
            lbl작업자.Text = loginMember.EmployeeName.ToString();



        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbl타이머.Text = DateTime.Now.ToLongTimeString();
            Timer++;
        }

        #region dic_UserControl

        void dic_UserControl()
        {
            usercontrolList.Add(btn작업지시선택, UserControlList.workSelect);
            usercontrolList.Add(btn작업현황, UserControlList.workStatus);
            usercontrolList.Add(btn생산실적조회, UserControlList.productPerformance);
            usercontrolList.Add(btn상세실적조회, UserControlList.detailperform);
            usercontrolList.Add(btn자주검사조회, UserControlList.selfInspection);
            usercontrolList.Add(btn불량실적조회, UserControlList.poolPerform);
            usercontrolList.Add(btn계획대실적, UserControlList.planPerform);
            usercontrolList.Add(btn공지사항, UserControlList.notice);
        }
        #endregion

        public void LblClose_Click(object sender, EventArgs e)
        {
            if (UserControlList.workSelect.WorkStart == true)
            {
                MessageBox.Show("작업중에는 종료하실 수 없습니다.");
                return;
            }

            else
            {
                if (MessageBox.Show("정말로 종료하겠습니까?", "프로그램종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Close();
                }

                else
                {
                    return;
                }
            }
        }

        List<string> 라인유형s = new List<string>(new string[6] { "소형라인", "중형라인", "대형라인", "인라인", "수작업", "전체" });
        

        private void Btn새로고침_Click(object sender, EventArgs e)
        {
            foreach (var 라인유형 in 라인유형s)
                if (lbl라인.Text == $"{라인유형}")
                    for (int i = 0; i < 6; i++)
                        if (fpnlBottom.Controls[i].Controls[0].Text == $"{라인유형}")
                        {
                            UserControlList.workSelect.라인별작업지시($"{라인유형}");
                            break;
                        }
        }

        private void 라인Changed(object sender, EventArgs e)
        {
            lbl라인.Text = (string)sender;
        }

        private void LblMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private Point mousePoint;

        // 마우스 클릭시 먼저 선언된 mousePoint변수에 현재 마우스 위치값이 들어갑니다.

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X), this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Close();
        }
    }
}
