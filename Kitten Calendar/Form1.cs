using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitten_Calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
            label3.Visible = false;
        }
           
        public void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            monthCalendar1.TitleBackColor = System.Drawing.Color.Blue;
            SelectionRange range1 = new SelectionRange(dateTimePicker1.Value.AddDays(64.0),
                                          dateTimePicker1.Value.AddDays(66.0));
            textBox1.Visible = false;
            label2.Visible = true;
            monthCalendar1.SelectionRange = range1;
            //***matches datepicer***  monthCalendar1.SetDate(dateTimePicker1.Value);
            //MessageBox.Show(dateTimePicker1.Value.Date.ToString());
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            SelectionRange range2 = new SelectionRange(dateTimePicker2.Value.AddDays(84.0),
                                          dateTimePicker2.Value.AddDays(84.0));
            textBox2.Visible = false;
            label3.Visible = true;
            monthCalendar2.SelectionRange = range2;
        }
    }
}
