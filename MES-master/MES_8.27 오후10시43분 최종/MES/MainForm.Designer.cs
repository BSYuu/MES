namespace MES
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lbl라인 = new System.Windows.Forms.Label();
            this.lblMini = new System.Windows.Forms.Label();
            this.lbl타이머 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl작업자 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.btn공지사항 = new MetroFramework.Controls.MetroButton();
            this.btn계획대실적 = new MetroFramework.Controls.MetroButton();
            this.btn불량실적조회 = new MetroFramework.Controls.MetroButton();
            this.btn자주검사조회 = new MetroFramework.Controls.MetroButton();
            this.btn상세실적조회 = new MetroFramework.Controls.MetroButton();
            this.btn생산실적조회 = new MetroFramework.Controls.MetroButton();
            this.btn작업현황 = new MetroFramework.Controls.MetroButton();
            this.btn작업지시선택 = new MetroFramework.Controls.MetroButton();
            this.btn새로고침 = new MetroFramework.Controls.MetroButton();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.fpnlBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMinus = new System.Windows.Forms.Label();
            this.lblPlus = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlTop.Controls.Add(this.lbl라인);
            this.pnlTop.Controls.Add(this.lblMini);
            this.pnlTop.Controls.Add(this.lbl타이머);
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Controls.Add(this.lbl작업자);
            this.pnlTop.Controls.Add(this.label4);
            this.pnlTop.Controls.Add(this.lblClose);
            this.pnlTop.Controls.Add(this.btn공지사항);
            this.pnlTop.Controls.Add(this.btn계획대실적);
            this.pnlTop.Controls.Add(this.btn불량실적조회);
            this.pnlTop.Controls.Add(this.btn자주검사조회);
            this.pnlTop.Controls.Add(this.btn상세실적조회);
            this.pnlTop.Controls.Add(this.btn생산실적조회);
            this.pnlTop.Controls.Add(this.btn작업현황);
            this.pnlTop.Controls.Add(this.btn작업지시선택);
            this.pnlTop.Controls.Add(this.btn새로고침);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1100, 120);
            this.pnlTop.TabIndex = 2;
            // 
            // lbl라인
            // 
            this.lbl라인.BackColor = System.Drawing.SystemColors.Control;
            this.lbl라인.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl라인.Location = new System.Drawing.Point(556, 23);
            this.lbl라인.Name = "lbl라인";
            this.lbl라인.Size = new System.Drawing.Size(102, 22);
            this.lbl라인.TabIndex = 40;
            // 
            // lblMini
            // 
            this.lblMini.AutoSize = true;
            this.lblMini.Font = new System.Drawing.Font("HY견고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMini.Location = new System.Drawing.Point(1052, 2);
            this.lblMini.Name = "lblMini";
            this.lblMini.Size = new System.Drawing.Size(19, 16);
            this.lblMini.TabIndex = 39;
            this.lblMini.Text = "-";
            this.lblMini.Click += new System.EventHandler(this.LblMini_Click);
            // 
            // lbl타이머
            // 
            this.lbl타이머.BackColor = System.Drawing.SystemColors.Control;
            this.lbl타이머.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl타이머.Location = new System.Drawing.Point(690, 23);
            this.lbl타이머.Name = "lbl타이머";
            this.lbl타이머.Size = new System.Drawing.Size(161, 22);
            this.lbl타이머.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MES.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(3, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // lbl작업자
            // 
            this.lbl작업자.BackColor = System.Drawing.SystemColors.Control;
            this.lbl작업자.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl작업자.Location = new System.Drawing.Point(192, 23);
            this.lbl작업자.Name = "lbl작업자";
            this.lbl작업자.Size = new System.Drawing.Size(84, 22);
            this.lbl작업자.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("함초롬돋움", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(111, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 29;
            this.label4.Text = "작업자";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("HY견고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblClose.Location = new System.Drawing.Point(1077, 2);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(20, 16);
            this.lblClose.TabIndex = 20;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.LblClose_Click);
            // 
            // btn공지사항
            // 
            this.btn공지사항.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn공지사항.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(130)))), ((int)(((byte)(133)))));
            this.btn공지사항.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn공지사항.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn공지사항.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn공지사항.Location = new System.Drawing.Point(969, 63);
            this.btn공지사항.Name = "btn공지사항";
            this.btn공지사항.Size = new System.Drawing.Size(115, 42);
            this.btn공지사항.TabIndex = 19;
            this.btn공지사항.Text = "공지사항";
            this.btn공지사항.UseCustomBackColor = true;
            this.btn공지사항.UseCustomForeColor = true;
            this.btn공지사항.UseSelectable = true;
            this.btn공지사항.UseStyleColors = true;
            this.btn공지사항.Click += new System.EventHandler(this.TopButton_Click);
            // 
            // btn계획대실적
            // 
            this.btn계획대실적.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn계획대실적.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(130)))), ((int)(((byte)(133)))));
            this.btn계획대실적.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn계획대실적.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn계획대실적.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn계획대실적.Location = new System.Drawing.Point(847, 63);
            this.btn계획대실적.Name = "btn계획대실적";
            this.btn계획대실적.Size = new System.Drawing.Size(115, 42);
            this.btn계획대실적.TabIndex = 18;
            this.btn계획대실적.Text = "계획대실적";
            this.btn계획대실적.UseCustomBackColor = true;
            this.btn계획대실적.UseCustomForeColor = true;
            this.btn계획대실적.UseSelectable = true;
            this.btn계획대실적.UseStyleColors = true;
            this.btn계획대실적.Click += new System.EventHandler(this.TopButton_Click);
            // 
            // btn불량실적조회
            // 
            this.btn불량실적조회.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn불량실적조회.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(130)))), ((int)(((byte)(133)))));
            this.btn불량실적조회.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn불량실적조회.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn불량실적조회.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn불량실적조회.Location = new System.Drawing.Point(725, 63);
            this.btn불량실적조회.Name = "btn불량실적조회";
            this.btn불량실적조회.Size = new System.Drawing.Size(115, 42);
            this.btn불량실적조회.TabIndex = 17;
            this.btn불량실적조회.Text = "불량실적조회";
            this.btn불량실적조회.UseCustomBackColor = true;
            this.btn불량실적조회.UseCustomForeColor = true;
            this.btn불량실적조회.UseSelectable = true;
            this.btn불량실적조회.UseStyleColors = true;
            this.btn불량실적조회.Click += new System.EventHandler(this.TopButton_Click);
            // 
            // btn자주검사조회
            // 
            this.btn자주검사조회.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn자주검사조회.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(130)))), ((int)(((byte)(133)))));
            this.btn자주검사조회.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn자주검사조회.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn자주검사조회.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn자주검사조회.Location = new System.Drawing.Point(603, 63);
            this.btn자주검사조회.Name = "btn자주검사조회";
            this.btn자주검사조회.Size = new System.Drawing.Size(115, 42);
            this.btn자주검사조회.TabIndex = 16;
            this.btn자주검사조회.Text = "자주검사조회";
            this.btn자주검사조회.UseCustomBackColor = true;
            this.btn자주검사조회.UseCustomForeColor = true;
            this.btn자주검사조회.UseSelectable = true;
            this.btn자주검사조회.UseStyleColors = true;
            this.btn자주검사조회.Click += new System.EventHandler(this.TopButton_Click);
            // 
            // btn상세실적조회
            // 
            this.btn상세실적조회.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn상세실적조회.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(130)))), ((int)(((byte)(133)))));
            this.btn상세실적조회.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn상세실적조회.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn상세실적조회.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn상세실적조회.Location = new System.Drawing.Point(358, 63);
            this.btn상세실적조회.Name = "btn상세실적조회";
            this.btn상세실적조회.Size = new System.Drawing.Size(115, 42);
            this.btn상세실적조회.TabIndex = 15;
            this.btn상세실적조회.Text = "생산실적조회";
            this.btn상세실적조회.UseCustomBackColor = true;
            this.btn상세실적조회.UseCustomForeColor = true;
            this.btn상세실적조회.UseSelectable = true;
            this.btn상세실적조회.UseStyleColors = true;
            this.btn상세실적조회.Click += new System.EventHandler(this.TopButton_Click);
            // 
            // btn생산실적조회
            // 
            this.btn생산실적조회.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn생산실적조회.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(130)))), ((int)(((byte)(133)))));
            this.btn생산실적조회.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn생산실적조회.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn생산실적조회.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn생산실적조회.Location = new System.Drawing.Point(482, 63);
            this.btn생산실적조회.Name = "btn생산실적조회";
            this.btn생산실적조회.Size = new System.Drawing.Size(115, 42);
            this.btn생산실적조회.TabIndex = 14;
            this.btn생산실적조회.Text = "상세실적조회";
            this.btn생산실적조회.UseCustomBackColor = true;
            this.btn생산실적조회.UseCustomForeColor = true;
            this.btn생산실적조회.UseSelectable = true;
            this.btn생산실적조회.UseStyleColors = true;
            this.btn생산실적조회.Click += new System.EventHandler(this.TopButton_Click);
            // 
            // btn작업현황
            // 
            this.btn작업현황.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn작업현황.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(130)))), ((int)(((byte)(133)))));
            this.btn작업현황.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn작업현황.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn작업현황.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn작업현황.Location = new System.Drawing.Point(237, 63);
            this.btn작업현황.Name = "btn작업현황";
            this.btn작업현황.Size = new System.Drawing.Size(115, 42);
            this.btn작업현황.TabIndex = 13;
            this.btn작업현황.Text = "작업현황";
            this.btn작업현황.UseCustomBackColor = true;
            this.btn작업현황.UseCustomForeColor = true;
            this.btn작업현황.UseSelectable = true;
            this.btn작업현황.UseStyleColors = true;
            this.btn작업현황.Click += new System.EventHandler(this.TopButton_Click);
            // 
            // btn작업지시선택
            // 
            this.btn작업지시선택.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn작업지시선택.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(130)))), ((int)(((byte)(133)))));
            this.btn작업지시선택.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn작업지시선택.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn작업지시선택.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn작업지시선택.Location = new System.Drawing.Point(115, 63);
            this.btn작업지시선택.Name = "btn작업지시선택";
            this.btn작업지시선택.Size = new System.Drawing.Size(115, 42);
            this.btn작업지시선택.TabIndex = 12;
            this.btn작업지시선택.Text = "작업지시선택";
            this.btn작업지시선택.UseCustomBackColor = true;
            this.btn작업지시선택.UseCustomForeColor = true;
            this.btn작업지시선택.UseSelectable = true;
            this.btn작업지시선택.UseStyleColors = true;
            this.btn작업지시선택.Click += new System.EventHandler(this.TopButton_Click);
            // 
            // btn새로고침
            // 
            this.btn새로고침.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn새로고침.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(130)))), ((int)(((byte)(133)))));
            this.btn새로고침.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn새로고침.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn새로고침.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn새로고침.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn새로고침.Location = new System.Drawing.Point(1, 63);
            this.btn새로고침.Name = "btn새로고침";
            this.btn새로고침.Size = new System.Drawing.Size(107, 42);
            this.btn새로고침.TabIndex = 11;
            this.btn새로고침.Text = "새로고침";
            this.btn새로고침.UseCustomBackColor = true;
            this.btn새로고침.UseCustomForeColor = true;
            this.btn새로고침.UseSelectable = true;
            this.btn새로고침.UseStyleColors = true;
            this.btn새로고침.Click += new System.EventHandler(this.Btn새로고침_Click);
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlMiddle.Location = new System.Drawing.Point(0, 111);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1100, 559);
            this.pnlMiddle.TabIndex = 7;
            // 
            // fpnlBottom
            // 
            this.fpnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.fpnlBottom.Location = new System.Drawing.Point(0, 668);
            this.fpnlBottom.Name = "fpnlBottom";
            this.fpnlBottom.Size = new System.Drawing.Size(1051, 82);
            this.fpnlBottom.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblMinus
            // 
            this.lblMinus.BackColor = System.Drawing.SystemColors.Control;
            this.lblMinus.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMinus.Image = global::MES.Properties.Resources.substract_16;
            this.lblMinus.Location = new System.Drawing.Point(1048, 709);
            this.lblMinus.Name = "lblMinus";
            this.lblMinus.Size = new System.Drawing.Size(52, 41);
            this.lblMinus.TabIndex = 38;
            this.lblMinus.Click += new System.EventHandler(this.LblMinus_Click);
            // 
            // lblPlus
            // 
            this.lblPlus.BackColor = System.Drawing.SystemColors.Control;
            this.lblPlus.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPlus.Image = global::MES.Properties.Resources.add_16;
            this.lblPlus.Location = new System.Drawing.Point(1048, 668);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(52, 41);
            this.lblPlus.TabIndex = 37;
            this.lblPlus.Click += new System.EventHandler(this.LblPlus_Click);
            // 
            // MainForm
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 750);
            this.Controls.Add(this.lblPlus);
            this.Controls.Add(this.lblMinus);
            this.Controls.Add(this.fpnlBottom);
            this.Controls.Add(this.pnlMiddle);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        //private UcBottomButton bottomButton1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblMini;
        private System.Windows.Forms.Label lblMinus;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Label lbl타이머;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroButton btn공지사항;
        private MetroFramework.Controls.MetroButton btn계획대실적;
        private MetroFramework.Controls.MetroButton btn불량실적조회;
        private MetroFramework.Controls.MetroButton btn상세실적조회;
        private MetroFramework.Controls.MetroButton btn생산실적조회;
        private MetroFramework.Controls.MetroButton btn작업현황;
        private MetroFramework.Controls.MetroButton btn작업지시선택;
        private MetroFramework.Controls.MetroButton btn새로고침;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.FlowLayoutPanel fpnlBottom;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl라인;
        private MetroFramework.Controls.MetroButton btn자주검사조회;
        public System.Windows.Forms.Label lblClose;
        public System.Windows.Forms.Label lbl작업자;
    }
}

