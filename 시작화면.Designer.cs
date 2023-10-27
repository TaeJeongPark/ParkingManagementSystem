namespace Project2
{
    partial class 시작화면
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_in = new System.Windows.Forms.Button();
            this.btn_out = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(199, 49);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(498, 118);
            this.btn_in.TabIndex = 0;
            this.btn_in.Text = "입차";
            this.btn_in.UseVisualStyleBackColor = true;
            // 
            // btn_out
            // 
            this.btn_out.Location = new System.Drawing.Point(199, 202);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(498, 118);
            this.btn_out.TabIndex = 0;
            this.btn_out.Text = "출차";
            this.btn_out.UseVisualStyleBackColor = true;
            // 
            // 시작화면
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 370);
            this.Controls.Add(this.btn_out);
            this.Controls.Add(this.btn_in);
            this.Name = "시작화면";
            this.Text = "주차관리시스템";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.Button btn_out;
    }
}

