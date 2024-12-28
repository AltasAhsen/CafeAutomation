namespace CafeAutomation
{
    partial class customerUpdate
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
            update_btn = new Button();
            email_txtbox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            phone_txtbox = new TextBox();
            dataGridView1 = new DataGridView();
            email_r_btn = new RadioButton();
            phone_r_btn = new RadioButton();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // update_btn
            // 
            update_btn.Location = new Point(142, 328);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(150, 46);
            update_btn.TabIndex = 0;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click;
            // 
            // email_txtbox
            // 
            email_txtbox.Location = new Point(172, 69);
            email_txtbox.Name = "email_txtbox";
            email_txtbox.Size = new Size(150, 31);
            email_txtbox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 72);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 8;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 134);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 9;
            label5.Text = "Phone:";
            // 
            // phone_txtbox
            // 
            phone_txtbox.Location = new Point(172, 131);
            phone_txtbox.Name = "phone_txtbox";
            phone_txtbox.Size = new Size(150, 31);
            phone_txtbox.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(474, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(478, 264);
            dataGridView1.TabIndex = 11;
            // 
            // email_r_btn
            // 
            email_r_btn.AutoSize = true;
            email_r_btn.Checked = true;
            email_r_btn.Location = new Point(15, 45);
            email_r_btn.Name = "email_r_btn";
            email_r_btn.Size = new Size(79, 29);
            email_r_btn.TabIndex = 12;
            email_r_btn.TabStop = true;
            email_r_btn.Text = "Email";
            email_r_btn.UseVisualStyleBackColor = true;
            // 
            // phone_r_btn
            // 
            phone_r_btn.AutoSize = true;
            phone_r_btn.Location = new Point(118, 45);
            phone_r_btn.Name = "phone_r_btn";
            phone_r_btn.Size = new Size(87, 29);
            phone_r_btn.TabIndex = 13;
            phone_r_btn.Text = "Phone";
            phone_r_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(email_r_btn);
            groupBox1.Controls.Add(phone_r_btn);
            groupBox1.Location = new Point(102, 195);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(231, 108);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Which to change?";
            // 
            // customerUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 544);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(phone_txtbox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(email_txtbox);
            Controls.Add(update_btn);
            Name = "customerUpdate";
            Text = "customerUpdate";
            FormClosed += customerUpdate_FormClosed;
            Load += customerUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button update_btn;
        private TextBox email_txtbox;
        private Label label4;
        private Label label5;
        private TextBox phone_txtbox;
        private DataGridView dataGridView1;
        private RadioButton email_r_btn;
        private RadioButton phone_r_btn;
        private GroupBox groupBox1;
    }
}