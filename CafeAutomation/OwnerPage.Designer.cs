namespace CafeAutomation
{
    partial class Ownerpage
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
            manage_btn = new Button();
            order_btn = new Button();
            in_ex_btn = new Button();
            welcome_lbl = new Label();
            SuspendLayout();
            // 
            // manage_btn
            // 
            manage_btn.Location = new Point(40, 232);
            manage_btn.Name = "manage_btn";
            manage_btn.Size = new Size(150, 100);
            manage_btn.TabIndex = 0;
            manage_btn.Text = "Manage Staff";
            manage_btn.UseVisualStyleBackColor = true;
            manage_btn.Click += manage_btn_Click;
            // 
            // order_btn
            // 
            order_btn.Location = new Point(388, 232);
            order_btn.Name = "order_btn";
            order_btn.Size = new Size(150, 100);
            order_btn.TabIndex = 2;
            order_btn.Text = "Order Product";
            order_btn.UseVisualStyleBackColor = true;
            order_btn.Click += order_btn_Click;
            // 
            // in_ex_btn
            // 
            in_ex_btn.Location = new Point(731, 232);
            in_ex_btn.Name = "in_ex_btn";
            in_ex_btn.Size = new Size(150, 100);
            in_ex_btn.TabIndex = 3;
            in_ex_btn.Text = "Income and Expense";
            in_ex_btn.UseVisualStyleBackColor = true;
            in_ex_btn.Click += in_ex_btn_Click;
            // 
            // welcome_lbl
            // 
            welcome_lbl.AutoSize = true;
            welcome_lbl.Font = new Font("Monotype Corsiva", 14F, FontStyle.Italic, GraphicsUnit.Point, 162);
            welcome_lbl.Location = new Point(40, 42);
            welcome_lbl.Name = "welcome_lbl";
            welcome_lbl.Size = new Size(172, 68);
            welcome_lbl.TabIndex = 4;
            welcome_lbl.Text = "Hello!\r\nNice to see you!";
            // 
            // Ownerpage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 544);
            Controls.Add(welcome_lbl);
            Controls.Add(in_ex_btn);
            Controls.Add(order_btn);
            Controls.Add(manage_btn);
            Name = "Ownerpage";
            Text = "Ownerpage";
            FormClosed += Ownerpage_FormClosed;
            Load += Ownerpage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button manage_btn;
        private Button order_btn;
        private Button in_ex_btn;
        private Label welcome_lbl;
    }
}