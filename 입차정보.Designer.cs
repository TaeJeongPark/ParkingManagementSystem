namespace Project2
{
    partial class 입차정보
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
            this.btn_in = new System.Windows.Forms.Button();
            this.cho_in = new System.Windows.Forms.ComboBox();
            this.bun_in = new System.Windows.Forms.ComboBox();
            this.si_in = new System.Windows.Forms.ComboBox();
            this.date_in = new System.Windows.Forms.DateTimePicker();
            this.tb_car = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(709, 295);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(170, 53);
            this.btn_in.TabIndex = 31;
            this.btn_in.Text = "입차정보";
            this.btn_in.UseVisualStyleBackColor = true;
            // 
            // cho_in
            // 
            this.cho_in.FormattingEnabled = true;
            this.cho_in.Location = new System.Drawing.Point(797, 134);
            this.cho_in.Name = "cho_in";
            this.cho_in.Size = new System.Drawing.Size(82, 26);
            this.cho_in.TabIndex = 26;
            // 
            // bun_in
            // 
            this.bun_in.FormattingEnabled = true;
            this.bun_in.Location = new System.Drawing.Point(709, 134);
            this.bun_in.Name = "bun_in";
            this.bun_in.Size = new System.Drawing.Size(82, 26);
            this.bun_in.TabIndex = 28;
            // 
            // si_in
            // 
            this.si_in.FormattingEnabled = true;
            this.si_in.Location = new System.Drawing.Point(621, 134);
            this.si_in.Name = "si_in";
            this.si_in.Size = new System.Drawing.Size(82, 26);
            this.si_in.TabIndex = 30;
            // 
            // date_in
            // 
            this.date_in.Location = new System.Drawing.Point(621, 78);
            this.date_in.Name = "date_in";
            this.date_in.Size = new System.Drawing.Size(258, 28);
            this.date_in.TabIndex = 24;
            // 
            // tb_car
            // 
            this.tb_car.Location = new System.Drawing.Point(621, 23);
            this.tb_car.Name = "tb_car";
            this.tb_car.Size = new System.Drawing.Size(258, 28);
            this.tb_car.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(501, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "입차날짜:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(501, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "입차날짜:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(501, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "차량번호:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 325);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // 입차정보
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 370);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.cho_in);
            this.Controls.Add(this.bun_in);
            this.Controls.Add(this.si_in);
            this.Controls.Add(this.date_in);
            this.Controls.Add(this.tb_car);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "입차정보";
            this.Text = "입차정보";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.ComboBox cho_in;
        private System.Windows.Forms.ComboBox bun_in;
        private System.Windows.Forms.ComboBox si_in;
        private System.Windows.Forms.DateTimePicker date_in;
        private System.Windows.Forms.TextBox tb_car;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}