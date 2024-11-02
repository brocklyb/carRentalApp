namespace LibraryApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox_allBooks = new ListBox();
            button1 = new Button();
            userInput_searchBook = new TextBox();
            label1 = new Label();
            listView_searchResults = new ListView();
            SuspendLayout();
            // 
            // listBox_allBooks
            // 
            listBox_allBooks.FormattingEnabled = true;
            listBox_allBooks.ItemHeight = 15;
            listBox_allBooks.Items.AddRange(new object[] { "Moby Dick", "Misery", "Elder Scrolls" });
            listBox_allBooks.Location = new Point(410, 49);
            listBox_allBooks.Name = "listBox_allBooks";
            listBox_allBooks.Size = new Size(316, 169);
            listBox_allBooks.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(28, 89);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // userInput_searchBook
            // 
            userInput_searchBook.Location = new Point(28, 49);
            userInput_searchBook.Name = "userInput_searchBook";
            userInput_searchBook.Size = new Size(324, 23);
            userInput_searchBook.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 31);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 3;
            label1.Text = "Search by name of book";
            // 
            // listView_searchResults
            // 
            listView_searchResults.Location = new Point(410, 235);
            listView_searchResults.Name = "listView_searchResults";
            listView_searchResults.Size = new Size(316, 98);
            listView_searchResults.TabIndex = 4;
            listView_searchResults.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView_searchResults);
            Controls.Add(label1);
            Controls.Add(userInput_searchBook);
            Controls.Add(button1);
            Controls.Add(listBox_allBooks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox_allBooks;
        private Button button1;
        private TextBox userInput_searchBook;
        private Label label1;
        private ListView listView_searchResults;
    }
}
