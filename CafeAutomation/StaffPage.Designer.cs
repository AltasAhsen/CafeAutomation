namespace CafeAutomation
{
    partial class StaffPage
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
            add_cust_btn = new Button();
            order_btn = new Button();
            pass_chang_btn = new Button();
            welcome_lbl = new Label();
            update_cust = new Button();
            SuspendLayout();
            // 
            // add_cust_btn
            // 
            add_cust_btn.Location = new Point(100, 190);
            add_cust_btn.Name = "add_cust_btn";
            add_cust_btn.Size = new Size(121, 97);
            add_cust_btn.TabIndex = 0;
            add_cust_btn.Text = "Add Customer";
            add_cust_btn.UseVisualStyleBackColor = true;
            add_cust_btn.Click += add_cust_btn_Click;
            // 
            // order_btn
            // 
            order_btn.Location = new Point(536, 190);
            order_btn.Name = "order_btn";
            order_btn.Size = new Size(106, 97);
            order_btn.TabIndex = 1;
            order_btn.Text = "Take Order";
            order_btn.UseVisualStyleBackColor = true;
            order_btn.Click += order_btn_Click;
            // 
            // pass_chang_btn
            // 
            pass_chang_btn.Location = new Point(746, 190);
            pass_chang_btn.Name = "pass_chang_btn";
            pass_chang_btn.Size = new Size(112, 97);
            pass_chang_btn.TabIndex = 2;
            pass_chang_btn.Text = "Change password";
            pass_chang_btn.UseVisualStyleBackColor = true;
            pass_chang_btn.Click += pass_chang_btn_Click;
            // 
            // welcome_lbl
            // 
            welcome_lbl.AutoSize = true;
            welcome_lbl.Font = new Font("Monotype Corsiva", 14F, FontStyle.Italic, GraphicsUnit.Point, 162);
            welcome_lbl.Location = new Point(59, 56);
            welcome_lbl.Name = "welcome_lbl";
            welcome_lbl.Size = new Size(113, 34);
            welcome_lbl.TabIndex = 3;
            welcome_lbl.Text = "Welcome!";
            // 
            // update_cust
            // 
            update_cust.Location = new Point(328, 190);
            update_cust.Name = "update_cust";
            update_cust.Size = new Size(112, 97);
            update_cust.TabIndex = 4;
            update_cust.Text = "Update Customer";
            update_cust.UseVisualStyleBackColor = true;
            update_cust.Click += update_cust_Click;
            // 
            // StaffPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 544);
            Controls.Add(update_cust);
            Controls.Add(welcome_lbl);
            Controls.Add(pass_chang_btn);
            Controls.Add(order_btn);
            Controls.Add(add_cust_btn);
            Name = "StaffPage";
            FormClosed += StaffPage_FormClosed;
            Load += StaffPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add_cust_btn;
        private Button order_btn;
        private Button pass_chang_btn;
        private Label welcome_lbl;
        private Button update_cust;
    }
}