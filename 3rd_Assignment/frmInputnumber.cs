using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3rd_Assignment
{

    public delegate void PassValueHandler(string strValue);

    public partial class frmInputnumber : Form
    {
        public event PassValueHandler PassValue;

        public frmInputnumber()
        {
            InitializeComponent();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            int label = Convert.ToInt32(label1.Text);
            int num1 = int.Parse(textBox1.Text);
            int result = label + num1;
            label1.Text = result.ToString();
            if (PassValue != null)
            {
                PassValue(label1.Text);
            }
            
           
        }

        

  
        
    }
}
