namespace MES
{
    partial class WorkStatus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblItemNum = new System.Windows.Forms.Label();
            this.lbl품목번호 = new System.Windows.Forms.Label();
            this.lblOutside = new System.Windows.Forms.Label();
            this.lblManageNum = new System.Windows.Forms.Label();
            this.lblInspectCount = new System.Windows.Forms.Label();
            this.lblProductCount = new System.Windows.Forms.Label();
            this.lblPoolCount = new System.Windows.Forms.Label();
            this.lbl규격 = new System.Windows.Forms.Label();
            this.lbl관리번호 = new System.Windows.Forms.Label();
            this.lbl지시수량 = new System.Windows.Forms.Label();
            this.lbl품명 = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblProcess = new System.Windows.Forms.Label();
            this.lbl작업시작시간 = new System.Windows.Forms.Label();
            this.lblStartWorkTime = new System.Windows.Forms.Label();
            this.lblCompleteProcess = new System.Windows.Forms.Label();
            this.btn작업종료 = new MetroFramework.Controls.MetroButton();
            this.cbx공정완료 = new MetroFramework.Controls.MetroCheckBox();
            this.btn실적등록 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbIndex = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grid실적현황 = new MetroFramework.Controls.MetroGrid();
            this.실적수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.불량실적 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.공정명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.작업자 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.실적등록시간 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid불량현황 = new MetroFramework.Controls.MetroGrid();
            this.tbx생산수량 = new MetroFramework.Controls.MetroTextBox();
            this.tbx불량수량 = new MetroFramework.Controls.MetroTextBox();
            this.cbb공정 = new MetroFramework.Controls.MetroComboBox();
            this.lbl벤딩생산수량 = new System.Windows.Forms.Label();
            this.lbl드릴생산수량 = new System.Windows.Forms.Label();
            this.lbl용접생산수량 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl절단생산수량 = new System.Windows.Forms.Label();
            this.lbl절단잔량 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl용접잔량 = new System.Windows.Forms.Label();
            this.lbl드릴잔량 = new System.Windows.Forms.Label();
            this.lbl벤딩잔량 = new System.Windows.Forms.Label();
            this.lbl현재공정 = new System.Windows.Forms.Label();
            this.불량수량1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.불량등록시간 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.불량_비고 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid실적현황)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid불량현황)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemNum
            // 
            this.lblItemNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(161)))));
            this.lblItemNum.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblItemNum.ForeColor = System.Drawing.Color.White;
            this.lblItemNum.Location = new System.Drawing.Point(7, 39);
            this.lblItemNum.Name = "lblItemNum";
            this.lblItemNum.Size = new System.Drawing.Size(97, 25);
            this.lblItemNum.TabIndex = 0;
            this.lblItemNum.Text = "제품번호";
            this.lblItemNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl품목번호
            // 
            this.lbl품목번호.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl품목번호.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl품목번호.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl품목번호.Location = new System.Drawing.Point(101, 39);
            this.lbl품목번호.Margin = new System.Windows.Forms.Padding(1);
            this.lbl품목번호.Name = "lbl품목번호";
            this.lbl품목번호.Size = new System.Drawing.Size(153, 25);
            this.lbl품목번호.TabIndex = 5;
            this.lbl품목번호.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutside
            // 
            this.lblOutside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(161)))));
            this.lblOutside.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOutside.ForeColor = System.Drawing.Color.White;
            this.lblOutside.Location = new System.Drawing.Point(7, 112);
            this.lblOutside.Name = "lblOutside";
            this.lblOutside.Size = new System.Drawing.Size(94, 25);
            this.lblOutside.TabIndex = 8;
            this.lblOutside.Text = "규격";
            this.lblOutside.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManageNum
            // 
            this.lblManageNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(161)))));
            this.lblManageNum.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblManageNum.ForeColor = System.Drawing.Color.White;
            this.lblManageNum.Location = new System.Drawing.Point(7, 64);
            this.lblManageNum.Name = "lblManageNum";
            this.lblManageNum.Size = new System.Drawing.Size(97, 25);
            this.lblManageNum.TabIndex = 9;
            this.lblManageNum.Text = "관리번호";
            this.lblManageNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInspectCount
            // 
            this.lblInspectCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(161)))));
            this.lblInspectCount.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblInspectCount.ForeColor = System.Drawing.Color.White;
            this.lblInspectCount.Location = new System.Drawing.Point(281, 38);
            this.lblInspectCount.Name = "lblInspectCount";
            this.lblInspectCount.Size = new System.Drawing.Size(108, 24);
            this.lblInspectCount.TabIndex = 10;
            this.lblInspectCount.Text = "지시수랑";
            this.lblInspectCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductCount
            // 
            this.lblProductCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(161)))));
            this.lblProductCount.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProductCount.ForeColor = System.Drawing.Color.White;
            this.lblProductCount.Location = new System.Drawing.Point(281, 62);
            this.lblProductCount.Name = "lblProductCount";
            this.lblProductCount.Size = new System.Drawing.Size(108, 25);
            this.lblProductCount.TabIndex = 11;
            this.lblProductCount.Text = "생산수량";
            this.lblProductCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPoolCount
            // 
            this.lblPoolCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(161)))));
            this.lblPoolCount.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPoolCount.ForeColor = System.Drawing.Color.White;
            this.lblPoolCount.Location = new System.Drawing.Point(281, 87);
            this.lblPoolCount.Name = "lblPoolCount";
            this.lblPoolCount.Size = new System.Drawing.Size(108, 25);
            this.lblPoolCount.TabIndex = 12;
            this.lblPoolCount.Text = "불량수량";
            this.lblPoolCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl규격
            // 
            this.lbl규격.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl규격.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl규격.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl규격.Location = new System.Drawing.Point(101, 112);
            this.lbl규격.Margin = new System.Windows.Forms.Padding(1);
            this.lbl규격.Name = "lbl규격";
            this.lbl규격.Size = new System.Drawing.Size(153, 25);
            this.lbl규격.TabIndex = 13;
            this.lbl규격.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl관리번호
            // 
            this.lbl관리번호.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl관리번호.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl관리번호.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl관리번호.Location = new System.Drawing.Point(101, 63);
            this.lbl관리번호.Margin = new System.Windows.Forms.Padding(1);
            this.lbl관리번호.Name = "lbl관리번호";
            this.lbl관리번호.Size = new System.Drawing.Size(153, 27);
            this.lbl관리번호.TabIndex = 14;
            this.lbl관리번호.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl지시수량
            // 
            this.lbl지시수량.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl지시수량.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl지시수량.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl지시수량.Location = new System.Drawing.Point(389, 38);
            this.lbl지시수량.Margin = new System.Windows.Forms.Padding(1);
            this.lbl지시수량.Name = "lbl지시수량";
            this.lbl지시수량.Size = new System.Drawing.Size(154, 29);
            this.lbl지시수량.TabIndex = 16;
            this.lbl지시수량.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl품명
            // 
            this.lbl품명.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl품명.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl품명.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl품명.Location = new System.Drawing.Point(101, 89);
            this.lbl품명.Name = "lbl품명";
            this.lbl품명.Size = new System.Drawing.Size(153, 25);
            this.lbl품명.TabIndex = 19;
            this.lbl품명.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItemName
            // 
            this.lblItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(161)))));
            this.lblItemName.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblItemName.ForeColor = System.Drawing.Color.White;
            this.lblItemName.Location = new System.Drawing.Point(7, 89);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(94, 25);
            this.lblItemName.TabIndex = 18;
            this.lblItemName.Text = "품명";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProcess
            // 
            this.lblProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(161)))));
            this.lblProcess.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProcess.ForeColor = System.Drawing.Color.White;
            this.lblProcess.Location = new System.Drawing.Point(838, 7);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(97, 29);
            this.lblProcess.TabIndex = 26;
            this.lblProcess.Text = "공정";
            this.lblProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl작업시작시간
            // 
            this.lbl작업시작시간.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl작업시작시간.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl작업시작시간.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl작업시작시간.Location = new System.Drawing.Point(385, 125);
            this.lbl작업시작시간.Name = "lbl작업시작시간";
            this.lbl작업시작시간.Size = new System.Drawing.Size(223, 25);
            this.lbl작업시작시간.TabIndex = 31;
            this.lbl작업시작시간.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStartWorkTime
            // 
            this.lblStartWorkTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(161)))));
            this.lblStartWorkTime.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStartWorkTime.ForeColor = System.Drawing.Color.White;
            this.lblStartWorkTime.Location = new System.Drawing.Point(281, 125);
            this.lblStartWorkTime.Name = "lblStartWorkTime";
            this.lblStartWorkTime.Size = new System.Drawing.Size(108, 25);
            this.lblStartWorkTime.TabIndex = 30;
            this.lblStartWorkTime.Text = "작업시작시간";
            this.lblStartWorkTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompleteProcess
            // 
            this.lblCompleteProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(161)))));
            this.lblCompleteProcess.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCompleteProcess.ForeColor = System.Drawing.Color.White;
            this.lblCompleteProcess.Location = new System.Drawing.Point(686, 125);
            this.lblCompleteProcess.Name = "lblCompleteProcess";
            this.lblCompleteProcess.Size = new System.Drawing.Size(97, 25);
            this.lblCompleteProcess.TabIndex = 34;
            this.lblCompleteProcess.Text = "공정 완료";
            this.lblCompleteProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn작업종료
            // 
            this.btn작업종료.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(161)))));
            this.btn작업종료.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn작업종료.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn작업종료.Highlight = true;
            this.btn작업종료.Location = new System.Drawing.Point(939, 285);
            this.btn작업종료.Name = "btn작업종료";
            this.btn작업종료.Size = new System.Drawing.Size(149, 77);
            this.btn작업종료.TabIndex = 45;
            this.btn작업종료.Text = "작업종료";
            this.btn작업종료.UseCustomBackColor = true;
            this.btn작업종료.UseCustomForeColor = true;
            this.btn작업종료.UseSelectable = true;
            this.btn작업종료.UseStyleColors = true;
            this.btn작업종료.Click += new System.EventHandler(this.Btn작업종료_Click);
            // 
            // cbx공정완료
            // 
            this.cbx공정완료.AutoSize = true;
            this.cbx공정완료.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.cbx공정완료.Location = new System.Drawing.Point(799, 125);
            this.cbx공정완료.Name = "cbx공정완료";
            this.cbx공정완료.Size = new System.Drawing.Size(33, 25);
            this.cbx공정완료.TabIndex = 46;
            this.cbx공정완료.Text = " ";
            this.cbx공정완료.UseCustomBackColor = true;
            this.cbx공정완료.UseCustomForeColor = true;
            this.cbx공정완료.UseSelectable = true;
            this.cbx공정완료.UseStyleColors = true;
            this.cbx공정완료.CheckedChanged += new System.EventHandler(this.Cbx공정완료_CheckedChanged);
            // 
            // btn실적등록
            // 
            this.btn실적등록.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(161)))));
            this.btn실적등록.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn실적등록.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn실적등록.Highlight = true;
            this.btn실적등록.Location = new System.Drawing.Point(939, 185);
            this.btn실적등록.Name = "btn실적등록";
            this.btn실적등록.Size = new System.Drawing.Size(149, 79);
            this.btn실적등록.TabIndex = 49;
            this.btn실적등록.Text = "실적등록";
            this.btn실적등록.UseCustomBackColor = true;
            this.btn실적등록.UseCustomForeColor = true;
            this.btn실적등록.UseSelectable = true;
            this.btn실적등록.UseStyleColors = true;
            this.btn실적등록.Click += new System.EventHandler(this.Btn실적등록_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("함초롬돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(145, 27);
            this.label1.TabIndex = 50;
            this.label1.Text = "작업현황";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // lbIndex
            // 
            this.lbIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.lbIndex.Enabled = false;
            this.lbIndex.Font = new System.Drawing.Font("함초롬돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbIndex.Location = new System.Drawing.Point(3, 158);
            this.lbIndex.Name = "lbIndex";
            this.lbIndex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbIndex.Size = new System.Drawing.Size(145, 27);
            this.lbIndex.TabIndex = 51;
            this.lbIndex.Text = "실적현황";
            this.lbIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbIndex.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("함초롬돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(3, 369);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(145, 27);
            this.label2.TabIndex = 52;
            this.label2.Text = "불량현황";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseMnemonic = false;
            // 
            // grid실적현황
            // 
            this.grid실적현황.AllowUserToAddRows = false;
            this.grid실적현황.AllowUserToDeleteRows = false;
            this.grid실적현황.AllowUserToResizeColumns = false;
            this.grid실적현황.AllowUserToResizeRows = false;
            this.grid실적현황.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid실적현황.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid실적현황.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid실적현황.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid실적현황.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid실적현황.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid실적현황.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid실적현황.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.실적수량,
            this.불량실적,
            this.공정명,
            this.작업자,
            this.실적등록시간});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid실적현황.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid실적현황.EnableHeadersVisualStyles = false;
            this.grid실적현황.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid실적현황.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid실적현황.Location = new System.Drawing.Point(3, 185);
            this.grid실적현황.Name = "grid실적현황";
            this.grid실적현황.ReadOnly = true;
            this.grid실적현황.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid실적현황.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid실적현황.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid실적현황.RowTemplate.Height = 23;
            this.grid실적현황.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid실적현황.Size = new System.Drawing.Size(920, 177);
            this.grid실적현황.TabIndex = 53;
            // 
            // 실적수량
            // 
            this.실적수량.HeaderText = "실적수량";
            this.실적수량.Name = "실적수량";
            this.실적수량.ReadOnly = true;
            // 
            // 불량실적
            // 
            this.불량실적.HeaderText = "불량수량";
            this.불량실적.Name = "불량실적";
            this.불량실적.ReadOnly = true;
            // 
            // 공정명
            // 
            this.공정명.HeaderText = "공정명";
            this.공정명.Name = "공정명";
            this.공정명.ReadOnly = true;
            // 
            // 작업자
            // 
            this.작업자.HeaderText = "작업자";
            this.작업자.Name = "작업자";
            this.작업자.ReadOnly = true;
            // 
            // 실적등록시간
            // 
            this.실적등록시간.HeaderText = "실적등록시간";
            this.실적등록시간.Name = "실적등록시간";
            this.실적등록시간.ReadOnly = true;
            // 
            // grid불량현황
            // 
            this.grid불량현황.AllowUserToAddRows = false;
            this.grid불량현황.AllowUserToDeleteRows = false;
            this.grid불량현황.AllowUserToResizeColumns = false;
            this.grid불량현황.AllowUserToResizeRows = false;
            this.grid불량현황.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid불량현황.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid불량현황.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid불량현황.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid불량현황.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid불량현황.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid불량현황.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.불량수량1,
            this.불량등록시간,
            this.불량_비고});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid불량현황.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid불량현황.EnableHeadersVisualStyles = false;
            this.grid불량현황.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid불량현황.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid불량현황.Location = new System.Drawing.Point(3, 395);
            this.grid불량현황.Name = "grid불량현황";
            this.grid불량현황.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid불량현황.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid불량현황.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid불량현황.RowTemplate.Height = 23;
            this.grid불량현황.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid불량현황.Size = new System.Drawing.Size(920, 153);
            this.grid불량현황.TabIndex = 54;
            // 
            // tbx생산수량
            // 
            // 
            // 
            // 
            this.tbx생산수량.CustomButton.Image = null;
            this.tbx생산수량.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.tbx생산수량.CustomButton.Name = "";
            this.tbx생산수량.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbx생산수량.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx생산수량.CustomButton.TabIndex = 1;
            this.tbx생산수량.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx생산수량.CustomButton.UseSelectable = true;
            this.tbx생산수량.CustomButton.Visible = false;
            this.tbx생산수량.Lines = new string[0];
            this.tbx생산수량.Location = new System.Drawing.Point(389, 66);
            this.tbx생산수량.MaxLength = 32767;
            this.tbx생산수량.Name = "tbx생산수량";
            this.tbx생산수량.PasswordChar = '\0';
            this.tbx생산수량.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbx생산수량.SelectedText = "";
            this.tbx생산수량.SelectionLength = 0;
            this.tbx생산수량.SelectionStart = 0;
            this.tbx생산수량.ShortcutsEnabled = true;
            this.tbx생산수량.Size = new System.Drawing.Size(154, 23);
            this.tbx생산수량.TabIndex = 55;
            this.tbx생산수량.UseSelectable = true;
            this.tbx생산수량.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx생산수량.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbx생산수량.Click += new System.EventHandler(this.Tbx생산수량_Click);
            // 
            // tbx불량수량
            // 
            // 
            // 
            // 
            this.tbx불량수량.CustomButton.Image = null;
            this.tbx불량수량.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.tbx불량수량.CustomButton.Name = "";
            this.tbx불량수량.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbx불량수량.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx불량수량.CustomButton.TabIndex = 1;
            this.tbx불량수량.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx불량수량.CustomButton.UseSelectable = true;
            this.tbx불량수량.CustomButton.Visible = false;
            this.tbx불량수량.Lines = new string[0];
            this.tbx불량수량.Location = new System.Drawing.Point(389, 89);
            this.tbx불량수량.MaxLength = 32767;
            this.tbx불량수량.Name = "tbx불량수량";
            this.tbx불량수량.PasswordChar = '\0';
            this.tbx불량수량.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbx불량수량.SelectedText = "";
            this.tbx불량수량.SelectionLength = 0;
            this.tbx불량수량.SelectionStart = 0;
            this.tbx불량수량.ShortcutsEnabled = true;
            this.tbx불량수량.Size = new System.Drawing.Size(154, 23);
            this.tbx불량수량.TabIndex = 56;
            this.tbx불량수량.UseSelectable = true;
            this.tbx불량수량.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx불량수량.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbx불량수량.Click += new System.EventHandler(this.Tbx불량수량_Click);
            // 
            // cbb공정
            // 
            this.cbb공정.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb공정.FormattingEnabled = true;
            this.cbb공정.ItemHeight = 23;
            this.cbb공정.Location = new System.Drawing.Point(933, 7);
            this.cbb공정.Name = "cbb공정";
            this.cbb공정.Size = new System.Drawing.Size(150, 29);
            this.cbb공정.TabIndex = 57;
            this.cbb공정.UseSelectable = true;
            this.cbb공정.UseStyleColors = true;
            this.cbb공정.SelectedIndexChanged += new System.EventHandler(this.Cbb공정_SelectedIndexChanged);
            // 
            // lbl벤딩생산수량
            // 
            this.lbl벤딩생산수량.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl벤딩생산수량.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl벤딩생산수량.Location = new System.Drawing.Point(687, 34);
            this.lbl벤딩생산수량.Margin = new System.Windows.Forms.Padding(1);
            this.lbl벤딩생산수량.Name = "lbl벤딩생산수량";
            this.lbl벤딩생산수량.Size = new System.Drawing.Size(42, 38);
            this.lbl벤딩생산수량.TabIndex = 59;
            this.lbl벤딩생산수량.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl드릴생산수량
            // 
            this.lbl드릴생산수량.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl드릴생산수량.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl드릴생산수량.Location = new System.Drawing.Point(731, 34);
            this.lbl드릴생산수량.Margin = new System.Windows.Forms.Padding(1);
            this.lbl드릴생산수량.Name = "lbl드릴생산수량";
            this.lbl드릴생산수량.Size = new System.Drawing.Size(42, 38);
            this.lbl드릴생산수량.TabIndex = 60;
            this.lbl드릴생산수량.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl용접생산수량
            // 
            this.lbl용접생산수량.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl용접생산수량.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl용접생산수량.Location = new System.Drawing.Point(775, 34);
            this.lbl용접생산수량.Margin = new System.Windows.Forms.Padding(1);
            this.lbl용접생산수량.Name = "lbl용접생산수량";
            this.lbl용접생산수량.Size = new System.Drawing.Size(42, 38);
            this.lbl용접생산수량.TabIndex = 61;
            this.lbl용접생산수량.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(571, 34);
            this.label12.Margin = new System.Windows.Forms.Padding(1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 38);
            this.label12.TabIndex = 67;
            this.label12.Text = "공정별 생산수량";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(642, 8);
            this.label13.Margin = new System.Windows.Forms.Padding(1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 24);
            this.label13.TabIndex = 68;
            this.label13.Text = "절단";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(730, 8);
            this.label14.Margin = new System.Windows.Forms.Padding(1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 24);
            this.label14.TabIndex = 69;
            this.label14.Text = "드릴";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(686, 8);
            this.label15.Margin = new System.Windows.Forms.Padding(1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 24);
            this.label15.TabIndex = 70;
            this.label15.Text = "벤딩";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(774, 8);
            this.label16.Margin = new System.Windows.Forms.Padding(1);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 24);
            this.label16.TabIndex = 71;
            this.label16.Text = "용접";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(529, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 38);
            this.label3.TabIndex = 72;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl절단생산수량
            // 
            this.lbl절단생산수량.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl절단생산수량.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl절단생산수량.Location = new System.Drawing.Point(642, 34);
            this.lbl절단생산수량.Margin = new System.Windows.Forms.Padding(1);
            this.lbl절단생산수량.Name = "lbl절단생산수량";
            this.lbl절단생산수량.Size = new System.Drawing.Size(42, 38);
            this.lbl절단생산수량.TabIndex = 72;
            this.lbl절단생산수량.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl절단잔량
            // 
            this.lbl절단잔량.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl절단잔량.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl절단잔량.Location = new System.Drawing.Point(642, 76);
            this.lbl절단잔량.Margin = new System.Windows.Forms.Padding(1);
            this.lbl절단잔량.Name = "lbl절단잔량";
            this.lbl절단잔량.Size = new System.Drawing.Size(42, 38);
            this.lbl절단잔량.TabIndex = 77;
            this.lbl절단잔량.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(571, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 38);
            this.label5.TabIndex = 76;
            this.label5.Text = "공정별 잔량";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl용접잔량
            // 
            this.lbl용접잔량.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl용접잔량.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl용접잔량.Location = new System.Drawing.Point(775, 76);
            this.lbl용접잔량.Margin = new System.Windows.Forms.Padding(1);
            this.lbl용접잔량.Name = "lbl용접잔량";
            this.lbl용접잔량.Size = new System.Drawing.Size(42, 38);
            this.lbl용접잔량.TabIndex = 75;
            this.lbl용접잔량.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl드릴잔량
            // 
            this.lbl드릴잔량.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl드릴잔량.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl드릴잔량.Location = new System.Drawing.Point(731, 76);
            this.lbl드릴잔량.Margin = new System.Windows.Forms.Padding(1);
            this.lbl드릴잔량.Name = "lbl드릴잔량";
            this.lbl드릴잔량.Size = new System.Drawing.Size(42, 38);
            this.lbl드릴잔량.TabIndex = 74;
            this.lbl드릴잔량.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl벤딩잔량
            // 
            this.lbl벤딩잔량.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl벤딩잔량.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl벤딩잔량.Location = new System.Drawing.Point(687, 76);
            this.lbl벤딩잔량.Margin = new System.Windows.Forms.Padding(1);
            this.lbl벤딩잔량.Name = "lbl벤딩잔량";
            this.lbl벤딩잔량.Size = new System.Drawing.Size(42, 38);
            this.lbl벤딩잔량.TabIndex = 73;
            this.lbl벤딩잔량.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl현재공정
            // 
            this.lbl현재공정.BackColor = System.Drawing.SystemColors.Control;
            this.lbl현재공정.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl현재공정.Location = new System.Drawing.Point(303, 9);
            this.lbl현재공정.Margin = new System.Windows.Forms.Padding(1);
            this.lbl현재공정.Name = "lbl현재공정";
            this.lbl현재공정.Size = new System.Drawing.Size(154, 23);
            this.lbl현재공정.TabIndex = 78;
            this.lbl현재공정.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // 불량수량1
            // 
            this.불량수량1.HeaderText = "불량수량";
            this.불량수량1.Name = "불량수량1";
            this.불량수량1.ReadOnly = true;
            // 
            // 불량등록시간
            // 
            this.불량등록시간.HeaderText = "등록시간";
            this.불량등록시간.Name = "불량등록시간";
            this.불량등록시간.ReadOnly = true;
            this.불량등록시간.Width = 150;
            // 
            // 불량_비고
            // 
            this.불량_비고.HeaderText = "비고";
            this.불량_비고.Name = "불량_비고";
            this.불량_비고.Width = 200;
            // 
            // WorkStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lbl현재공정);
            this.Controls.Add(this.lbl절단잔량);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl용접잔량);
            this.Controls.Add(this.lbl드릴잔량);
            this.Controls.Add(this.lbl벤딩잔량);
            this.Controls.Add(this.lbl절단생산수량);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl용접생산수량);
            this.Controls.Add(this.lbl드릴생산수량);
            this.Controls.Add(this.lbl벤딩생산수량);
            this.Controls.Add(this.cbb공정);
            this.Controls.Add(this.tbx불량수량);
            this.Controls.Add(this.tbx생산수량);
            this.Controls.Add(this.grid불량현황);
            this.Controls.Add(this.grid실적현황);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbIndex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn실적등록);
            this.Controls.Add(this.cbx공정완료);
            this.Controls.Add(this.btn작업종료);
            this.Controls.Add(this.lblCompleteProcess);
            this.Controls.Add(this.lbl작업시작시간);
            this.Controls.Add(this.lblStartWorkTime);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.lbl품명);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lbl지시수량);
            this.Controls.Add(this.lbl관리번호);
            this.Controls.Add(this.lbl규격);
            this.Controls.Add(this.lblPoolCount);
            this.Controls.Add(this.lblProductCount);
            this.Controls.Add(this.lblInspectCount);
            this.Controls.Add(this.lblManageNum);
            this.Controls.Add(this.lblOutside);
            this.Controls.Add(this.lbl품목번호);
            this.Controls.Add(this.lblItemNum);
            this.Name = "WorkStatus";
            this.Size = new System.Drawing.Size(1100, 551);
            this.Load += new System.EventHandler(this.WorkStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid실적현황)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid불량현황)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemNum;
        private System.Windows.Forms.Label lblOutside;
        private System.Windows.Forms.Label lblManageNum;
        private System.Windows.Forms.Label lblInspectCount;
        private System.Windows.Forms.Label lblProductCount;
        private System.Windows.Forms.Label lblPoolCount;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label lblStartWorkTime;
        private System.Windows.Forms.Label lblCompleteProcess;
        private MetroFramework.Controls.MetroButton btn작업종료;
        private MetroFramework.Controls.MetroCheckBox cbx공정완료;
        private MetroFramework.Controls.MetroButton btn실적등록;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIndex;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroGrid grid실적현황;
        private MetroFramework.Controls.MetroGrid grid불량현황;
        public System.Windows.Forms.Label lbl품목번호;
        public System.Windows.Forms.Label lbl규격;
        public System.Windows.Forms.Label lbl관리번호;
        public System.Windows.Forms.Label lbl지시수량;
        public System.Windows.Forms.Label lbl품명;
        public System.Windows.Forms.Label lbl작업시작시간;
        public MetroFramework.Controls.MetroTextBox tbx생산수량;
        public MetroFramework.Controls.MetroTextBox tbx불량수량;
        private MetroFramework.Controls.MetroComboBox cbb공정;
        private System.Windows.Forms.DataGridViewTextBoxColumn 실적수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 불량실적;
        private System.Windows.Forms.DataGridViewTextBoxColumn 공정명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 작업자;
        private System.Windows.Forms.DataGridViewTextBoxColumn 실적등록시간;
        public System.Windows.Forms.Label lbl벤딩생산수량;
        public System.Windows.Forms.Label lbl드릴생산수량;
        public System.Windows.Forms.Label lbl용접생산수량;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbl절단생산수량;
        public System.Windows.Forms.Label lbl절단잔량;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lbl용접잔량;
        public System.Windows.Forms.Label lbl드릴잔량;
        public System.Windows.Forms.Label lbl벤딩잔량;
        public System.Windows.Forms.Label lbl현재공정;
        private System.Windows.Forms.DataGridViewTextBoxColumn 불량수량1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 불량등록시간;
        private System.Windows.Forms.DataGridViewTextBoxColumn 불량_비고;
    }
}
