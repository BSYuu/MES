namespace MES
{
    partial class ProductPerformance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblShop = new System.Windows.Forms.Label();
            this.lblProductionNum = new System.Windows.Forms.Label();
            this.lblPerformDate = new System.Windows.Forms.Label();
            this.lblManageNum = new System.Windows.Forms.Label();
            this.lblEmployeeNum = new System.Windows.Forms.Label();
            this.lbIndex = new System.Windows.Forms.Label();
            this.tbxFirst품번 = new MetroFramework.Controls.MetroTextBox();
            this.tbx관리번호 = new MetroFramework.Controls.MetroTextBox();
            this.tbx사원번호 = new MetroFramework.Controls.MetroTextBox();
            this.btn조회 = new MetroFramework.Controls.MetroButton();
            this.grid생산실적조회 = new MetroFramework.Controls.MetroGrid();
            this.관리번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.실적수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.불량수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.공정명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.작업자 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.실적등록시간 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTilde2 = new System.Windows.Forms.Label();
            this.dtFirst = new System.Windows.Forms.DateTimePicker();
            this.dtLast = new System.Windows.Forms.DateTimePicker();
            this.cbb공정 = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid생산실적조회)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShop
            // 
            this.lblShop.BackColor = System.Drawing.Color.Gray;
            this.lblShop.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblShop.ForeColor = System.Drawing.Color.White;
            this.lblShop.Location = new System.Drawing.Point(3, 29);
            this.lblShop.Name = "lblShop";
            this.lblShop.Size = new System.Drawing.Size(97, 32);
            this.lblShop.TabIndex = 6;
            this.lblShop.Text = "SHOP";
            this.lblShop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductionNum
            // 
            this.lblProductionNum.BackColor = System.Drawing.Color.Gray;
            this.lblProductionNum.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProductionNum.ForeColor = System.Drawing.Color.White;
            this.lblProductionNum.Location = new System.Drawing.Point(3, 62);
            this.lblProductionNum.Name = "lblProductionNum";
            this.lblProductionNum.Size = new System.Drawing.Size(97, 32);
            this.lblProductionNum.TabIndex = 8;
            this.lblProductionNum.Text = "품번";
            this.lblProductionNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPerformDate
            // 
            this.lblPerformDate.BackColor = System.Drawing.Color.Gray;
            this.lblPerformDate.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPerformDate.ForeColor = System.Drawing.Color.White;
            this.lblPerformDate.Location = new System.Drawing.Point(3, 99);
            this.lblPerformDate.Name = "lblPerformDate";
            this.lblPerformDate.Size = new System.Drawing.Size(97, 32);
            this.lblPerformDate.TabIndex = 9;
            this.lblPerformDate.Text = "실적일";
            this.lblPerformDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManageNum
            // 
            this.lblManageNum.BackColor = System.Drawing.Color.Gray;
            this.lblManageNum.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblManageNum.ForeColor = System.Drawing.Color.White;
            this.lblManageNum.Location = new System.Drawing.Point(345, 29);
            this.lblManageNum.Name = "lblManageNum";
            this.lblManageNum.Size = new System.Drawing.Size(93, 32);
            this.lblManageNum.TabIndex = 15;
            this.lblManageNum.Text = "관리번호";
            this.lblManageNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmployeeNum
            // 
            this.lblEmployeeNum.BackColor = System.Drawing.Color.Gray;
            this.lblEmployeeNum.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblEmployeeNum.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeNum.Location = new System.Drawing.Point(345, 64);
            this.lblEmployeeNum.Name = "lblEmployeeNum";
            this.lblEmployeeNum.Size = new System.Drawing.Size(93, 29);
            this.lblEmployeeNum.TabIndex = 25;
            this.lblEmployeeNum.Text = "사원번호";
            this.lblEmployeeNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbIndex
            // 
            this.lbIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.lbIndex.Enabled = false;
            this.lbIndex.Font = new System.Drawing.Font("함초롬돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbIndex.Location = new System.Drawing.Point(2, 3);
            this.lbIndex.Name = "lbIndex";
            this.lbIndex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbIndex.Size = new System.Drawing.Size(145, 27);
            this.lbIndex.TabIndex = 47;
            this.lbIndex.Text = "상세실적조회";
            this.lbIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbIndex.UseMnemonic = false;
            // 
            // tbxFirst품번
            // 
            // 
            // 
            // 
            this.tbxFirst품번.CustomButton.Image = null;
            this.tbxFirst품번.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.tbxFirst품번.CustomButton.Name = "";
            this.tbxFirst품번.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxFirst품번.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxFirst품번.CustomButton.TabIndex = 1;
            this.tbxFirst품번.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxFirst품번.CustomButton.UseSelectable = true;
            this.tbxFirst품번.CustomButton.Visible = false;
            this.tbxFirst품번.Lines = new string[0];
            this.tbxFirst품번.Location = new System.Drawing.Point(110, 71);
            this.tbxFirst품번.MaxLength = 32767;
            this.tbxFirst품번.Name = "tbxFirst품번";
            this.tbxFirst품번.PasswordChar = '\0';
            this.tbxFirst품번.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxFirst품번.SelectedText = "";
            this.tbxFirst품번.SelectionLength = 0;
            this.tbxFirst품번.SelectionStart = 0;
            this.tbxFirst품번.ShortcutsEnabled = true;
            this.tbxFirst품번.Size = new System.Drawing.Size(196, 23);
            this.tbxFirst품번.TabIndex = 49;
            this.tbxFirst품번.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxFirst품번.UseSelectable = true;
            this.tbxFirst품번.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxFirst품번.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tbx관리번호.Location = new System.Drawing.Point(441, 35);
            this.tbx관리번호.MaxLength = 32767;
            this.tbx관리번호.Name = "tbx관리번호";
            this.tbx관리번호.PasswordChar = '\0';
            this.tbx관리번호.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbx관리번호.SelectedText = "";
            this.tbx관리번호.SelectionLength = 0;
            this.tbx관리번호.SelectionStart = 0;
            this.tbx관리번호.ShortcutsEnabled = true;
            this.tbx관리번호.Size = new System.Drawing.Size(233, 23);
            this.tbx관리번호.TabIndex = 51;
            this.tbx관리번호.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx관리번호.UseSelectable = true;
            this.tbx관리번호.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx관리번호.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tbx사원번호.Location = new System.Drawing.Point(441, 70);
            this.tbx사원번호.MaxLength = 32767;
            this.tbx사원번호.Name = "tbx사원번호";
            this.tbx사원번호.PasswordChar = '\0';
            this.tbx사원번호.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbx사원번호.SelectedText = "";
            this.tbx사원번호.SelectionLength = 0;
            this.tbx사원번호.SelectionStart = 0;
            this.tbx사원번호.ShortcutsEnabled = true;
            this.tbx사원번호.Size = new System.Drawing.Size(233, 23);
            this.tbx사원번호.TabIndex = 52;
            this.tbx사원번호.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx사원번호.UseSelectable = true;
            this.tbx사원번호.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx사원번호.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn조회
            // 
            this.btn조회.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(161)))));
            this.btn조회.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn조회.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn조회.Highlight = true;
            this.btn조회.Location = new System.Drawing.Point(951, 29);
            this.btn조회.Name = "btn조회";
            this.btn조회.Size = new System.Drawing.Size(121, 79);
            this.btn조회.TabIndex = 53;
            this.btn조회.Text = "조회";
            this.btn조회.UseCustomBackColor = true;
            this.btn조회.UseCustomForeColor = true;
            this.btn조회.UseSelectable = true;
            this.btn조회.UseStyleColors = true;
            this.btn조회.Click += new System.EventHandler(this.Btn조회_Click);
            // 
            // grid생산실적조회
            // 
            this.grid생산실적조회.AllowUserToResizeRows = false;
            this.grid생산실적조회.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid생산실적조회.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid생산실적조회.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid생산실적조회.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid생산실적조회.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid생산실적조회.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid생산실적조회.ColumnHeadersHeight = 25;
            this.grid생산실적조회.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid생산실적조회.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.관리번호,
            this.품목번호,
            this.실적수량,
            this.불량수량,
            this.공정명,
            this.작업자,
            this.실적등록시간});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid생산실적조회.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid생산실적조회.EnableHeadersVisualStyles = false;
            this.grid생산실적조회.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid생산실적조회.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid생산실적조회.Location = new System.Drawing.Point(3, 137);
            this.grid생산실적조회.Name = "grid생산실적조회";
            this.grid생산실적조회.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid생산실적조회.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid생산실적조회.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid생산실적조회.RowTemplate.Height = 23;
            this.grid생산실적조회.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid생산실적조회.Size = new System.Drawing.Size(1094, 411);
            this.grid생산실적조회.TabIndex = 56;
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
            // 실적등록시간
            // 
            this.실적등록시간.HeaderText = "실적등록시간";
            this.실적등록시간.Name = "실적등록시간";
            // 
            // lblTilde2
            // 
            this.lblTilde2.AutoSize = true;
            this.lblTilde2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTilde2.Location = new System.Drawing.Point(334, 107);
            this.lblTilde2.Name = "lblTilde2";
            this.lblTilde2.Size = new System.Drawing.Size(20, 16);
            this.lblTilde2.TabIndex = 18;
            this.lblTilde2.Text = "~";
            // 
            // dtFirst
            // 
            this.dtFirst.CustomFormat = "yyyy-MM-dd";
            this.dtFirst.Location = new System.Drawing.Point(106, 105);
            this.dtFirst.Name = "dtFirst";
            this.dtFirst.Size = new System.Drawing.Size(200, 21);
            this.dtFirst.TabIndex = 57;
            // 
            // dtLast
            // 
            this.dtLast.CustomFormat = "yyyy-MM-dd";
            this.dtLast.Location = new System.Drawing.Point(378, 105);
            this.dtLast.Name = "dtLast";
            this.dtLast.Size = new System.Drawing.Size(200, 21);
            this.dtLast.TabIndex = 58;
            // 
            // cbb공정
            // 
            this.cbb공정.FormattingEnabled = true;
            this.cbb공정.ItemHeight = 23;
            this.cbb공정.Items.AddRange(new object[] {
            "절단",
            "벤딩",
            "드릴",
            "용접",
            " "});
            this.cbb공정.Location = new System.Drawing.Point(110, 33);
            this.cbb공정.Name = "cbb공정";
            this.cbb공정.Size = new System.Drawing.Size(151, 29);
            this.cbb공정.TabIndex = 59;
            this.cbb공정.UseSelectable = true;
            // 
            // ProductPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.cbb공정);
            this.Controls.Add(this.dtLast);
            this.Controls.Add(this.dtFirst);
            this.Controls.Add(this.grid생산실적조회);
            this.Controls.Add(this.btn조회);
            this.Controls.Add(this.tbx사원번호);
            this.Controls.Add(this.tbx관리번호);
            this.Controls.Add(this.tbxFirst품번);
            this.Controls.Add(this.lbIndex);
            this.Controls.Add(this.lblEmployeeNum);
            this.Controls.Add(this.lblTilde2);
            this.Controls.Add(this.lblManageNum);
            this.Controls.Add(this.lblPerformDate);
            this.Controls.Add(this.lblProductionNum);
            this.Controls.Add(this.lblShop);
            this.Name = "ProductPerformance";
            this.Size = new System.Drawing.Size(1100, 551);
            ((System.ComponentModel.ISupportInitialize)(this.grid생산실적조회)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblShop;
        private System.Windows.Forms.Label lblProductionNum;
        private System.Windows.Forms.Label lblPerformDate;
        private System.Windows.Forms.Label lblManageNum;
        private System.Windows.Forms.Label lblEmployeeNum;
        private System.Windows.Forms.Label lbIndex;
        private MetroFramework.Controls.MetroTextBox tbxFirst품번;
        private MetroFramework.Controls.MetroTextBox tbx관리번호;
        private MetroFramework.Controls.MetroTextBox tbx사원번호;
        private MetroFramework.Controls.MetroButton btn조회;
        private MetroFramework.Controls.MetroGrid grid생산실적조회;
        private System.Windows.Forms.Label lblTilde2;
        private System.Windows.Forms.DateTimePicker dtFirst;
        private System.Windows.Forms.DateTimePicker dtLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn 관리번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 실적수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 불량수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 공정명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 작업자;
        private System.Windows.Forms.DataGridViewTextBoxColumn 실적등록시간;
        private MetroFramework.Controls.MetroComboBox cbb공정;
    }
}
