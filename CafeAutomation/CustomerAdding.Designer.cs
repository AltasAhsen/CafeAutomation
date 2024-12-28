namespace CafeAutomation
{
    partial class customerAdding
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
            name_lbl = new Label();
            surname_lbl = new Label();
            email_lbl = new Label();
            phone_lbl = new Label();
            name_txtbox = new TextBox();
            surname_txtbox = new TextBox();
            email_txtbox = new TextBox();
            phone_txtbox = new TextBox();
            add_btn = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // name_lbl
            // 
            name_lbl.AutoSize = true;
            name_lbl.Location = new Point(14, 32);
            name_lbl.Name = "name_lbl";
            name_lbl.Size = new Size(68, 25);
            name_lbl.TabIndex = 0;
            name_lbl.Text = "Name: ";
            // 
            // surname_lbl
            // 
            surname_lbl.AutoSize = true;
            surname_lbl.Location = new Point(23, 112);
            surname_lbl.Name = "surname_lbl";
            surname_lbl.Size = new Size(91, 25);
            surname_lbl.TabIndex = 1;
            surname_lbl.Text = "Surname: ";
            // 
            // email_lbl
            // 
            email_lbl.AutoSize = true;
            email_lbl.Location = new Point(24, 196);
            email_lbl.Name = "email_lbl";
            email_lbl.Size = new Size(63, 25);
            email_lbl.TabIndex = 2;
            email_lbl.Text = "Email: ";
            // 
            // phone_lbl
            // 
            phone_lbl.AutoSize = true;
            phone_lbl.Location = new Point(29, 279);
            phone_lbl.Name = "phone_lbl";
            phone_lbl.Size = new Size(71, 25);
            phone_lbl.TabIndex = 3;
            phone_lbl.Text = "Phone: ";
            // 
            // name_txtbox
            // 
            name_txtbox.Location = new Point(169, 46);
            name_txtbox.Name = "name_txtbox";
            name_txtbox.Size = new Size(150, 31);
            name_txtbox.TabIndex = 4;
            // 
            // surname_txtbox
            // 
            surname_txtbox.Location = new Point(174, 118);
            surname_txtbox.Name = "surname_txtbox";
            surname_txtbox.Size = new Size(150, 31);
            surname_txtbox.TabIndex = 5;
            // 
            // email_txtbox
            // 
            email_txtbox.Location = new Point(172, 201);
            email_txtbox.Name = "email_txtbox";
            email_txtbox.Size = new Size(147, 31);
            email_txtbox.TabIndex = 6;
            // 
            // phone_txtbox
            // 
            phone_txtbox.Location = new Point(169, 276);
            phone_txtbox.Name = "phone_txtbox";
            phone_txtbox.Size = new Size(150, 31);
            phone_txtbox.TabIndex = 7;
            // 
            // add_btn
            // 
            add_btn.Location = new Point(193, 360);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(112, 34);
            add_btn.TabIndex = 8;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(395, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 225);
            dataGridView1.TabIndex = 11;
            // 
            // customerAdding
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(add_btn);
            Controls.Add(phone_txtbox);
            Controls.Add(email_txtbox);
            Controls.Add(surname_txtbox);
            Controls.Add(name_txtbox);
            Controls.Add(phone_lbl);
            Controls.Add(email_lbl);
            Controls.Add(surname_lbl);
            Controls.Add(name_lbl);
            Name = "customerAdding";
            Text = "customerAdding";
            FormClosed += customerAdding_FormClosed;
            Load += customerAdding_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name_lbl;
        private Label surname_lbl;
        private Label email_lbl;
        private Label phone_lbl;
        private TextBox name_txtbox;
        private TextBox surname_txtbox;
        private TextBox email_txtbox;
        private TextBox phone_txtbox;
        private Button add_btn;
        private DataGridView dataGridView1;
    }
}