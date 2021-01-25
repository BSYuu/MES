namespace MES
{
    partial class Detailperform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPerformDate = new System.Windows.Forms.Label();
            this.lblManageNum = new System.Windows.Forms.Label();
            this.lblProductionNum = new System.Windows.Forms.Label();
            this.lblEmployeeNum = new System.Windows.Forms.Label();
            this.btn조회 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx관리번호 = new MetroFramework.Controls.MetroTextBox();
            this.tbx사원번호 = new MetroFramework.Controls.MetroTextBox();
            this.grid상세실적조회 = new MetroFramework.Controls.MetroGrid();
            this.lblTilde2 = new System.Windows.Forms.Label();
            this.tbx제품번호 = new MetroFramework.Controls.MetroTextBox();
            this.dtFirst = new System.Windows.Forms.DateTimePicker();
            this.dtLast = new System.Windows.Forms.DateTimePicker();
            this.관리번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.제품번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.실적수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.불량수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.공정명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.작업자 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.등록시간 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbb공정 = new MetroFramework.Controls.MetroComboBox();
            this.lblShop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid상세실적조회)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPerformDate
            // 
            this.lblPerformDate.BackColor = System.Drawing.Color.Gray;
            this.lblPerformDate.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPerformDate.ForeColor = System.Drawing.Color.White;
            this.lblPerformDate.Location = new System.Drawing.Point(2, 94);
            this.lblPerformDate.Name = "lblPerformDate";
            this.lblPerformDate.Size = new System.Drawing.Size(97, 32);
            this.lblPerformDate.TabIndex = 35;
            this.lblPerformDate.Text = "실 적 일";
            this.lblPerformDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManageNum
            // 
            this.lblManageNum.BackColor = System.Drawing.Color.Gray;
            this.lblManageNum.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblManageNum.ForeColor = System.Drawing.Color.White;
            this.lblManageNum.Location = new System.Drawing.Point(2, 32);
            this.lblManageNum.Name = "lblManageNum";
            this.lblManageNum.Size = new System.Drawing.Size(97, 30);
            this.lblManageNum.TabIndex = 34;
            this.lblManageNum.Text = "관리번호";
            this.lblManageNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductionNum
            // 
            this.lblProductionNum.BackColor = System.Drawing.Color.Gray;
            this.lblProductionNum.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProductionNum.ForeColor = System.Drawing.Color.White;
            this.lblProductionNum.Location = new System.Drawing.Point(2, 62);
            this.lblProductionNum.Name = "lblProductionNum";
            this.lblProductionNum.Size = new System.Drawing.Size(97, 32);
            this.lblProductionNum.TabIndex = 57;
            this.lblProductionNum.Text = "품번";
            this.lblProductionNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmployeeNum
            // 
            this.lblEmployeeNum.BackColor = System.Drawing.Color.Gray;
            this.lblEmployeeNum.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblEmployeeNum.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeNum.Location = new System.Drawing.Point(360, 32);
            this.lblEmployeeNum.Name = "lblEmployeeNum";
            this.lblEmployeeNum.Size = new System.Drawing.Size(108, 30);
            this.lblEmployeeNum.TabIndex = 60;
            this.lblEmployeeNum.Text = "사원번호";
            this.lblEmployeeNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn조회
            // 
            this.btn조회.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(161)))));
            this.btn조회.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn조회.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn조회.Highlight = true;
            this.btn조회.Location = new System.Drawing.Point(979, 66);
            this.btn조회.Name = "btn조회";
            this.btn조회.Size = new System.Drawing.Size(118, 57);
            this.btn조회.TabIndex = 66;
            this.btn조회.Text = "조회";
            this.btn조회.UseCustomBackColor = true;
            this.btn조회.UseCustomForeColor = true;
            this.btn조회.UseSelectable = true;
            this.btn조회.UseStyleColors = true;
            this.btn조회.Click += new System.EventHandler(this.Btn조회_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("함초롬돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(145, 27);
            this.label1.TabIndex = 67;
            this.label1.Text = "생산실적조회";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // tbx관리번호
            // 
            // 
            // 
            // 
            this.tbx관리번호.CustomButton.Image = null;
            this.tbx관리번호.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.tbx관리번호.CustomButton.Name = "";
            this.tbx관리번호.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbx관리번호.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx관리번호.CustomButton.TabIndex = 1;
            this.tbx관리번호.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx관리번호.CustomButton.UseSelectable = true;
            this.tbx관리번호.CustomButton.Visible = false;
            this.tbx관리번호.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbx관리번호.Lines = new string[0];
            this.tbx관리번호.Location = new System.Drawing.Point(100, 34);
            this.tbx관리번호.MaxLength = 32767;
            this.tbx관리번호.Name = "tbx관리번호";
            this.tbx관리번호.PasswordChar = '\0';
            this.tbx관리번호.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbx관리번호.SelectedText = "";
            this.tbx관리번호.SelectionLength = 0;
            this.tbx관리번호.SelectionStart = 0;
            this.tbx관리번호.ShortcutsEnabled = true;
            this.tbx관리번호.Size = new System.Drawing.Size(233, 23);
            this.tbx관리번호.TabIndex = 68;
            this.tbx관리번호.UseSelectable = true;
            this.tbx관리번호.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx관리번호.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbx사원번호
            // 
            // 
            // 
            // 
            this.tbx사원번호.CustomButton.Image = null;
            this.tbx사원번호.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.tbx사원번호.CustomButton.Name = "";
            this.tbx사원번호.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbx사원번호.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx사원번호.CustomButton.TabIndex = 1;
            this.tbx사원번호.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx사원번호.CustomButton.UseSelectable = true;
            this.tbx사원번호.CustomButton.Visible = false;
            this.tbx사원번호.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbx사원번호.Lines = new string[0];
            this.tbx사원번호.Location = new System.Drawing.Point(469, 36);
            this.tbx사원번호.MaxLength = 32767;
            this.tbx사원번호.Name = "tbx사원번호";
            this.tbx사원번호.PasswordChar = '\0';
            this.tbx사원번호.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbx사원번호.SelectedText = "";
            this.tbx사원번호.SelectionLength = 0;
            this.tbx사원번호.SelectionStart = 0;
            this.tbx사원번호.ShortcutsEnabled = true;
            this.tbx사원번호.Size = new System.Drawing.Size(198, 23);
            this.tbx사원번호.TabIndex = 71;
            this.tbx사원번호.UseSelectable = true;
            this.tbx사원번호.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx사원번호.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // grid상세실적조회
            // 
            this.grid상세실적조회.AllowUserToResizeRows = false;
            this.grid상세실적조회.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid상세실적조회.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid상세실적조회.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid상세실적조회.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid상세실적조회.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid상세실적조회.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grid상세실적조회.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid상세실적조회.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.관리번호,
            this.제품번호,
            this.실적수량,
            this.불량수량,
            this.공정명,
            this.작업자,
            this.등록시간});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid상세실적조회.DefaultCellStyle = dataGridViewCellStyle8;
            this.grid상세실적조회.EnableHeadersVisualStyles = false;
            this.grid상세실적조회.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid상세실적조회.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid상세실적조회.Location = new System.Drawing.Point(0, 145);
            this.grid상세실적조회.Name = "grid상세실적조회";
            this.grid상세실적조회.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid상세실적조회.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grid상세실적조회.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid상세실적조회.RowTemplate.Height = 23;
            this.grid상세실적조회.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid상세실적조회.Size = new System.Drawing.Size(1094, 406);
            this.grid상세실적조회.TabIndex = 73;
            // 
            // lblTilde2
            // 
            this.lblTilde2.AutoSize = true;
            this.lblTilde2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTilde2.Location = new System.Drawing.Point(333, 113);
            this.lblTilde2.Name = "lblTilde2";
            this.lblTilde2.Size = new System.Drawing.Size(20, 16);
            this.lblTilde2.TabIndex = 93;
            this.lblTilde2.Text = "~";
            // 
            // tbx제품번호
            // 
            // 
            // 
            // 
            this.tbx제품번호.CustomButton.Image = null;
            this.tbx제품번호.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.tbx제품번호.CustomButton.Name = "";
            this.tbx제품번호.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbx제품번호.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx제품번호.CustomButton.TabIndex = 1;
            this.tbx제품번호.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx제품번호.CustomButton.UseSelectable = true;
            this.tbx제품번호.CustomButton.Visible = false;
            this.tbx제품번호.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbx제품번호.Lines = new string[0];
            this.tbx제품번호.Location = new System.Drawing.Point(100, 69);
            this.tbx제품번호.MaxLength = 32767;
            this.tbx제품번호.Name = "tbx제품번호";
            this.tbx제품번호.PasswordChar = '\0';
            this.tbx제품번호.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbx제품번호.SelectedText = "";
            this.tbx제품번호.SelectionLength = 0;
            this.tbx제품번호.SelectionStart = 0;
            this.tbx제품번호.ShortcutsEnabled = true;
            this.tbx제품번호.Size = new System.Drawing.Size(233, 23);
            this.tbx제품번호.TabIndex = 69;
            this.tbx제품번호.UseSelectable = true;
            this.tbx제품번호.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx제품번호.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtFirst
            // 
            this.dtFirst.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtFirst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFirst.Location = new System.Drawing.Point(105, 94);
            this.dtFirst.Name = "dtFirst";
            this.dtFirst.Size = new System.Drawing.Size(199, 29);
            this.dtFirst.TabIndex = 94;
            // 
            // dtLast
            // 
            this.dtLast.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtLast.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtLast.Location = new System.Drawing.Point(384, 94);
            this.dtLast.Name = "dtLast";
            this.dtLast.Size = new System.Drawing.Size(200, 29);
            this.dtLast.TabIndex = 95;
            // 
            // 관리번호
            // 
            this.관리번호.HeaderText = "관리번호";
            this.관리번호.Name = "관리번호";
            // 
            // 제품번호
            // 
            this.제품번호.HeaderText = "제품번호";
            this.제품번호.Name = "제품번호";
            // 
            // 실적수량
            // 
            this.실적수량.HeaderText = "실적수량";
            this.실적수량.Name = "실적수량";
            // 
            // 불량수량
            // 
            this.불량수량.HeaderText = "불량수량";
            this.불량수량.Name = "불량수량";
            // 
            // 공정명
            // 
            this.공정명.HeaderText = "공정명";
            this.공정명.Name = "공정명";
            // 
            // 작업자
            // 
            this.작업자.HeaderText = "작업자";
            this.작업자.Name = "작업자";
            // 
            // 등록시간
            // 
            this.등록시간.HeaderText = "등록시간";
            this.등록시간.Name = "등록시간";
            // 
            // cbb공정
            // 
            this.cbb공정.FormattingEnabled = true;
            this.cbb공정.ItemHeight = 23;
            this.cbb공정.Items.AddRange(new object[] {
            " ",
            "절단",
            "벤딩",
            "드릴",
            "용접"});
            this.cbb공정.Location = new System.Drawing.Point(779, 32);
            this.cbb공정.Name = "cbb공정";
            this.cbb공정.Size = new System.Drawing.Size(151, 29);
            this.cbb공정.TabIndex = 97;
            this.cbb공정.UseSelectable = true;
            // 
            // lblShop
            // 
            this.lblShop.BackColor = System.Drawing.Color.Gray;
            this.lblShop.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblShop.ForeColor = System.Drawing.Color.White;
            this.lblShop.Location = new System.Drawing.Point(682, 32);
            this.lblShop.Name = "lblShop";
            this.lblShop.Size = new System.Drawing.Size(97, 30);
            this.lblShop.TabIndex = 96;
            this.lblShop.Text = "공정";
            this.lblShop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Detailperform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.cbb공정);
            this.Controls.Add(this.lblShop);
            this.Controls.Add(this.dtLast);
            this.Controls.Add(this.dtFirst);
            this.Controls.Add(this.lblTilde2);
            this.Controls.Add(this.grid상세실적조회);
            this.Controls.Add(this.tbx사원번호);
            this.Controls.Add(this.tbx제품번호);
            this.Controls.Add(this.tbx관리번호);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn조회);
            this.Controls.Add(this.lblEmployeeNum);
            this.Controls.Add(this.lblProductionNum);
            this.Controls.Add(this.lblPerformDate);
            this.Controls.Add(this.lblManageNum);
            this.Name = "Detailperform";
            this.Size = new System.Drawing.Size(1100, 551);
            this.Load += new System.EventHandler(this.Detailperform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid상세실적조회)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPerformDate;
        private System.Windows.Forms.Label lblManageNum;
        private System.Windows.Forms.Label lblProductionNum;
        private System.Windows.Forms.Label lblEmployeeNum;
        private MetroFramework.Controls.MetroButton btn조회;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox tbx관리번호;
        private MetroFramework.Controls.MetroTextBox tbx사원번호;
        private MetroFramework.Controls.MetroGrid grid상세실적조회;
        private System.Windows.Forms.Label lblTilde2;
        private MetroFramework.Controls.MetroTextBox tbx제품번호;
        private System.Windows.Forms.DateTimePicker dtFirst;
        private System.Windows.Forms.DateTimePicker dtLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn 관리번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제품번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 실적수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 불량수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 공정명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 작업자;
        private System.Windows.Forms.DataGridViewTextBoxColumn 등록시간;
        private MetroFramework.Controls.MetroComboBox cbb공정;
        private System.Windows.Forms.Label lblShop;
    }
}
