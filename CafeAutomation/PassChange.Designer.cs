namespace CafeAutomation
{
    partial class PassChange
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
            curr_pass_lbl = new Label();
            new_pass_lbl = new Label();
            conf_pass_lbl = new Label();
            curr_pass_txtbox = new TextBox();
            new_pass_txtbox = new TextBox();
            conf_pass_txtbox = new TextBox();
            chang_btn = new Button();
            SuspendLayout();
            // 
            // curr_pass_lbl
            // 
            curr_pass_lbl.AutoSize = true;
            curr_pass_lbl.Location = new Point(148, 105);
            curr_pass_lbl.Name = "curr_pass_lbl";
            curr_pass_lbl.Size = new Size(159, 25);
            curr_pass_lbl.TabIndex = 0;
            curr_pass_lbl.Text = "Current Password: ";
            // 
            // new_pass_lbl
            // 
            new_pass_lbl.AutoSize = true;
            new_pass_lbl.Location = new Point(150, 180);
            new_pass_lbl.Name = "new_pass_lbl";
            new_pass_lbl.Size = new Size(136, 25);
            new_pass_lbl.TabIndex = 1;
            new_pass_lbl.Text = "New Password: ";
            // 
            // conf_pass_lbl
            // 
            conf_pass_lbl.AutoSize = true;
            conf_pass_lbl.Location = new Point(148, 264);
            conf_pass_lbl.Name = "conf_pass_lbl";
            conf_pass_lbl.Size = new Size(205, 25);
            conf_pass_lbl.TabIndex = 2;
            conf_pass_lbl.Text = "Confirm New Password: ";
            // 
            // curr_pass_txtbox
            // 
            curr_pass_txtbox.Location = new Point(380, 105);
            curr_pass_txtbox.Name = "curr_pass_txtbox";
            curr_pass_txtbox.Size = new Size(150, 31);
            curr_pass_txtbox.TabIndex = 3;
            // 
            // new_pass_txtbox
            // 
            new_pass_txtbox.Location = new Point(380, 180);
            new_pass_txtbox.Name = "new_pass_txtbox";
            new_pass_txtbox.Size = new Size(150, 31);
            new_pass_txtbox.TabIndex = 4;
            // 
            // conf_pass_txtbox
            // 
            conf_pass_txtbox.Location = new Point(380, 264);
            conf_pass_txtbox.Name = "conf_pass_txtbox";
            conf_pass_txtbox.Size = new Size(150, 31);
            conf_pass_txtbox.TabIndex = 5;
            // 
            // chang_btn
            // 
            chang_btn.Location = new Point(380, 353);
            chang_btn.Name = "chang_btn";
            chang_btn.Size = new Size(140, 61);
            chang_btn.TabIndex = 6;
            chang_btn.Text = "Change";
            chang_btn.UseVisualStyleBackColor = true;
            chang_btn.Click += chang_btn_Click;
            // 
            // PassChange
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chang_btn);
            Controls.Add(conf_pass_txtbox);
            Controls.Add(new_pass_txtbox);
            Controls.Add(curr_pass_txtbox);
            Controls.Add(conf_pass_lbl);
            Controls.Add(new_pass_lbl);
            Controls.Add(curr_pass_lbl);
            Name = "PassChange";
            Text = "PassChange";
            FormClosed += PassChange_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label curr_pass_lbl;
        private Label new_pass_lbl;
        private Label conf_pass_lbl;
        private TextBox curr_pass_txtbox;
        private TextBox new_pass_txtbox;
        private TextBox conf_pass_txtbox;
        private Button chang_btn;
    }
}