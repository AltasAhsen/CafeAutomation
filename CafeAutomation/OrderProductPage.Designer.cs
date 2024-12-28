namespace CafeAutomation
{
    partial class OrderProductPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderProductPage));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            bean_num = new NumericUpDown();
            label0 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            milk_num = new NumericUpDown();
            soy_milk_num = new NumericUpDown();
            alm_milk_num = new NumericUpDown();
            ord_btn = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bean_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)milk_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)soy_milk_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alm_milk_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(76, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(305, 60);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(523, 60);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 100);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(751, 60);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 100);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // bean_num
            // 
            bean_num.Location = new Point(76, 220);
            bean_num.Name = "bean_num";
            bean_num.Size = new Size(100, 31);
            bean_num.TabIndex = 5;
            // 
            // label0
            // 
            label0.AutoSize = true;
            label0.Location = new Point(53, 181);
            label0.Name = "label0";
            label0.Size = new Size(164, 25);
            label0.TabIndex = 6;
            label0.Text = "Coffee Bean - 300₺";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 181);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 7;
            label1.Text = "Regular Milk - 25₺";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(512, 181);
            label2.Name = "label2";
            label2.Size = new Size(127, 25);
            label2.TabIndex = 8;
            label2.Text = "Soy Milk - 40₺";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(722, 181);
            label3.Name = "label3";
            label3.Size = new Size(161, 25);
            label3.TabIndex = 9;
            label3.Text = "Almond Milk - 50₺";
            // 
            // milk_num
            // 
            milk_num.Location = new Point(305, 220);
            milk_num.Name = "milk_num";
            milk_num.Size = new Size(100, 31);
            milk_num.TabIndex = 10;
            // 
            // soy_milk_num
            // 
            soy_milk_num.Location = new Point(523, 220);
            soy_milk_num.Name = "soy_milk_num";
            soy_milk_num.Size = new Size(100, 31);
            soy_milk_num.TabIndex = 11;
            // 
            // alm_milk_num
            // 
            alm_milk_num.Location = new Point(751, 220);
            alm_milk_num.Name = "alm_milk_num";
            alm_milk_num.Size = new Size(100, 31);
            alm_milk_num.TabIndex = 12;
            // 
            // ord_btn
            // 
            ord_btn.Location = new Point(751, 336);
            ord_btn.Name = "ord_btn";
            ord_btn.Size = new Size(100, 50);
            ord_btn.TabIndex = 21;
            ord_btn.Text = "Order";
            ord_btn.UseVisualStyleBackColor = true;
            ord_btn.Click += ord_btn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 293);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(586, 225);
            dataGridView1.TabIndex = 22;
            // 
            // OrderProductPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(978, 544);
            Controls.Add(dataGridView1);
            Controls.Add(ord_btn);
            Controls.Add(alm_milk_num);
            Controls.Add(soy_milk_num);
            Controls.Add(milk_num);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label0);
            Controls.Add(bean_num);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "OrderProductPage";
            Text = "OrderProductPage";
            FormClosed += OrderProductPage_FormClosed;
            Load += OrderProductPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)bean_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)milk_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)soy_milk_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)alm_milk_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private NumericUpDown bean_num;
        private Label label0;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown milk_num;
        private NumericUpDown soy_milk_num;
        private NumericUpDown alm_milk_num;
        private Button ord_btn;
        private DataGridView dataGridView1;
    }
}