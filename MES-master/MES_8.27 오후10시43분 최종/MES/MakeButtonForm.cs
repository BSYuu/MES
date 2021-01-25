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
    public partial class MakeButtonForm : MetroForm
    {
        public event EventHandler 확인;

        public MakeButtonForm()
        {
            InitializeComponent();
        }

        private void Btn확인_Click(object sender, EventArgs e)
        {
            if (cbx분류형태.Text == "")
                return;

            if (label1.Text == "분류추가")
            {
                확인(cbx분류형태.Text, e);
            }
            else
            {
                확인(cbx분류형태.Text, null);
            }
            



        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
