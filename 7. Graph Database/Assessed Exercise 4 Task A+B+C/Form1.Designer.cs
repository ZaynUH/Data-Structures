namespace Assessed_Exercise_4_Task_A_B_C
{
    partial class Form1
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.ConnectionList = new System.Windows.Forms.ListBox();
            this.userOneDropDown = new System.Windows.Forms.ComboBox();
            this.userTwoDropDown = new System.Windows.Forms.ComboBox();
            this.DeleteDropDown = new System.Windows.Forms.ComboBox();
            this.AddConBtn = new System.Windows.Forms.Button();
            this.SelectUserComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NodeAdjCountTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.MostConTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.MostAvgComTextBox = new System.Windows.Forms.TextBox();
            this.AvgConTextBox = new System.Windows.Forms.TextBox();
            this.AvgWeightsTextBox = new System.Windows.Forms.TextBox();
            this.TotalConTextBox = new System.Windows.Forms.TextBox();
            this.TotalNodesTextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.UserBFSList = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(118, 54);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Insert";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(116, 124);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "Remove";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.Location = new System.Drawing.Point(102, 27);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.userIDTextBox.TabIndex = 3;
            this.userIDTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ConnectionList
            // 
            this.ConnectionList.FormattingEnabled = true;
            this.ConnectionList.Location = new System.Drawing.Point(22, 109);
            this.ConnectionList.Name = "ConnectionList";
            this.ConnectionList.Size = new System.Drawing.Size(123, 69);
            this.ConnectionList.TabIndex = 4;
            // 
            // userOneDropDown
            // 
            this.userOneDropDown.FormattingEnabled = true;
            this.userOneDropDown.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.userOneDropDown.Location = new System.Drawing.Point(15, 53);
            this.userOneDropDown.Name = "userOneDropDown";
            this.userOneDropDown.Size = new System.Drawing.Size(123, 21);
            this.userOneDropDown.TabIndex = 6;
            this.userOneDropDown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // userTwoDropDown
            // 
            this.userTwoDropDown.FormattingEnabled = true;
            this.userTwoDropDown.Location = new System.Drawing.Point(144, 53);
            this.userTwoDropDown.Name = "userTwoDropDown";
            this.userTwoDropDown.Size = new System.Drawing.Size(123, 21);
            this.userTwoDropDown.TabIndex = 10;
            this.userTwoDropDown.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // DeleteDropDown
            // 
            this.DeleteDropDown.FormattingEnabled = true;
            this.DeleteDropDown.Location = new System.Drawing.Point(102, 96);
            this.DeleteDropDown.Name = "DeleteDropDown";
            this.DeleteDropDown.Size = new System.Drawing.Size(100, 21);
            this.DeleteDropDown.TabIndex = 11;
            this.DeleteDropDown.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // AddConBtn
            // 
            this.AddConBtn.Location = new System.Drawing.Point(101, 128);
            this.AddConBtn.Name = "AddConBtn";
            this.AddConBtn.Size = new System.Drawing.Size(75, 23);
            this.AddConBtn.TabIndex = 12;
            this.AddConBtn.Text = "Create Connection";
            this.AddConBtn.UseVisualStyleBackColor = true;
            this.AddConBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // SelectUserComboBox
            // 
            this.SelectUserComboBox.FormattingEnabled = true;
            this.SelectUserComboBox.Location = new System.Drawing.Point(22, 24);
            this.SelectUserComboBox.Name = "SelectUserComboBox";
            this.SelectUserComboBox.Size = new System.Drawing.Size(123, 21);
            this.SelectUserComboBox.TabIndex = 14;
            this.SelectUserComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.userIDTextBox);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.DeleteBtn);
            this.groupBox1.Controls.Add(this.DeleteDropDown);
            this.groupBox1.Location = new System.Drawing.Point(64, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 165);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nodes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Remove Node";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Add Node";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.weightTextBox);
            this.groupBox2.Controls.Add(this.AddConBtn);
            this.groupBox2.Controls.Add(this.userTwoDropDown);
            this.groupBox2.Controls.Add(this.userOneDropDown);
            this.groupBox2.Location = new System.Drawing.Point(27, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 163);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Node Connections";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Enter Two Nodes For Connection";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Weight:";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(117, 92);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Outbound Connections:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.UserBFSList);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.NodeAdjCountTextBox);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.SelectUserComboBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.ConnectionList);
            this.groupBox3.Location = new System.Drawing.Point(348, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(167, 341);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Node";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Node | (Weight)";
            // 
            // NodeAdjCountTextBox
            // 
            this.NodeAdjCountTextBox.Location = new System.Drawing.Point(74, 184);
            this.NodeAdjCountTextBox.Name = "NodeAdjCountTextBox";
            this.NodeAdjCountTextBox.ReadOnly = true;
            this.NodeAdjCountTextBox.Size = new System.Drawing.Size(46, 20);
            this.NodeAdjCountTextBox.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Total";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.MostConTextBox);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.MostAvgComTextBox);
            this.groupBox4.Controls.Add(this.AvgConTextBox);
            this.groupBox4.Controls.Add(this.AvgWeightsTextBox);
            this.groupBox4.Controls.Add(this.TotalConTextBox);
            this.groupBox4.Controls.Add(this.TotalNodesTextBox);
            this.groupBox4.Controls.Add(this.label);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(570, 97);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(181, 201);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Graph Info";
            // 
            // MostConTextBox
            // 
            this.MostConTextBox.Location = new System.Drawing.Point(112, 130);
            this.MostConTextBox.Name = "MostConTextBox";
            this.MostConTextBox.ReadOnly = true;
            this.MostConTextBox.Size = new System.Drawing.Size(63, 20);
            this.MostConTextBox.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Most Connections: ";
            // 
            // MostAvgComTextBox
            // 
            this.MostAvgComTextBox.Location = new System.Drawing.Point(112, 159);
            this.MostAvgComTextBox.Name = "MostAvgComTextBox";
            this.MostAvgComTextBox.ReadOnly = true;
            this.MostAvgComTextBox.Size = new System.Drawing.Size(63, 20);
            this.MostAvgComTextBox.TabIndex = 24;
            this.MostAvgComTextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // AvgConTextBox
            // 
            this.AvgConTextBox.Location = new System.Drawing.Point(129, 104);
            this.AvgConTextBox.Name = "AvgConTextBox";
            this.AvgConTextBox.ReadOnly = true;
            this.AvgConTextBox.Size = new System.Drawing.Size(46, 20);
            this.AvgConTextBox.TabIndex = 23;
            // 
            // AvgWeightsTextBox
            // 
            this.AvgWeightsTextBox.Location = new System.Drawing.Point(129, 78);
            this.AvgWeightsTextBox.Name = "AvgWeightsTextBox";
            this.AvgWeightsTextBox.ReadOnly = true;
            this.AvgWeightsTextBox.Size = new System.Drawing.Size(46, 20);
            this.AvgWeightsTextBox.TabIndex = 22;
            // 
            // TotalConTextBox
            // 
            this.TotalConTextBox.Location = new System.Drawing.Point(129, 52);
            this.TotalConTextBox.Name = "TotalConTextBox";
            this.TotalConTextBox.ReadOnly = true;
            this.TotalConTextBox.Size = new System.Drawing.Size(46, 20);
            this.TotalConTextBox.TabIndex = 21;
            this.TotalConTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TotalNodesTextBox
            // 
            this.TotalNodesTextBox.Location = new System.Drawing.Point(129, 22);
            this.TotalNodesTextBox.Name = "TotalNodesTextBox";
            this.TotalNodesTextBox.ReadOnly = true;
            this.TotalNodesTextBox.Size = new System.Drawing.Size(46, 20);
            this.TotalNodesTextBox.TabIndex = 20;
            this.TotalNodesTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(8, 153);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(82, 26);
            this.label.TabIndex = 4;
            this.label.Text = "Most Average \r\nCommunication:";
            this.label.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average Connections: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Average Weights: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total Connections: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Nodes: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(614, 380);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Output:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(530, 403);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(240, 20);
            this.OutputTextBox.TabIndex = 15;
            this.OutputTextBox.TextChanged += new System.EventHandler(this.OutputTextBox_TextChanged);
            // 
            // UserBFSList
            // 
            this.UserBFSList.FormattingEnabled = true;
            this.UserBFSList.Location = new System.Drawing.Point(22, 244);
            this.UserBFSList.Name = "UserBFSList";
            this.UserBFSList.Size = new System.Drawing.Size(123, 82);
            this.UserBFSList.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 222);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "All Connected Users:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(266, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(281, 33);
            this.label15.TabIndex = 23;
            this.label15.Text = "Graph User Network";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.ListBox ConnectionList;
        private System.Windows.Forms.Button AddConBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox SelectUserComboBox;
        private System.Windows.Forms.ComboBox userOneDropDown;
        private System.Windows.Forms.ComboBox userTwoDropDown;
        private System.Windows.Forms.ComboBox DeleteDropDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox NodeAdjCountTextBox;
        private System.Windows.Forms.TextBox TotalConTextBox;
        private System.Windows.Forms.TextBox TotalNodesTextBox;
        private System.Windows.Forms.TextBox MostAvgComTextBox;
        private System.Windows.Forms.TextBox AvgConTextBox;
        private System.Windows.Forms.TextBox AvgWeightsTextBox;
        private System.Windows.Forms.TextBox MostConTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox UserBFSList;
        private System.Windows.Forms.Label label15;
    }
}

