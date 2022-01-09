using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace p2pEnergyTrading
{
    public partial class Form2 : Form
    {

        User user;
        Post order;
        
       

        public Form2(User user)
        {
            this.user = user;
            
            InitializeComponent();
            UpdateUser();
            lblUsername.Text = "Username: " + user.Name;
            lblUserId.Text = "User ID: " + user.Uid;
            InitializeDataGridView();
            InitializeDataGridView2();

            

            dgvPostings.SelectionChanged += DataGridView1_SelectionChanged;

            if (((float)user.Energy) >= 2500)
            {
                picBox2badge.Visible = false;
                picBox5badge.Visible = true;
                lblEnergyBadge.Visible = true;
            }
            else
            {

            }
                           
        }
        void UpdateUser()
        {
            lblEneAmount.Text = "Energy Amount: " + user.Energy + " kW";
            lblMoney.Text = "Money: " + " " + user.Money + " $";
            SetMoney(((float)user.Money));
            SetEnergy(((float)user.Energy));
            

            if (((float)user.Money) >= 2500)
            {
                picBox3badge.Visible = false;
                picBox6badge.Visible = true;
                lblMoneyBadge.Visible = true;
            }
            
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvPostings.SelectedRows.Count<1)
                return;
            var row= dgvPostings.SelectedRows[0];
            order=PostingManager.Instance.Posts().ElementAt(row.Index);
            
                buyBtn.Enabled = order.Cost < user.Money && user.Uid!=order.Uid;
            

        }
        public void SetEnergy(float e)
        {
            lblEneAmount.Text = "Total Energy: " + e + " kW";
        }

        public void SetMoney(float i)
        {
            lblMoney.Text = "Total Money: " + i + " $";
        }
        void InitializeDataGridView() {
            dgvPostings.Rows.Clear();
            dgvPostings.Columns.Clear();
            List<Post> posts = new(PostingManager.Instance.Posts());
            dgvPostings.Columns.Add("Name", "Name");
            dgvPostings.Columns.Add("Energy","Energy");
            dgvPostings.Columns.Add("Cost", "Cost");
            dgvPostings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
           foreach(Post post in posts)
            {
                var seller = UserManager.Instance.GetUser(post.Uid);
                dgvPostings.Rows.Add(new string[] { seller.Name,post.Power.ToString(),post.Cost.ToString()});
            }

            dgvPostings.ClearSelection();
        }
        void InitializeDataGridView2() 
        {
            dgvTrades.Columns.Clear();
            dgvTrades.Columns.Add("Seller", "Seller");
            dgvTrades.Columns.Add("Amount", "Energy");
            dgvTrades.Columns.Add("money", "Cost");
            dgvTrades.Columns.Add("date", "Date");
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            findText();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            findText();
        }

        private void findText()
        {
            bool dataFound = false;

            string selectedDate = monthCalendar1.SelectionStart.Day + "-" + monthCalendar1.SelectionStart.Month + "-" + monthCalendar1.SelectionStart.Year;

            lblSelectedDate.Text = "Selected Date : " + selectedDate;

            string[] dataList = File.ReadAllLines("data.txt");
            foreach (string data in dataList)
            {
                string[] dataArray = data.Split('~');

                string user_id = dataArray[0];
                string dateOfData = dataArray[1];
                string text = dataArray[2];

                if (user_id == this.user.Uid && dateOfData == selectedDate)
                {
                    dataFound = true;
                    tBoxEvents.Lines = text.Split(new string[] { "\\n" }, StringSplitOptions.None);
                    break;
                }
            }

            if (!dataFound)
            {
                tBoxEvents.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tBoxEvents.Clear();


        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("BAU - 2022, All Rights Reserved.");

        }

        private void cONTACTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-Developers: \n\nEnergy Systems Engineering Team: \n-Maide Yılmaz, Elif Özkaya, Ayşe Korkmaz \n\nSoftware Engineering Team: \n-Sabih Bağcı, A. Utku Yertutan.  ");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool dataFound = false;

            string selectedDate = monthCalendar1.SelectionStart.Day + "-" + monthCalendar1.SelectionStart.Month +
                "-" + monthCalendar1.SelectionStart.Year;

            string[] dataList = File.ReadAllLines("data.txt");

            for (int i = 0; i < dataList.Length; i++)
            {
                string[] dataArray = dataList[i].Split('~');

                string user_id = dataArray[0];
                string dateOfData = dataArray[1];
                string text = dataArray[2];


                if (user_id == this.user.Uid && dateOfData == selectedDate)
                {
                    string line = arrayToString(tBoxEvents.Lines);

                    dataList[i] = user_id + "~" + selectedDate + "~" + line;
                    dataFound = true;

                    File.WriteAllLines("data.txt", dataList);
                    break;
                }
            }


            if (!dataFound)
            {
                string[] newDataList = new string[dataList.Length + 1];
                for (int i = 0; i < dataList.Length; i++)
                {
                    newDataList[i] = dataList[i];
                }
                newDataList[newDataList.Length - 1] = user.Uid + "~" + selectedDate + "~" + tBoxEvents.Text;

                File.WriteAllLines("data.txt", newDataList);
            }
        }

        public string arrayToString(string[] x)
        {
            string result = "";
            for (int j = 0; j < x.Length - 1; j++)
            {
                result += x[j] + "\\n";
            }
            result += x[x.Length - 1];
            return result;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 ff = new Form1();

            ff.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string[] dataList = File.ReadAllLines("data.txt");
            string selectedDate = monthCalendar1.SelectionStart.Day + "-" + monthCalendar1.SelectionStart.Month +
                "-" + monthCalendar1.SelectionStart.Year;

            int indexOfData = -1;

            for (int s = 0; s < dataList.Length; s++)
            {
                string[] data = dataList[s].Split('~');
                string user_id = data[0];
                string dateOfData = data[1];

                if (user_id == this.user.Uid && dateOfData == selectedDate)
                {
                    indexOfData = s;
                    break;
                }
            }

            if (indexOfData != -1)
            {
                string[] newArray = new string[dataList.Length - 1];

                for (int i = 0; i < dataList.Length; i++)
                {
                    if (i == indexOfData)
                    {
                        continue;
                    }

                    if (i < indexOfData)
                    {
                        newArray[i] = dataList[i];
                    }
                    else
                    {
                        newArray[i - 1] = dataList[i];
                    }
                }

                File.WriteAllLines("data.txt", newArray);
                tBoxEvents.Clear();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void greenEnPicbox_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void greenEngBtn_Click(object sender, EventArgs e)
        {
            greenEnPicbox.Visible = true;
            greenEngBtn.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            PostingManager.Instance.Buy(order, user.Uid);            
            user= UserManager.Instance.GetUser(user.Uid);
            var seller = UserManager.Instance.GetUser(order.Uid);
            UpdateUser();
            dgvTrades.Rows.Add(new string[] { seller.Name,order.Power.ToString(),order.Cost.ToString(),DateTime.Now.ToString()});
            order = null;
            InitializeDataGridView();
            
            picBox4badge.Visible = true;
            lblFirstTrade.Visible = true;

        }

        private void lblTradeCheck_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            var added = ((float)numericUpDown1.Value);
            UserManager.Instance.GetUser(user.Uid).Money += added;
            UserManager.Instance.Save();
            SetMoney(((float)user.Money));
            SetEnergy(((float)user.Energy));
        }

        private void lblEneAmount_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var prompt = new SellPrompt(user);
            var result =prompt.ShowDialog();
            if (result == DialogResult.OK)
                InitializeDataGridView();
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            {
                bool dataFound = false;

                string selectedDate = monthCalendar1.SelectionStart.Day + "-" + monthCalendar1.SelectionStart.Month +
                    "-" + monthCalendar1.SelectionStart.Year;

                string[] dataList = File.ReadAllLines("data.txt");

                for (int i = 0; i < dataList.Length; i++)
                {
                    string[] dataArray = dataList[i].Split('~');

                    string user_id = dataArray[0];
                    string dateOfData = dataArray[1];
                    string text = dataArray[2];


                    if (user_id == this.user.Uid && dateOfData == selectedDate)
                    {
                        string line = arrayToString(tBoxEvents.Lines);

                        dataList[i] = user_id + "~" + selectedDate + "~" + line;
                        dataFound = true;

                        File.WriteAllLines("data.txt", dataList);
                        break;
                    }
                }


                if (!dataFound)
                {
                    string[] newDataList = new string[dataList.Length + 1];
                    for (int i = 0; i < dataList.Length; i++)
                    {
                        newDataList[i] = dataList[i];
                    }
                    newDataList[newDataList.Length - 1] = user.Uid + "~" + selectedDate + "~" + tBoxEvents.Text;

                    File.WriteAllLines("data.txt", newDataList);
                }
            }
        }

        
    }
}
