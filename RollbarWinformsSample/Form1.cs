using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RollbarDotNet;
using Exception = System.Exception;

namespace RollbarWinformsSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs args)
        {
            try
            {
                List<string> foo = null;
                foo.Add("test");
            }
            catch (Exception e)
            {
                Rollbar.Report(e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> foo = null;
            foo.Add("test");
        }
    }
}
