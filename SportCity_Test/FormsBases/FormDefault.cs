﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCity_Test.FormsBases
{
    public partial class FormDefault : FormBaseInvocado
    {
        public FormDefault()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString("h:mm:ss");
            lbFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}