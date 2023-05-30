using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1
{
    internal class Engineer :Empolyee
    {
        public new decimal Salary
        {
            get { return base.Salary; }
            set
            {
                if (value < 1000)
                    base.Salary = 1000;
                else
                    base.Salary = value;
            }
        }

    }
}
