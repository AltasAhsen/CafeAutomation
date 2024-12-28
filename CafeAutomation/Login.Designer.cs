namespace CafeAutomation
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            welcome_lbl = new Label();
            pictureBox1 = new PictureBox();
            id_txtbox = new TextBox();
            pass_txtbox = new TextBox();
            login_lbl = new Label();
            id_lbl = new Label();
            pass_lbl = new Label();
            login_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(welcome_lbl);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(478, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 544);
            panel1.TabIndex = 0;
            // 
            // welcome_lbl
            // 
            welcome_lbl.AutoSize = true;
            welcome_lbl.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 162);
            welcome_lbl.Location = new Point(148, 363);
            welcome_lbl.Name = "welcome_lbl";
            welcome_lbl.Size = new Size(236, 57);
            welcome_lbl.TabIndex = 1;
            welcome_lbl.Text = "Central Cafe";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(84, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 250);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // id_txtbox
            // 
            id_txtbox.Location = new Point(203, 166);
            id_txtbox.Name = "id_txtbox";
            id_txtbox.Size = new Size(150, 31);
            id_txtbox.TabIndex = 1;
            // 
            // pass_txtbox
            // 
            pass_txtbox.Location = new Point(203, 243);
            pass_txtbox.Name = "pass_txtbox";
            pass_txtbox.Size = new Size(150, 31);
            pass_txtbox.TabIndex = 2;
            // 
            // login_lbl
            // 
            login_lbl.AutoSize = true;
            login_lbl.Font = new Font("Monotype Corsiva", 20F, FontStyle.Italic, GraphicsUnit.Point, 162);
            login_lbl.Location = new Point(139, 65);
            login_lbl.Name = "login_lbl";
            login_lbl.Size = new Size(183, 49);
            login_lbl.TabIndex = 3;
            login_lbl.Text = "Login Page";
            // 
            // id_lbl
            // 
            id_lbl.AutoSize = true;
            id_lbl.Font = new Font("Arial Narrow", 10F, FontStyle.Italic, GraphicsUnit.Point, 162);
            id_lbl.Location = new Point(117, 172);
            id_lbl.Name = "id_lbl";
            id_lbl.Size = new Size(36, 24);
            id_lbl.TabIndex = 4;
            id_lbl.Text = "ID: ";
            // 
            // pass_lbl
            // 
            pass_lbl.AutoSize = true;
            pass_lbl.Font = new Font("Arial Narrow", 10F, FontStyle.Italic, GraphicsUnit.Point, 162);
            pass_lbl.Location = new Point(84, 243);
            pass_lbl.Name = "pass_lbl";
            pass_lbl.Size = new Size(91, 24);
            pass_lbl.TabIndex = 5;
            pass_lbl.Text = "Password: ";
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.MistyRose;
            login_btn.Location = new Point(220, 322);
            login_btn.Margin = new Padding(0);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(112, 62);
            login_btn.TabIndex = 6;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 544);
            Controls.Add(login_btn);
            Controls.Add(pass_lbl);
            Controls.Add(id_lbl);
            Controls.Add(login_lbl);
            Controls.Add(pass_txtbox);
            Controls.Add(id_txtbox);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login Page";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label welcome_lbl;
        private TextBox id_txtbox;
        private TextBox pass_txtbox;
        private Label login_lbl;
        private Label id_lbl;
        private Label pass_lbl;
        private Button login_btn;
    }
}
