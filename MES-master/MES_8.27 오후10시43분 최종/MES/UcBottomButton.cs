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
    public partial class UcBottomButton : UserControl
    {

        public WorkSelect workSelected;

        public UcBottomButton()
        {
            InitializeComponent();

        }

        public string ButtonText { get; set; }

        public void Btn1_Click(object sender, EventArgs e)
        {
            Button Line = (Button)sender;
            string LineName = Line.Text;
            workSelected.라인별작업지시(LineName);
        }

        public void WorkSelected(WorkSelect workSelect)
        {
            workSelected = workSelect;
        }


    }
}
