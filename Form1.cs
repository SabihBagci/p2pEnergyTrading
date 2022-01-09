using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p2pEnergyTrading

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            
            bool error = false;
            string username = "", password = "";
            username = textBox1.Text.Trim();
            password = textBox2.Text.Trim();

            if (username == "" || password == "")
            {
                lblInfo.Text = "Please do not leave username and password empty!";
                error = true;
            }

            if (username.Length < 3 && !error)
            {
                lblInfo.Text = "A username must have at least 3 characters!";
                error = true;
            }

            if (password.Length < 6 && !error)
            {
                lblInfo.Text = "A password must have at least 6 characters!";
                error = true;
            }

            if (!error)
            {
                bool userFound = false;

                string[] userList = File.ReadAllLines("user.txt");

                foreach (string userInfo in userList)
                {
                    string[] user = userInfo.Split('~');
                    if (user[1] == username && user[2] == password)
                    {
                        userFound = true;
                        MessageBox.Show("   WELCOME TO P2P ENERGY TRADING APP.\n                   HAVE A GOOD DAY! \n          -You Are Directing To Main Page-");

                        Form2 f2 = new(UserManager.Instance.GetUser(user[0]));
                        
                        f2.Show();
                        this.Hide();

                    }
                }

                if (userFound == false)
                {
                    textBox1.Text = "";
        
                    textBox2.Text = "";
                    lblInfo.Text = "Username or password is wrong!";
                }
            }

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            bool error = false;
            string username = "", password = "";
            username = textBox1.Text.Trim();
            password = textBox2.Text.Trim();
            if (username == "" || password == "")
            {
                lblInfo.Text = "Please do not leave username and password empty!";
                error = true;
            }

            if (username.Length < 3 && !error)
            {
                lblInfo.Text = "A username must have at least 3 characters!";
                error = true;
            }

            if (password.Length < 6 && !error)
            {
                lblInfo.Text = "A password must have at least 6 characters!";
                error = true;
            }

            if (!error)
            {
                string[] userList = File.ReadAllLines("user.txt");

                bool usernameAlreadyUsed = false;

                foreach (string userInfo in userList)
                {
                    string[] user = userInfo.Split('~');
                    if (user[1] == username)
                    {
                        usernameAlreadyUsed = true;
                        break;
                    }
                }

                if (usernameAlreadyUsed == false)
                {
                    string[] newUserList = new string[userList.Length + 1];
                    for (int i = 0; i < userList.Length; i++)
                    {
                        newUserList[i] = userList[i];
                    }
                    int newUid = (userList.Length + 1);
                    newUserList[newUserList.Length - 1] = newUid+"~"+ username + "~" + password;
                    File.WriteAllLines("user.txt", newUserList);
                    UserManager.Instance.addUser(new User(newUid.ToString(), username, "220", "220"));
                    UserManager.Instance.Save();
                    lblInfo.Text = "Registration Completed! Please Click Login";
                }
                else
                {
                    lblInfo.Text = "This username is already used!";
                }
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblInfo.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lblInfo.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnPassForgot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-Your password reset link has been sent to your e-mail address.");
        }
    }
}
