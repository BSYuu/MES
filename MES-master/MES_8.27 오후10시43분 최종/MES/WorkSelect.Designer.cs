namespace MES
{
    partial class WorkSelect
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid작업지시목록 = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.순위1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.필요량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbIndex = new System.Windows.Forms.Label();
            this.btnWorkStart = new MetroFramework.Controls.MetroButton();
            this.lbl전체페이지 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl관리번호 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl투입일자 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGridPageUp = new MetroFramework.Controls.MetroButton();
            this.btngridListDown = new MetroFramework.Controls.MetroButton();
            this.불량수량DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.현장실적현황DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl현재페이지 = new System.Windows.Forms.Label();
            this.lbl비고 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid작업지시목록)).BeginInit();
            this.SuspendLayout();
            // 
            // grid작업지시목록
            // 
            this.grid작업지시목록.AllowUserToAddRows = false;
            this.grid작업지시목록.AllowUserToDeleteRows = false;
            this.grid작업지시목록.AllowUserToResizeColumns = false;
            this.grid작업지시목록.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.grid작업지시목록.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid작업지시목록.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid작업지시목록.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid작업지시목록.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.grid작업지시목록.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid작업지시목록.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid작업지시목록.ColumnHeadersHeight = 34;
            this.grid작업지시목록.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid작업지시목록.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.순위1,
            this.필요량,
            this.Column2,
            this.Column11,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column12,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid작업지시목록.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid작업지시목록.EnableHeadersVisualStyles = false;
            this.grid작업지시목록.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid작업지시목록.GridColor = System.Drawing.Color.Black;
            this.grid작업지시목록.Location = new System.Drawing.Point(7, 39);
            this.grid작업지시목록.MultiSelect = false;
            this.grid작업지시목록.Name = "grid작업지시목록";
            this.grid작업지시목록.ReadOnly = true;
            this.grid작업지시목록.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid작업지시목록.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid작업지시목록.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grid작업지시목록.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grid작업지시목록.RowTemplate.Height = 23;
            this.grid작업지시목록.RowTemplate.ReadOnly = true;
            this.grid작업지시목록.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grid작업지시목록.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grid작업지시목록.ShowCellErrors = false;
            this.grid작업지시목록.Size = new System.Drawing.Size(866, 475);
            this.grid작업지시목록.TabIndex = 67;
            this.grid작업지시목록.UseCustomBackColor = true;
            this.grid작업지시목록.UseCustomForeColor = true;
            this.grid작업지시목록.UseStyleColors = true;
            this.grid작업지시목록.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid작업지시목록_CellEnter);
            this.grid작업지시목록.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Grid작업지시목록_KeyDown);
            // 
            // Column1
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "품목번호";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 127;
            // 
            // 순위1
            // 
            this.순위1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.순위1.HeaderText = "순위";
            this.순위1.Name = "순위1";
            this.순위1.ReadOnly = true;
            this.순위1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.순위1.Width = 58;
            // 
            // 필요량
            // 
            this.필요량.HeaderText = "필요수량";
            this.필요량.Name = "필요량";
            this.필요량.ReadOnly = true;
            this.필요량.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "1차관리";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Visible = false;
            this.Column2.Width = 16;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "1차공정";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column11.Width = 110;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "수량";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 58;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "투입일";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 105;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "2차관리";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Visible = false;
            this.Column5.Width = 15;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "2차공정";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column12.Width = 110;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column6.HeaderText = "수량";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 58;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "투입일";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 105;
            // 
            // lbIndex
            // 
            this.lbIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.lbIndex.Enabled = false;
            this.lbIndex.Font = new System.Drawing.Font("함초롬돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbIndex.Location = new System.Drawing.Point(7, 8);
            this.lbIndex.Name = "lbIndex";
            this.lbIndex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbIndex.Size = new System.Drawing.Size(148, 33);
            this.lbIndex.TabIndex = 66;
            this.lbIndex.Text = "작업지시목록";
            this.lbIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbIndex.UseMnemonic = false;
            // 
            // btnWorkStart
            // 
            this.btnWorkStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(161)))));
            this.btnWorkStart.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnWorkStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnWorkStart.Highlight = true;
            this.btnWorkStart.Location = new System.Drawing.Point(921, 49);
            this.btnWorkStart.Name = "btnWorkStart";
            this.btnWorkStart.Size = new System.Drawing.Size(164, 71);
            this.btnWorkStart.TabIndex = 59;
            this.btnWorkStart.Text = "작업 시작(&s)";
            this.btnWorkStart.UseCustomBackColor = true;
            this.btnWorkStart.UseCustomForeColor = true;
            this.btnWorkStart.UseSelectable = true;
            this.btnWorkStart.UseStyleColors = true;
            this.btnWorkStart.Click += new System.EventHandler(this.BtnWorkStart_Click);
            // 
            // lbl전체페이지
            // 
            this.lbl전체페이지.BackColor = System.Drawing.SystemColors.Control;
            this.lbl전체페이지.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl전체페이지.Location = new System.Drawing.Point(875, 518);
            this.lbl전체페이지.Name = "lbl전체페이지";
            this.lbl전체페이지.Size = new System.Drawing.Size(50, 30);
            this.lbl전체페이지.TabIndex = 58;
            this.lbl전체페이지.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Gray;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("함초롬돋움", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label13.Location = new System.Drawing.Point(745, 518);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 30);
            this.label13.TabIndex = 57;
            this.label13.Text = "페이지";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl관리번호
            // 
            this.lbl관리번호.BackColor = System.Drawing.SystemColors.Control;
            this.lbl관리번호.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl관리번호.Location = new System.Drawing.Point(322, 518);
            this.lbl관리번호.Name = "lbl관리번호";
            this.lbl관리번호.Size = new System.Drawing.Size(206, 30);
            this.lbl관리번호.TabIndex = 55;
            this.lbl관리번호.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Gray;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("함초롬돋움", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label10.Location = new System.Drawing.Point(252, 518);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 30);
            this.label10.TabIndex = 54;
            this.label10.Text = "관리번호";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl투입일자
            // 
            this.lbl투입일자.BackColor = System.Drawing.SystemColors.Control;
            this.lbl투입일자.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl투입일자.Location = new System.Drawing.Point(98, 517);
            this.lbl투입일자.Name = "lbl투입일자";
            this.lbl투입일자.Size = new System.Drawing.Size(148, 30);
            this.lbl투입일자.TabIndex = 53;
            this.lbl투입일자.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Gray;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("함초롬돋움", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label8.Location = new System.Drawing.Point(8, 517);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 30);
            this.label8.TabIndex = 52;
            this.label8.Text = "투입일자";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGridPageUp
            // 
            this.btnGridPageUp.Location = new System.Drawing.Point(875, 40);
            this.btnGridPageUp.Name = "btnGridPageUp";
            this.btnGridPageUp.Size = new System.Drawing.Size(25, 226);
            this.btnGridPageUp.TabIndex = 69;
            this.btnGridPageUp.Text = "▲";
            this.btnGridPageUp.UseSelectable = true;
            this.btnGridPageUp.Click += new System.EventHandler(this.BtnGridPageUp_Click);
            // 
            // btngridListDown
            // 
            this.btngridListDown.Location = new System.Drawing.Point(875, 272);
            this.btngridListDown.Name = "btngridListDown";
            this.btngridListDown.Size = new System.Drawing.Size(25, 242);
            this.btngridListDown.TabIndex = 70;
            this.btngridListDown.Text = "▼";
            this.btngridListDown.UseSelectable = true;
            this.btngridListDown.Click += new System.EventHandler(this.BtngridListDown_Click);
            // 
            // 불량수량DataGridViewTextBoxColumn
            // 
            this.불량수량DataGridViewTextBoxColumn.DataPropertyName = "불량수량";
            this.불량수량DataGridViewTextBoxColumn.HeaderText = "불량수량";
            this.불량수량DataGridViewTextBoxColumn.Name = "불량수량DataGridViewTextBoxColumn";
            this.불량수량DataGridViewTextBoxColumn.Width = 117;
            // 
            // 현장실적현황DataGridViewTextBoxColumn
            // 
            this.현장실적현황DataGridViewTextBoxColumn.DataPropertyName = "현장실적현황";
            this.현장실적현황DataGridViewTextBoxColumn.HeaderText = "현장실적현황";
            this.현장실적현황DataGridViewTextBoxColumn.Name = "현장실적현황DataGridViewTextBoxColumn";
            this.현장실적현황DataGridViewTextBoxColumn.Width = 117;
            // 
            // lbl현재페이지
            // 
            this.lbl현재페이지.BackColor = System.Drawing.SystemColors.Control;
            this.lbl현재페이지.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl현재페이지.Location = new System.Drawing.Point(810, 518);
            this.lbl현재페이지.Name = "lbl현재페이지";
            this.lbl현재페이지.Size = new System.Drawing.Size(45, 30);
            this.lbl현재페이지.TabIndex = 71;
            this.lbl현재페이지.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl비고
            // 
            this.lbl비고.BackColor = System.Drawing.SystemColors.Control;
            this.lbl비고.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl비고.Location = new System.Drawing.Point(598, 518);
            this.lbl비고.Name = "lbl비고";
            this.lbl비고.Size = new System.Drawing.Size(144, 30);
            this.lbl비고.TabIndex = 73;
            this.lbl비고.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("함초롬돋움", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(534, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 30);
            this.label3.TabIndex = 72;
            this.label3.Text = "비고";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(852, 518);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 30);
            this.label2.TabIndex = 74;
            this.label2.Text = "/";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WorkSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl비고);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl현재페이지);
            this.Controls.Add(this.btngridListDown);
            this.Controls.Add(this.btnGridPageUp);
            this.Controls.Add(this.grid작업지시목록);
            this.Controls.Add(this.lbIndex);
            this.Controls.Add(this.btnWorkStart);
            this.Controls.Add(this.lbl전체페이지);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbl관리번호);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl투입일자);
            this.Controls.Add(this.label8);
            this.Name = "WorkSelect";
            this.Size = new System.Drawing.Size(1100, 551);
            this.Load += new System.EventHandler(this.WorkSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid작업지시목록)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbIndex;
        private MetroFramework.Controls.MetroButton btnWorkStart;
        private System.Windows.Forms.Label lbl전체페이지;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl관리번호;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl투입일자;
        private System.Windows.Forms.Label label8;
       // private System.Windows.Forms.DataGridViewTextBoxColumn 품목번호DataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton btnGridPageUp;
        private MetroFramework.Controls.MetroButton btngridListDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn 불량수량DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 현장실적현황DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl현재페이지;
        private System.Windows.Forms.Label lbl비고;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 순위1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 필요량;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        public MetroFramework.Controls.MetroGrid grid작업지시목록;
    }
}
