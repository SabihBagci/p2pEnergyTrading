namespace p2pEnergyTrading
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnSaveNotes = new System.Windows.Forms.Button();
            this.tBoxEvents = new System.Windows.Forms.RichTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSelectedDate = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSell = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblUserId = new System.Windows.Forms.Label();
            this.btnAddMoney = new System.Windows.Forms.Button();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblEneAmount = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.greenEngBtn = new System.Windows.Forms.Button();
            this.greenEnPicbox = new System.Windows.Forms.PictureBox();
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblRecents = new System.Windows.Forms.Label();
            this.lblEvents = new System.Windows.Forms.Label();
            this.lblPostings = new System.Windows.Forms.Label();
            this.buyBtn = new System.Windows.Forms.Button();
            this.picBoxBau = new System.Windows.Forms.PictureBox();
            this.lblQuoteOfDay = new System.Windows.Forms.Label();
            this.lblQuote = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvPostings = new System.Windows.Forms.DataGridView();
            this.dgvTrades = new System.Windows.Forms.DataGridView();
            this.lblAchivements = new System.Windows.Forms.Label();
            this.picBox1badge = new System.Windows.Forms.PictureBox();
            this.picBox2badge = new System.Windows.Forms.PictureBox();
            this.picBox3badge = new System.Windows.Forms.PictureBox();
            this.lblFirstTrade = new System.Windows.Forms.Label();
            this.lblEnergyBadge = new System.Windows.Forms.Label();
            this.lblMoneyBadge = new System.Windows.Forms.Label();
            this.picBox4badge = new System.Windows.Forms.PictureBox();
            this.picBox5badge = new System.Windows.Forms.PictureBox();
            this.picBox6badge = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenEnPicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1badge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2badge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3badge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox4badge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox5badge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox6badge)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.Highlight;
            this.monthCalendar1.Location = new System.Drawing.Point(28, 53);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(10);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.InfoText;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btnSaveNotes
            // 
            this.btnSaveNotes.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveNotes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveNotes.ForeColor = System.Drawing.Color.White;
            this.btnSaveNotes.Location = new System.Drawing.Point(14, 235);
            this.btnSaveNotes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveNotes.Name = "btnSaveNotes";
            this.btnSaveNotes.Size = new System.Drawing.Size(119, 46);
            this.btnSaveNotes.TabIndex = 6;
            this.btnSaveNotes.Text = "SAVE";
            this.btnSaveNotes.UseVisualStyleBackColor = true;
            this.btnSaveNotes.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tBoxEvents
            // 
            this.tBoxEvents.BackColor = System.Drawing.SystemColors.Info;
            this.tBoxEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxEvents.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBoxEvents.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tBoxEvents.Location = new System.Drawing.Point(330, 686);
            this.tBoxEvents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tBoxEvents.Name = "tBoxEvents";
            this.tBoxEvents.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tBoxEvents.Size = new System.Drawing.Size(607, 102);
            this.tBoxEvents.TabIndex = 7;
            this.tBoxEvents.Text = "";
            this.tBoxEvents.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(159, 235);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 46);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(14, 288);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClear.Size = new System.Drawing.Size(119, 46);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(159, 288);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 46);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.lblSelectedDate);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnSaveNotes);
            this.groupBox1.Location = new System.Drawing.Point(13, 421);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(299, 367);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // lblSelectedDate
            // 
            this.lblSelectedDate.AutoSize = true;
            this.lblSelectedDate.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedDate.ForeColor = System.Drawing.Color.Black;
            this.lblSelectedDate.Location = new System.Drawing.Point(8, 19);
            this.lblSelectedDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedDate.Name = "lblSelectedDate";
            this.lblSelectedDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSelectedDate.Size = new System.Drawing.Size(198, 30);
            this.lblSelectedDate.TabIndex = 15;
            this.lblSelectedDate.Text = "Please Select a Day!";
            // 
            // cms
            // 
            this.cms.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.contactToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1444, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.aboutToolStripMenuItem.Text = "ABOUT";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aBOUTToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.contactToolStripMenuItem.Text = "CONTACT";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.cONTACTToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnSell);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.lblUserId);
            this.groupBox2.Controls.Add(this.btnAddMoney);
            this.groupBox2.Controls.Add(this.lblMoney);
            this.groupBox2.Controls.Add(this.lblEneAmount);
            this.groupBox2.Controls.Add(this.lblUsername);
            this.groupBox2.Controls.Add(this.greenEngBtn);
            this.groupBox2.Controls.Add(this.greenEnPicbox);
            this.groupBox2.Controls.Add(this.lblProfile);
            this.groupBox2.Location = new System.Drawing.Point(13, 27);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(299, 376);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.Transparent;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSell.ForeColor = System.Drawing.Color.White;
            this.btnSell.Location = new System.Drawing.Point(7, 205);
            this.btnSell.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(118, 30);
            this.btnSell.TabIndex = 32;
            this.btnSell.Text = "Sell Energy";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.Info;
            this.numericUpDown1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDown1.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(136, 175);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(126, 23);
            this.numericUpDown1.TabIndex = 31;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.BackColor = System.Drawing.Color.Transparent;
            this.lblUserId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserId.Location = new System.Drawing.Point(7, 82);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(0, 21);
            this.lblUserId.TabIndex = 30;
            // 
            // btnAddMoney
            // 
            this.btnAddMoney.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMoney.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddMoney.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddMoney.ForeColor = System.Drawing.Color.White;
            this.btnAddMoney.Location = new System.Drawing.Point(8, 169);
            this.btnAddMoney.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddMoney.Name = "btnAddMoney";
            this.btnAddMoney.Size = new System.Drawing.Size(118, 30);
            this.btnAddMoney.TabIndex = 28;
            this.btnAddMoney.Text = "Add Money";
            this.btnAddMoney.UseVisualStyleBackColor = true;
            this.btnAddMoney.Click += new System.EventHandler(this.btnAddMoney_Click);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMoney.Location = new System.Drawing.Point(8, 138);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(252, 21);
            this.lblMoney.TabIndex = 27;
            this.lblMoney.Text = "TOTAL MONEY: {{user.Money}} $";
            // 
            // lblEneAmount
            // 
            this.lblEneAmount.AutoSize = true;
            this.lblEneAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEneAmount.Location = new System.Drawing.Point(7, 117);
            this.lblEneAmount.Name = "lblEneAmount";
            this.lblEneAmount.Size = new System.Drawing.Size(292, 21);
            this.lblEneAmount.TabIndex = 26;
            this.lblEneAmount.Text = "ENERGY AMOUNT: {{user.Power}} kW";
            this.lblEneAmount.Click += new System.EventHandler(this.lblEneAmount_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(8, 61);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 21);
            this.lblUsername.TabIndex = 22;
            // 
            // greenEngBtn
            // 
            this.greenEngBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.greenEngBtn.ForeColor = System.Drawing.Color.White;
            this.greenEngBtn.Location = new System.Drawing.Point(144, 275);
            this.greenEngBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.greenEngBtn.Name = "greenEngBtn";
            this.greenEngBtn.Size = new System.Drawing.Size(148, 46);
            this.greenEngBtn.TabIndex = 22;
            this.greenEngBtn.Text = "Send Verification Request For Green Energy ";
            this.greenEngBtn.UseVisualStyleBackColor = true;
            this.greenEngBtn.Click += new System.EventHandler(this.greenEngBtn_Click);
            // 
            // greenEnPicbox
            // 
            this.greenEnPicbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("greenEnPicbox.BackgroundImage")));
            this.greenEnPicbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.greenEnPicbox.Location = new System.Drawing.Point(143, 221);
            this.greenEnPicbox.Name = "greenEnPicbox";
            this.greenEnPicbox.Size = new System.Drawing.Size(149, 145);
            this.greenEnPicbox.TabIndex = 22;
            this.greenEnPicbox.TabStop = false;
            this.greenEnPicbox.Visible = false;
            this.greenEnPicbox.Click += new System.EventHandler(this.greenEnPicbox_Click);
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProfile.Location = new System.Drawing.Point(7, 19);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(119, 30);
            this.lblProfile.TabIndex = 0;
            this.lblProfile.Text = "Your Profile";
            this.lblProfile.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblRecents
            // 
            this.lblRecents.AutoSize = true;
            this.lblRecents.BackColor = System.Drawing.Color.Transparent;
            this.lblRecents.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRecents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRecents.Location = new System.Drawing.Point(330, 421);
            this.lblRecents.Name = "lblRecents";
            this.lblRecents.Size = new System.Drawing.Size(239, 37);
            this.lblRecents.TabIndex = 16;
            this.lblRecents.Text = "Your Recent Trades";
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.BackColor = System.Drawing.Color.Transparent;
            this.lblEvents.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEvents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEvents.Location = new System.Drawing.Point(330, 635);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(160, 37);
            this.lblEvents.TabIndex = 17;
            this.lblEvents.Text = "Daily Events";
            this.lblEvents.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPostings
            // 
            this.lblPostings.AutoSize = true;
            this.lblPostings.BackColor = System.Drawing.Color.Transparent;
            this.lblPostings.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPostings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPostings.Location = new System.Drawing.Point(330, 37);
            this.lblPostings.Name = "lblPostings";
            this.lblPostings.Size = new System.Drawing.Size(116, 37);
            this.lblPostings.TabIndex = 19;
            this.lblPostings.Text = "Postings";
            // 
            // buyBtn
            // 
            this.buyBtn.BackColor = System.Drawing.Color.Transparent;
            this.buyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buyBtn.ForeColor = System.Drawing.Color.White;
            this.buyBtn.Location = new System.Drawing.Point(783, 380);
            this.buyBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(142, 46);
            this.buyBtn.TabIndex = 21;
            this.buyBtn.Text = "BUY";
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // picBoxBau
            // 
            this.picBoxBau.BackColor = System.Drawing.Color.Transparent;
            this.picBoxBau.BackgroundImage = global::p2pEnergyTrading.Properties.Resources.bauLogo;
            this.picBoxBau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxBau.InitialImage = null;
            this.picBoxBau.Location = new System.Drawing.Point(1271, 609);
            this.picBoxBau.Name = "picBoxBau";
            this.picBoxBau.Size = new System.Drawing.Size(161, 190);
            this.picBoxBau.TabIndex = 23;
            this.picBoxBau.TabStop = false;
            // 
            // lblQuoteOfDay
            // 
            this.lblQuoteOfDay.AutoSize = true;
            this.lblQuoteOfDay.BackColor = System.Drawing.Color.Transparent;
            this.lblQuoteOfDay.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuoteOfDay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuoteOfDay.Location = new System.Drawing.Point(1207, 46);
            this.lblQuoteOfDay.Name = "lblQuoteOfDay";
            this.lblQuoteOfDay.Size = new System.Drawing.Size(225, 37);
            this.lblQuoteOfDay.TabIndex = 24;
            this.lblQuoteOfDay.Text = "Quote of The Day";
            // 
            // lblQuote
            // 
            this.lblQuote.AutoSize = true;
            this.lblQuote.BackColor = System.Drawing.Color.Transparent;
            this.lblQuote.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuote.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuote.Location = new System.Drawing.Point(1138, 100);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(294, 160);
            this.lblQuote.TabIndex = 25;
            this.lblQuote.Text = "“Science can amuse and \r\nfascinate us all, but it is \r\nengineering that changes \r" +
    "\nthe world.”\r\n                  -Isaac Asimov";
            // 
            // dgvPostings
            // 
            this.dgvPostings.AllowUserToAddRows = false;
            this.dgvPostings.AllowUserToDeleteRows = false;
            this.dgvPostings.AllowUserToOrderColumns = true;
            this.dgvPostings.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvPostings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPostings.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPostings.Location = new System.Drawing.Point(330, 76);
            this.dgvPostings.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPostings.MultiSelect = false;
            this.dgvPostings.Name = "dgvPostings";
            this.dgvPostings.ReadOnly = true;
            this.dgvPostings.RowHeadersWidth = 62;
            this.dgvPostings.RowTemplate.Height = 33;
            this.dgvPostings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPostings.Size = new System.Drawing.Size(606, 299);
            this.dgvPostings.TabIndex = 27;
            this.dgvPostings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvTrades
            // 
            this.dgvTrades.AllowUserToAddRows = false;
            this.dgvTrades.AllowUserToDeleteRows = false;
            this.dgvTrades.AllowUserToOrderColumns = true;
            this.dgvTrades.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvTrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrades.Location = new System.Drawing.Point(330, 474);
            this.dgvTrades.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTrades.MultiSelect = false;
            this.dgvTrades.Name = "dgvTrades";
            this.dgvTrades.ReadOnly = true;
            this.dgvTrades.RowHeadersWidth = 62;
            this.dgvTrades.RowTemplate.Height = 33;
            this.dgvTrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTrades.Size = new System.Drawing.Size(606, 159);
            this.dgvTrades.TabIndex = 28;
            // 
            // lblAchivements
            // 
            this.lblAchivements.AutoSize = true;
            this.lblAchivements.BackColor = System.Drawing.Color.Transparent;
            this.lblAchivements.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAchivements.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAchivements.Location = new System.Drawing.Point(1056, 283);
            this.lblAchivements.Name = "lblAchivements";
            this.lblAchivements.Size = new System.Drawing.Size(169, 37);
            this.lblAchivements.TabIndex = 29;
            this.lblAchivements.Text = "Your Badges:";
            // 
            // picBox1badge
            // 
            this.picBox1badge.BackColor = System.Drawing.Color.Transparent;
            this.picBox1badge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox1badge.BackgroundImage")));
            this.picBox1badge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox1badge.InitialImage = null;
            this.picBox1badge.Location = new System.Drawing.Point(1084, 325);
            this.picBox1badge.Name = "picBox1badge";
            this.picBox1badge.Size = new System.Drawing.Size(107, 101);
            this.picBox1badge.TabIndex = 30;
            this.picBox1badge.TabStop = false;
            // 
            // picBox2badge
            // 
            this.picBox2badge.BackColor = System.Drawing.Color.Transparent;
            this.picBox2badge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox2badge.BackgroundImage")));
            this.picBox2badge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox2badge.InitialImage = null;
            this.picBox2badge.Location = new System.Drawing.Point(1207, 325);
            this.picBox2badge.Name = "picBox2badge";
            this.picBox2badge.Size = new System.Drawing.Size(107, 101);
            this.picBox2badge.TabIndex = 31;
            this.picBox2badge.TabStop = false;
            // 
            // picBox3badge
            // 
            this.picBox3badge.BackColor = System.Drawing.Color.Transparent;
            this.picBox3badge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox3badge.BackgroundImage")));
            this.picBox3badge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox3badge.InitialImage = null;
            this.picBox3badge.Location = new System.Drawing.Point(1325, 325);
            this.picBox3badge.Name = "picBox3badge";
            this.picBox3badge.Size = new System.Drawing.Size(107, 101);
            this.picBox3badge.TabIndex = 32;
            this.picBox3badge.TabStop = false;
            // 
            // lblFirstTrade
            // 
            this.lblFirstTrade.AutoSize = true;
            this.lblFirstTrade.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstTrade.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstTrade.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFirstTrade.Location = new System.Drawing.Point(1095, 433);
            this.lblFirstTrade.Name = "lblFirstTrade";
            this.lblFirstTrade.Size = new System.Drawing.Size(87, 25);
            this.lblFirstTrade.TabIndex = 33;
            this.lblFirstTrade.Text = "1st Trade";
            this.lblFirstTrade.Visible = false;
            // 
            // lblEnergyBadge
            // 
            this.lblEnergyBadge.AutoSize = true;
            this.lblEnergyBadge.BackColor = System.Drawing.Color.Transparent;
            this.lblEnergyBadge.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnergyBadge.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEnergyBadge.Location = new System.Drawing.Point(1193, 433);
            this.lblEnergyBadge.Name = "lblEnergyBadge";
            this.lblEnergyBadge.Size = new System.Drawing.Size(130, 25);
            this.lblEnergyBadge.TabIndex = 34;
            this.lblEnergyBadge.Text = "Super Battery!";
            this.lblEnergyBadge.Visible = false;
            // 
            // lblMoneyBadge
            // 
            this.lblMoneyBadge.AutoSize = true;
            this.lblMoneyBadge.BackColor = System.Drawing.Color.Transparent;
            this.lblMoneyBadge.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMoneyBadge.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMoneyBadge.Location = new System.Drawing.Point(1331, 433);
            this.lblMoneyBadge.Name = "lblMoneyBadge";
            this.lblMoneyBadge.Size = new System.Drawing.Size(101, 25);
            this.lblMoneyBadge.TabIndex = 35;
            this.lblMoneyBadge.Text = "Profit Lord";
            this.lblMoneyBadge.Visible = false;
            // 
            // picBox4badge
            // 
            this.picBox4badge.BackColor = System.Drawing.Color.Transparent;
            this.picBox4badge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox4badge.BackgroundImage")));
            this.picBox4badge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox4badge.InitialImage = null;
            this.picBox4badge.Location = new System.Drawing.Point(1084, 325);
            this.picBox4badge.Name = "picBox4badge";
            this.picBox4badge.Size = new System.Drawing.Size(107, 101);
            this.picBox4badge.TabIndex = 36;
            this.picBox4badge.TabStop = false;
            this.picBox4badge.Visible = false;
            // 
            // picBox5badge
            // 
            this.picBox5badge.BackColor = System.Drawing.Color.Transparent;
            this.picBox5badge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox5badge.BackgroundImage")));
            this.picBox5badge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox5badge.InitialImage = null;
            this.picBox5badge.Location = new System.Drawing.Point(1207, 325);
            this.picBox5badge.Name = "picBox5badge";
            this.picBox5badge.Size = new System.Drawing.Size(107, 101);
            this.picBox5badge.TabIndex = 37;
            this.picBox5badge.TabStop = false;
            this.picBox5badge.Visible = false;
            // 
            // picBox6badge
            // 
            this.picBox6badge.BackColor = System.Drawing.Color.Transparent;
            this.picBox6badge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox6badge.BackgroundImage")));
            this.picBox6badge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox6badge.InitialImage = null;
            this.picBox6badge.Location = new System.Drawing.Point(1325, 325);
            this.picBox6badge.Name = "picBox6badge";
            this.picBox6badge.Size = new System.Drawing.Size(107, 101);
            this.picBox6badge.TabIndex = 38;
            this.picBox6badge.TabStop = false;
            this.picBox6badge.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::p2pEnergyTrading.Properties.Resources.energy1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1444, 811);
            this.Controls.Add(this.picBox6badge);
            this.Controls.Add(this.picBox5badge);
            this.Controls.Add(this.picBox4badge);
            this.Controls.Add(this.lblMoneyBadge);
            this.Controls.Add(this.lblEnergyBadge);
            this.Controls.Add(this.lblFirstTrade);
            this.Controls.Add(this.picBox3badge);
            this.Controls.Add(this.picBox2badge);
            this.Controls.Add(this.picBox1badge);
            this.Controls.Add(this.lblAchivements);
            this.Controls.Add(this.dgvTrades);
            this.Controls.Add(this.dgvPostings);
            this.Controls.Add(this.lblQuote);
            this.Controls.Add(this.lblQuoteOfDay);
            this.Controls.Add(this.picBoxBau);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.lblPostings);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.lblRecents);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tBoxEvents);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "p2p Energy Trading";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenEnPicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1badge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2badge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3badge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox4badge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox5badge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox6badge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnSaveNotes;
        private System.Windows.Forms.RichTextBox tBoxEvents;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.Label lblSelectedDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblRecents;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.Label lblPostings;
        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.PictureBox greenEnPicbox;
        private System.Windows.Forms.Button greenEngBtn;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox picBoxBau;
        private System.Windows.Forms.Label lblQuoteOfDay;
        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.Label lblEneAmount;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Button btnAddMoney;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dgvPostings;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dgvTrades;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label lblAchivements;
        private System.Windows.Forms.PictureBox picBox1badge;
        private System.Windows.Forms.PictureBox picBox2badge;
        private System.Windows.Forms.PictureBox picBox3badge;
        private System.Windows.Forms.Label lblFirstTrade;
        private System.Windows.Forms.Label lblEnergyBadge;
        private System.Windows.Forms.Label lblMoneyBadge;
        private System.Windows.Forms.PictureBox picBox4badge;
        private System.Windows.Forms.PictureBox picBox5badge;
        private System.Windows.Forms.PictureBox picBox6badge;
    }
}