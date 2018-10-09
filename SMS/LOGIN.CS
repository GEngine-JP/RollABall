using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace SMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtLoginName.Focus();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLoginName.Text == "")
                {
<<<<<<< HEAD
                    MessageBox.Show("ç”¨æˆ·åä¸èƒ½ä¸ºç©º");
=======
                    MessageBox.Show("ÓÃ»§Ãû²»ÄÜÎª¿Õ");
>>>>>>> e0e56366e705633044693d73d82864e260b3f212
                }
                else
                {
                    if (txtLoginPwd.Text == "")
                    {
<<<<<<< HEAD
                        MessageBox.Show("å¯†ç ä¸èƒ½ä¸ºç©º");
=======
                        MessageBox.Show("ÃÜÂë²»ÄÜÎª¿Õ");
>>>>>>> e0e56366e705633044693d73d82864e260b3f212
                    }
                    else
                    {
                        OleDbConnection conn = BaseClass.ConnClass.DataConn();
                        conn.Open();
                        OleDbCommand cmd = new OleDbCommand("select count(*) from tb_Admin where AdminUserName='" + txtLoginName.Text + "' and AdminUserPwd='" + txtLoginPwd.Text + "'", conn);
                        int i = Convert.ToInt32(cmd.ExecuteScalar());
                        if (i > 0)
                        {
                            Main main = new Main();
                            main.adminname = txtLoginName.Text;
                            main.admintime = DateTime.Now.ToShortDateString();
                            main.Show();
                            this.Hide();
                        }
                        else
                        {
<<<<<<< HEAD
                            MessageBox.Show("ç”¨æˆ·åæˆ–è€…å¯†ç é”™è¯¯");
=======
                            MessageBox.Show("ÓÃ»§Ãû»òÕßÃÜÂë´íÎó");
>>>>>>> e0e56366e705633044693d73d82864e260b3f212
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLoginPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin_Click(sender,e);
            }
        }
    }
}