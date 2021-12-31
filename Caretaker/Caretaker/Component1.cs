using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace Caretaker
{
    public partial class Component1 : Component
    {
        public Component1()
        {
            InitializeComponent();
        }

        public Component1(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
