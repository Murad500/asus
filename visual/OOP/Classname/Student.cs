using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classname
{
    public partial class Student : Component
    {
        public Student()
        {
            InitializeComponent();
        }

        public Student(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
