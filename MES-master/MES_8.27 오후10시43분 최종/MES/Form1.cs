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
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<공정시작수량Data> 공정시작수량list = new List<공정시작수량Data>();
            공정시작수량list = DB.수주.Get공정시작수량();

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("제품번호");
            dataTable.Columns.Add("1차공정시작");
            dataTable.Columns.Add("1차관리번호");
            dataTable.Columns.Add("1차필요수량");
            dataTable.Columns.Add("1차공정시작날짜");
            dataTable.Columns.Add("순위");
            dataTable.Columns.Add("2차공정시작");
            dataTable.Columns.Add("2차관리번호");
            dataTable.Columns.Add("2차필요수량");
            dataTable.Columns.Add("2차공정시작날짜");
            dataTable.Columns.Add("LOT수량");


            foreach (var item in 공정시작수량list)
            {
                var row = dataTable.NewRow();
                row.ItemArray = new object[] { item.제품번호, item._1차공정시작, item._1차관리번호, item._1차필요수량, item._1차공정시작날짜.ToShortDateString(),
                                               item.순위, item._2차공정시작, item._2차관리번호, item._2차필요수량, item._2차공정시작날짜.ToShortDateString(),
                                               item.LOT수량};
                dataTable.Rows.Add(row);
            }

            bds.DataSource = dataTable;
            grid.DataSource = bds;
        }

    }
}
