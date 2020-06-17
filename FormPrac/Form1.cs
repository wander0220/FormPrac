using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrac
{
    public partial class Form1 : Form
    {
        public class CustomForm : Form
        {
            public CustomForm()
            {
                this.Text = "내가 만든 폼!";
            }
        }
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomForm cf;
            for (var i = 0; i < 5; i++)
            {
                cf = new CustomForm();
                cf.MdiParent = this;
                cf.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomForm cf = new CustomForm();
            cf.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }
}
