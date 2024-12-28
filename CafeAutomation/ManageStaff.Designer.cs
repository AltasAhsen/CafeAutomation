namespace CafeAutomation
{
    partial class ManageStaff
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
            dataGridView1 = new DataGridView();
            id_txtbox = new TextBox();
            id_lbl = new Label();
            position_lbl = new Label();
            name_lbl = new Label();
            surname_lbl = new Label();
            position_txtbox = new TextBox();
            name_txtbox = new TextBox();
            surname_txtbox = new TextBox();
            hire_btn = new Button();
            fire_btn = new Button();
            gen_f_r_btn = new RadioButton();
            gen_m_r_btn = new RadioButton();
            gen_lbl = new Label();
            gender_group = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gender_group.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(455, 225);
            dataGridView1.TabIndex = 0;
            // 
            // id_txtbox
            // 
            id_txtbox.Location = new Point(572, 65);
            id_txtbox.Name = "id_txtbox";
            id_txtbox.Size = new Size(183, 31);
            id_txtbox.TabIndex = 1;
            // 
            // id_lbl
            // 
            id_lbl.AutoSize = true;
            id_lbl.Location = new Point(480, 68);
            id_lbl.Name = "id_lbl";
            id_lbl.Size = new Size(39, 25);
            id_lbl.TabIndex = 2;
            id_lbl.Text = "ID: ";
            // 
            // position_lbl
            // 
            position_lbl.AutoSize = true;
            position_lbl.Location = new Point(477, 116);
            position_lbl.Name = "position_lbl";
            position_lbl.Size = new Size(84, 25);
            position_lbl.TabIndex = 3;
            position_lbl.Text = "Position: ";
            // 
            // name_lbl
            // 
            name_lbl.AutoSize = true;
            name_lbl.Location = new Point(480, 174);
            name_lbl.Name = "name_lbl";
            name_lbl.Size = new Size(63, 25);
            name_lbl.TabIndex = 4;
            name_lbl.Text = "Name:";
            // 
            // surname_lbl
            // 
            surname_lbl.AutoSize = true;
            surname_lbl.Location = new Point(477, 238);
            surname_lbl.Name = "surname_lbl";
            surname_lbl.Size = new Size(91, 25);
            surname_lbl.TabIndex = 5;
            surname_lbl.Text = "Surname: ";
            // 
            // position_txtbox
            // 
            position_txtbox.Location = new Point(572, 113);
            position_txtbox.Name = "position_txtbox";
            position_txtbox.Size = new Size(183, 31);
            position_txtbox.TabIndex = 6;
            // 
            // name_txtbox
            // 
            name_txtbox.Location = new Point(572, 171);
            name_txtbox.Name = "name_txtbox";
            name_txtbox.Size = new Size(183, 31);
            name_txtbox.TabIndex = 7;
            // 
            // surname_txtbox
            // 
            surname_txtbox.Location = new Point(572, 235);
            surname_txtbox.Name = "surname_txtbox";
            surname_txtbox.Size = new Size(183, 31);
            surname_txtbox.TabIndex = 8;
            // 
            // hire_btn
            // 
            hire_btn.Location = new Point(477, 350);
            hire_btn.Name = "hire_btn";
            hire_btn.Size = new Size(112, 34);
            hire_btn.TabIndex = 9;
            hire_btn.Text = "Hire";
            hire_btn.UseVisualStyleBackColor = true;
            hire_btn.Click += hire_btn_Click;
            // 
            // fire_btn
            // 
            fire_btn.Location = new Point(643, 350);
            fire_btn.Name = "fire_btn";
            fire_btn.Size = new Size(112, 34);
            fire_btn.TabIndex = 10;
            fire_btn.Text = "Fire";
            fire_btn.UseVisualStyleBackColor = true;
            fire_btn.Click += fire_btn_Click;
            // 
            // gen_f_r_btn
            // 
            gen_f_r_btn.AutoSize = true;
            gen_f_r_btn.Location = new Point(6, 20);
            gen_f_r_btn.Name = "gen_f_r_btn";
            gen_f_r_btn.Size = new Size(93, 29);
            gen_f_r_btn.TabIndex = 11;
            gen_f_r_btn.TabStop = true;
            gen_f_r_btn.Text = "Female";
            gen_f_r_btn.UseVisualStyleBackColor = true;
            // 
            // gen_m_r_btn
            // 
            gen_m_r_btn.AutoSize = true;
            gen_m_r_btn.Location = new Point(116, 20);
            gen_m_r_btn.Name = "gen_m_r_btn";
            gen_m_r_btn.Size = new Size(75, 29);
            gen_m_r_btn.TabIndex = 12;
            gen_m_r_btn.TabStop = true;
            gen_m_r_btn.Text = "Male";
            gen_m_r_btn.UseVisualStyleBackColor = true;
            // 
            // gen_lbl
            // 
            gen_lbl.AutoSize = true;
            gen_lbl.Location = new Point(480, 293);
            gen_lbl.Name = "gen_lbl";
            gen_lbl.Size = new Size(78, 25);
            gen_lbl.TabIndex = 13;
            gen_lbl.Text = "Gender: ";
            // 
            // gender_group
            // 
            gender_group.Controls.Add(gen_f_r_btn);
            gender_group.Controls.Add(gen_m_r_btn);
            gender_group.Location = new Point(564, 272);
            gender_group.Name = "gender_group";
            gender_group.Size = new Size(204, 61);
            gender_group.TabIndex = 14;
            gender_group.TabStop = false;
            // 
            // ManageStaff
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gender_group);
            Controls.Add(gen_lbl);
            Controls.Add(fire_btn);
            Controls.Add(hire_btn);
            Controls.Add(surname_txtbox);
            Controls.Add(name_txtbox);
            Controls.Add(position_txtbox);
            Controls.Add(surname_lbl);
            Controls.Add(name_lbl);
            Controls.Add(position_lbl);
            Controls.Add(id_lbl);
            Controls.Add(id_txtbox);
            Controls.Add(dataGridView1);
            Name = "ManageStaff";
            Text = "ManageStaff";
            FormClosed += ManageStaff_FormClosed;
            Load += ManageStaff_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gender_group.ResumeLayout(false);
            gender_group.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox id_txtbox;
        private Label id_lbl;
        private Label position_lbl;
        private Label name_lbl;
        private Label surname_lbl;
        private TextBox position_txtbox;
        private TextBox name_txtbox;
        private TextBox surname_txtbox;
        private Button hire_btn;
        private Button fire_btn;
        private RadioButton gen_f_r_btn;
        private RadioButton gen_m_r_btn;
        private Label gen_lbl;
        private GroupBox gender_group;
    }
}