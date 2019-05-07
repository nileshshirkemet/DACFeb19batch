using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUIApp
{
    public partial class Greeter : Component
    {
        public Greeter()
        {
            InitializeComponent();
        }

        public Greeter(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

        }

        public string Person { get; set; }

        public string Period { get; set; }

        [Browsable(false)]
        public int Greetings { get; set; }

        public string Greet()
        {
            Greetings += 1;
            return $"Good {Period} {Person}";
        }
    }
}
