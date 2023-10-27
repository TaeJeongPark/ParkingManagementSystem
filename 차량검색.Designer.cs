namespace Project2
{
    partial class 차량검색
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
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(387, 38);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(170, 66);
            this.btn_search.TabIndex = 18;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(42, 76);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(323, 28);
            this.tb_num.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "차량번호 4자리를 입력하세요";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 차량검색
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 152);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_num);
            this.Controls.Add(this.label1);
            this.Name = "차량검색";
            this.Text = "차량검색";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.Label label1;
    }
}