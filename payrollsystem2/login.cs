using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payrollsystem2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(100, 10);
            lblselectposition.Hide();
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbluser_MouseClick(object sender, MouseEventArgs e)
        {
            lbluser.Hide();
            txtuser.Focus();
            

            if ((txtuser.Focus() == true) && (String.IsNullOrEmpty(txtpass.Text) == true))
            {
                lblpass.Show();
            }
            else
            {
                lblpass.Hide();
            }
        }

        private void lblpassword_MouseClick(object sender, MouseEventArgs e)
        {
            lblpass.Hide();
            txtpass.Focus();
            
           
            if ((txtpass.Focus() == true) && (String.IsNullOrEmpty(txtuser.Text) == true))
            {
                lbluser.Show();
            }
            else
            {
                lbluser.Hide();
            }
           
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           
            
            if (String.IsNullOrEmpty(comboxuser.Text) == true)
            {
               
                lblselectposition.Show();
                comboxuser.Focus();
            }

            else
            {
                progressbar prog = new progressbar();
                prog.Show();
                this.Hide();
            }
        }

        private void comboxuser_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblselectposition.Hide();
        }

        private void comboxuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtuser.Text) == true)
            {
                lbluser.Show();
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtpass.Text) == true)
            {
                lblpass.Show();
            }
        }

        private void txtuser_MouseClick(object sender, MouseEventArgs e)
        {
            txtuser.Focus();
            lbluser.Hide();
            if(txtuser.Focus() == true)
            {
               

                if (String.IsNullOrEmpty(txtpass.Text) == true)
                {
                    lblpass.Show();
                }
            }
        }

        private void txtpass_MouseClick(object sender, MouseEventArgs e)
        {
            txtpass.Focus();
            lblpass.Hide();
            if (txtpass.Focus() == true)
            {
                

                if (String.IsNullOrEmpty(txtuser.Text) == true)
                {
                    lbluser.Show();
                }
            }
        }
    }
}
