namespace MES
{
    partial class PoolPerform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.grid불량실적조회 = new MetroFramework.Controls.MetroGrid();
            this.관리번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.불량수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.공정명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.작업자 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.등록시간 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.비고 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn조회 = new MetroFramework.Controls.MetroButton();
            this.tbx사원번호 = new MetroFramework.Controls.MetroTextBox();
            this.tbx관리번호 = new MetroFramework.Controls.MetroTextBox();
            this.tbx품목번호 = new MetroFramework.Controls.MetroTextBox();
            this.lblEmployeeNum = new System.Windows.Forms.Label();
            this.lblManageNum = new System.Windows.Forms.Label();
            this.lblPerformDate = new System.Windows.Forms.Label();
            this.lblProductionNum = new System.Windows.Forms.Label();
            this.lblShop = new System.Windows.Forms.Label();
            this.lblTilde2 = new System.Windows.Forms.Label();
            this.dtFirst = new System.Windows.Forms.DateTimePicker();
            this.dtLast = new System.Windows.Forms.DateTimePicker();
            this.cbb공정 = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid불량실적조회)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("함초롬돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(145, 27);
            this.label1.TabIndex = 83;
            this.label1.Text = "불량실적조회";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // grid불량실적조회
            // 
            this.grid불량실적조회.AllowUserToResizeRows = false;
            this.grid불량실적조회.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid불량실적조회.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid불량실적조회.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid불량실적조회.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid불량실적조회.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid불량실적조회.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid불량실적조회.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid불량실적조회.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.관리번호,
            this.품목번호,
            this.불량수량,
            this.공정명,
            this.작업자,
            this.등록시간,
            this.비고});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid불량실적조회.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid불량실적조회.EnableHeadersVisualStyles = false;
            this.grid불량실적조회.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid불량실적조회.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid불량실적조회.Location = new System.Drawing.Point(3, 135);
            this.grid불량실적조회.Name = "grid불량실적조회";
            this.grid불량실적조회.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid불량실적조회.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid불량실적조회.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid불량실적조회.RowTemplate.Height = 23;
            this.grid불량실적조회.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid불량실적조회.Size = new System.Drawing.Size(1094, 413);
            this.grid불량실적조회.TabIndex = 105;
            // 
            // 관리번호
            // 
            this.관리번호.HeaderText = "관리번호";
            this.관리번호.Name = "관리번호";
            // 
            // 품목번호
            // 
            this.품목번호.HeaderText = "품목번호";
            this.품목번호.Name = "품목번호";
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
            // 비고
            // 
            this.비고.HeaderText = "비고";
            this.비고.Name = "비고";
            // 
            // btn조회
            // 
            this.btn조회.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(161)))));
            this.btn조회.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn조회.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn조회.Highlight = true;
            this.btn조회.Location = new System.Drawing.Point(928, 28);
            this.btn조회.Name = "btn조회";
            this.btn조회.Size = new System.Drawing.Size(138, 75);
            this.btn조회.TabIndex = 102;
            this.btn조회.Text = "조회";
            this.btn조회.UseCustomBackColor = true;
            this.btn조회.UseCustomForeColor = true;
            this.btn조회.UseSelectable = true;
            this.btn조회.UseStyleColors = true;
            this.btn조회.Click += new System.EventHandler(this.Btn조회_Click);
            // 
            // tbx사원번호
            // 
            // 
            // 
            // 
            this.tbx사원번호.CustomButton.Image = null;
            this.tbx사원번호.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.tbx사원번호.CustomButton.Name = "";
            this.tbx사원번호.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbx사원번호.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx사원번호.CustomButton.TabIndex = 1;
            this.tbx사원번호.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx사원번호.CustomButton.UseSelectable = true;
            this.tbx사원번호.CustomButton.Visible = false;
            this.tbx사원번호.Lines = new string[0];
            this.tbx사원번호.Location = new System.Drawing.Point(464, 69);
            this.tbx사원번호.MaxLength = 32767;
            this.tbx사원번호.Name = "tbx사원번호";
            this.tbx사원번호.PasswordChar = '\0';
            this.tbx사원번호.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbx사원번호.SelectedText = "";
            this.tbx사원번호.SelectionLength = 0;
            this.tbx사원번호.SelectionStart = 0;
            this.tbx사원번호.ShortcutsEnabled = true;
            this.tbx사원번호.Size = new System.Drawing.Size(233, 23);
            this.tbx사원번호.TabIndex = 101;
            this.tbx사원번호.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx사원번호.UseSelectable = true;
            this.tbx사원번호.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx사원번호.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tbx관리번호.Lines = new string[0];
            this.tbx관리번호.Location = new System.Drawing.Point(464, 34);
            this.tbx관리번호.MaxLength = 32767;
            this.tbx관리번호.Name = "tbx관리번호";
            this.tbx관리번호.PasswordChar = '\0';
            this.tbx관리번호.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbx관리번호.SelectedText = "";
            this.tbx관리번호.SelectionLength = 0;
            this.tbx관리번호.SelectionStart = 0;
            this.tbx관리번호.ShortcutsEnabled = true;
            this.tbx관리번호.Size = new System.Drawing.Size(233, 23);
            this.tbx관리번호.TabIndex = 100;
            this.tbx관리번호.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx관리번호.UseSelectable = true;
            this.tbx관리번호.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx관리번호.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tbx품목번호
            // 
            // 
            // 
            // 
            this.tbx품목번호.CustomButton.Image = null;
            this.tbx품목번호.CustomButton.Location = new System.Drawing.Point(207, 1);
            this.tbx품목번호.CustomButton.Name = "";
            this.tbx품목번호.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbx품목번호.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx품목번호.CustomButton.TabIndex = 1;
            this.tbx품목번호.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx품목번호.CustomButton.UseSelectable = true;
            this.tbx품목번호.CustomButton.Visible = false;
            this.tbx품목번호.Lines = new string[0];
            this.tbx품목번호.Location = new System.Drawing.Point(110, 71);
            this.tbx품목번호.MaxLength = 32767;
            this.tbx품목번호.Name = "tbx품목번호";
            this.tbx품목번호.PasswordChar = '\0';
            this.tbx품목번호.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbx품목번호.SelectedText = "";
            this.tbx품목번호.SelectionLength = 0;
            this.tbx품목번호.SelectionStart = 0;
            this.tbx품목번호.ShortcutsEnabled = true;
            this.tbx품목번호.Size = new System.Drawing.Size(229, 23);
            this.tbx품목번호.TabIndex = 98;
            this.tbx품목번호.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx품목번호.UseSelectable = true;
            this.tbx품목번호.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx품목번호.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblEmployeeNum
            // 
            this.lblEmployeeNum.BackColor = System.Drawing.Color.Gray;
            this.lblEmployeeNum.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblEmployeeNum.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeNum.Location = new System.Drawing.Point(368, 63);
            this.lblEmployeeNum.Name = "lblEmployeeNum";
            this.lblEmployeeNum.Size = new System.Drawing.Size(93, 29);
            this.lblEmployeeNum.TabIndex = 94;
            this.lblEmployeeNum.Text = "사원번호";
            this.lblEmployeeNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManageNum
            // 
            this.lblManageNum.BackColor = System.Drawing.Color.Gray;
            this.lblManageNum.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblManageNum.ForeColor = System.Drawing.Color.White;
            this.lblManageNum.Location = new System.Drawing.Point(368, 28);
            this.lblManageNum.Name = "lblManageNum";
            this.lblManageNum.Size = new System.Drawing.Size(93, 32);
            this.lblManageNum.TabIndex = 89;
            this.lblManageNum.Text = "관리번호";
            this.lblManageNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPerformDate
            // 
            this.lblPerformDate.BackColor = System.Drawing.Color.Gray;
            this.lblPerformDate.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPerformDate.ForeColor = System.Drawing.Color.White;
            this.lblPerformDate.Location = new System.Drawing.Point(3, 97);
            this.lblPerformDate.Name = "lblPerformDate";
            this.lblPerformDate.Size = new System.Drawing.Size(97, 32);
            this.lblPerformDate.TabIndex = 87;
            this.lblPerformDate.Text = "실적일";
            this.lblPerformDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductionNum
            // 
            this.lblProductionNum.BackColor = System.Drawing.Color.Gray;
            this.lblProductionNum.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProductionNum.ForeColor = System.Drawing.Color.White;
            this.lblProductionNum.Location = new System.Drawing.Point(3, 60);
            this.lblProductionNum.Name = "lblProductionNum";
            this.lblProductionNum.Size = new System.Drawing.Size(97, 32);
            this.lblProductionNum.TabIndex = 86;
            this.lblProductionNum.Text = "품번";
            this.lblProductionNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShop
            // 
            this.lblShop.BackColor = System.Drawing.Color.Gray;
            this.lblShop.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblShop.ForeColor = System.Drawing.Color.White;
            this.lblShop.Location = new System.Drawing.Point(3, 27);
            this.lblShop.Name = "lblShop";
            this.lblShop.Size = new System.Drawing.Size(97, 32);
            this.lblShop.TabIndex = 84;
            this.lblShop.Text = "SHOP";
            this.lblShop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTilde2
            // 
            this.lblTilde2.AutoSize = true;
            this.lblTilde2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTilde2.Location = new System.Drawing.Point(325, 106);
            this.lblTilde2.Name = "lblTilde2";
            this.lblTilde2.Size = new System.Drawing.Size(20, 16);
            this.lblTilde2.TabIndex = 92;
            this.lblTilde2.Text = "~";
            // 
            // dtFirst
            // 
            this.dtFirst.Location = new System.Drawing.Point(110, 105);
            this.dtFirst.Name = "dtFirst";
            this.dtFirst.Size = new System.Drawing.Size(200, 21);
            this.dtFirst.TabIndex = 109;
            // 
            // dtLast
            // 
            this.dtLast.Location = new System.Drawing.Point(363, 105);
            this.dtLast.Name = "dtLast";
            this.dtLast.Size = new System.Drawing.Size(200, 21);
            this.dtLast.TabIndex = 110;
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
            this.cbb공정.Location = new System.Drawing.Point(110, 34);
            this.cbb공정.Name = "cbb공정";
            this.cbb공정.Size = new System.Drawing.Size(172, 29);
            this.cbb공정.TabIndex = 111;
            this.cbb공정.UseSelectable = true;
            // 
            // PoolPerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.cbb공정);
            this.Controls.Add(this.dtLast);
            this.Controls.Add(this.dtFirst);
            this.Controls.Add(this.grid불량실적조회);
            this.Controls.Add(this.btn조회);
            this.Controls.Add(this.tbx사원번호);
            this.Controls.Add(this.tbx관리번호);
            this.Controls.Add(this.tbx품목번호);
            this.Controls.Add(this.lblEmployeeNum);
            this.Controls.Add(this.lblTilde2);
            this.Controls.Add(this.lblManageNum);
            this.Controls.Add(this.lblPerformDate);
            this.Controls.Add(this.lblProductionNum);
            this.Controls.Add(this.lblShop);
            this.Controls.Add(this.label1);
            this.Name = "PoolPerform";
            this.Size = new System.Drawing.Size(1100, 551);
            ((System.ComponentModel.ISupportInitialize)(this.grid불량실적조회)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroGrid grid불량실적조회;
        private MetroFramework.Controls.MetroButton btn조회;
        private MetroFramework.Controls.MetroTextBox tbx사원번호;
        private MetroFramework.Controls.MetroTextBox tbx관리번호;
        private MetroFramework.Controls.MetroTextBox tbx품목번호;
        private System.Windows.Forms.Label lblEmployeeNum;
        private System.Windows.Forms.Label lblManageNum;
        private System.Windows.Forms.Label lblPerformDate;
        private System.Windows.Forms.Label lblProductionNum;
        private System.Windows.Forms.Label lblShop;
        private System.Windows.Forms.Label lblTilde2;
        private System.Windows.Forms.DateTimePicker dtFirst;
        private System.Windows.Forms.DateTimePicker dtLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn 관리번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 불량수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 공정명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 작업자;
        private System.Windows.Forms.DataGridViewTextBoxColumn 등록시간;
        private System.Windows.Forms.DataGridViewTextBoxColumn 비고;
        private MetroFramework.Controls.MetroComboBox cbb공정;
    }
}
