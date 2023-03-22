using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class survey : Form
    {
        public survey()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string str = " ";

            // japan
            if (JapanCheck.Checked == true)
            {

                str = str + JapanCheck.Text;
                str += " ";

            }

            // philippine
            if (PhilippinesCheck.Checked == true)
            {

                str = str + PhilippinesCheck.Text;
                str += " ";

            }
            // indonesia
            if (indonesiaCheck.Checked == true)
            {

                str = str + indonesiaCheck.Text;
                str += " ";

            }

            // china
            if (australiaCheck.Checked == true)
            {

                str = str + australiaCheck.Text;
                str += " ";

            }

            // others
            if (othersTwo.Checked == true)
            {

                str = str + othersBox.Text;
                str += " ";

            }


            if (str != null)
            {

                MessageBox.Show("You Selected : \n" + str + "\n Thank You!", "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void othersBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void othersTwo_CheckedChanged(object sender, EventArgs e)
        {
            if(othersTwo.Checked == false){

            othersBox.Visible = false;
            othersText.Visible = false;
           }
           else{
            othersBox.Visible = true;
            othersText.Visible = true;
           }

        }

        private void survey_Load(object sender, EventArgs e)
        {

            othersBox.Visible = false;
            othersText.Visible = false;
           

        }

        private void americaCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void australiaCheck_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
