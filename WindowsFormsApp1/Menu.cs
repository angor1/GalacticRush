using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool create = false;
            foreach(Form form in Application.OpenForms)
            {
                if(form.Name.ToString() == "Form1")
                {
                    this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }

            if(create == false)
            {
                Form1 hawkeye = new Form1();
                this.Hide();
                hawkeye.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool create = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "History")
                {
                    this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }

            if (create == false)
            {
                History hawkeye = new History();
                this.Hide();
                hawkeye.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool create = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "Rules")
                {
                    this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }

            if (create == false)
            {
                Rules hawkeye = new Rules();
                this.Hide();
                hawkeye.Show();
            }
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
