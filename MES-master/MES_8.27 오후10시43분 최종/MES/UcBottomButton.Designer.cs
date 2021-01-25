namespace MES
{
    partial class UcBottomButton
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(161)))));
            this.btn1.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn1.Location = new System.Drawing.Point(3, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(99, 70);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "소형";
            this.btn1.UseCustomBackColor = true;
            this.btn1.UseCustomForeColor = true;
            this.btn1.UseSelectable = true;
            this.btn1.UseStyleColors = true;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // UcBottomButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn1);
            this.Name = "UcBottomButton";
            this.Size = new System.Drawing.Size(105, 75);
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroButton btn1;
    }
}
