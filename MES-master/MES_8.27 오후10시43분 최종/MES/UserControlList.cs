using MES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES
{
    public static class UserControlList
    {
        //public string UserControlName { get; set; }

        static public WorkSelect workSelect { get; set; } = new WorkSelect();
        static public WorkStatus workStatus { get; set; } = new WorkStatus();
        static public ProductPerformance productPerformance { get; set; } = new ProductPerformance();
        static public Detailperform detailperform { get; set; } = new Detailperform();
        static public SelfInspection selfInspection { get; set; } = new SelfInspection();
        static public PoolPerform poolPerform { get; set; } = new PoolPerform();
        static public PlanPerform planPerform { get; set; } = new PlanPerform();
        static public Notice notice { get; set; } = new Notice();
    }
}
