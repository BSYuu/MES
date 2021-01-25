namespace MES
{
    partial class MakeButtonForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.btn확인 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx분류형태 = new MetroFramework.Controls.MetroComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Controls.Add(this.btn확인);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbx분류형태);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 522);
            this.panel1.TabIndex = 1;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("HY견고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblClose.Location = new System.Drawing.Point(541, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(20, 16);
            this.lblClose.TabIndex = 40;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.LblClose_Click);
            // 
            // btn확인
            // 
            this.btn확인.Location = new System.Drawing.Point(262, 113);
            this.btn확인.Name = "btn확인";
            this.btn확인.Size = new System.Drawing.Size(90, 29);
            this.btn확인.TabIndex = 2;
            this.btn확인.Text = "확인";
            this.btn확인.UseSelectable = true;
            this.btn확인.Click += new System.EventHandler(this.Btn확인_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("함초롬돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(182, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "분류 추가";
            // 
            // cbx분류형태
            // 
            this.cbx분류형태.FormattingEnabled = true;
            this.cbx분류형태.ItemHeight = 23;
            this.cbx분류형태.Items.AddRange(new object[] {
            "소형라인",
            "중형라인",
            "대형라인",
            "인라인",
            "수작업",
            "전체"});
            this.cbx분류형태.Location = new System.Drawing.Point(114, 113);
            this.cbx분류형태.Name = "cbx분류형태";
            this.cbx분류형태.Size = new System.Drawing.Size(121, 29);
            this.cbx분류형태.TabIndex = 0;
            this.cbx분류형태.UseSelectable = true;
            // 
            // MakeButtonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 522);
            this.Controls.Add(this.panel1);
            this.Name = "MakeButtonForm";
            this.Text = "MakeButtonForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton btn확인;
        public System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox cbx분류형태;
        private System.Windows.Forms.Label lblClose;
    }
}