namespace Assessed_Exersise_1_Task_3
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
            this.BookStore = new System.Windows.Forms.ListBox();
            this.bookTitleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.authorNameTextBox = new System.Windows.Forms.TextBox();
            this.ISBNCodeTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bookCountLabel = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookStore
            // 
            this.BookStore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookStore.FormattingEnabled = true;
            this.BookStore.ItemHeight = 21;
            this.BookStore.Location = new System.Drawing.Point(394, 87);
            this.BookStore.Name = "BookStore";
            this.BookStore.Size = new System.Drawing.Size(376, 340);
            this.BookStore.TabIndex = 0;
            this.BookStore.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bookTitleTextBox
            // 
            this.bookTitleTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitleTextBox.Location = new System.Drawing.Point(168, 212);
            this.bookTitleTextBox.Name = "bookTitleTextBox";
            this.bookTitleTextBox.Size = new System.Drawing.Size(194, 27);
            this.bookTitleTextBox.TabIndex = 1;
            this.bookTitleTextBox.TextChanged += new System.EventHandler(this.bookTitleTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Author Name";
            // 
            // authorNameTextBox
            // 
            this.authorNameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorNameTextBox.Location = new System.Drawing.Point(168, 166);
            this.authorNameTextBox.Name = "authorNameTextBox";
            this.authorNameTextBox.Size = new System.Drawing.Size(194, 27);
            this.authorNameTextBox.TabIndex = 3;
            // 
            // ISBNCodeTextBox
            // 
            this.ISBNCodeTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNCodeTextBox.Location = new System.Drawing.Point(168, 121);
            this.ISBNCodeTextBox.Name = "ISBNCodeTextBox";
            this.ISBNCodeTextBox.Size = new System.Drawing.Size(194, 27);
            this.ISBNCodeTextBox.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(97, 256);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(125, 60);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add Book";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(237, 256);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(125, 60);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete Book";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Book Database";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Search";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(168, 333);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(194, 27);
            this.searchTextBox.TabIndex = 10;
            this.searchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "ISBN Code";
            // 
            // bookCountLabel
            // 
            this.bookCountLabel.AutoSize = true;
            this.bookCountLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookCountLabel.Location = new System.Drawing.Point(70, 87);
            this.bookCountLabel.Name = "bookCountLabel";
            this.bookCountLabel.Size = new System.Drawing.Size(113, 21);
            this.bookCountLabel.TabIndex = 12;
            this.bookCountLabel.Text = "Total Books: 0";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(168, 366);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(89, 35);
            this.searchBtn.TabIndex = 13;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Output";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(120, 407);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(242, 27);
            this.outputTextBox.TabIndex = 14;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(276, 366);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(86, 35);
            this.clearBtn.TabIndex = 16;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.bookCountLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ISBNCodeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.authorNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookTitleTextBox);
            this.Controls.Add(this.BookStore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BookStore;
        private System.Windows.Forms.TextBox bookTitleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox authorNameTextBox;
        private System.Windows.Forms.TextBox ISBNCodeTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label bookCountLabel;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button clearBtn;
    }
}

