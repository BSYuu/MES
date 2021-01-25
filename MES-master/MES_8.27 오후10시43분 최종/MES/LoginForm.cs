using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES
{
    public partial class LoginForm : Form
    {
        private MainForm mainForm;
        public LoginForm()
        {
            InitializeComponent();

            this.SetFormLocation();
            loginControl.RecieveLoginForm(this);
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.C)
            {
                loginControl.btnCancel.PerformClick();
            }
        }

        private void LoginForm_VisibleChanged(object sender, EventArgs e)
        {

            loginMember.EmployeeName = loginControl.txbEmployeeName.Text;
            loginMember.EmployeeCode = loginControl.txbEmployeeCode.Text;


            if (this.Visible == false)
            {
                mainForm = new MainForm();
                mainForm.RecieveLoginForm(this);
                mainForm.SetFormLocation();
                mainForm.lbl작업자.Text = loginMember.EmployeeName.ToString();
                mainForm.Show();
               
            }
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {
            
        }
    }
}
