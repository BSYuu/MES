namespace MES
{
    partial class PlanPerform
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
            this.lblBlock = new System.Windows.Forms.Label();
            this.lblPerformDate = new System.Windows.Forms.Label();
            this.lblSHOPValue = new System.Windows.Forms.Label();
            this.lblSHOP = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblBlockValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.btnExpandCommend = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBlock
            // 
            this.lblBlock.BackColor = System.Drawing.Color.Gray;
            this.lblBlock.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBlock.ForeColor = System.Drawing.Color.White;
            this.lblBlock.Location = new System.Drawing.Point(314, 29);
            this.lblBlock.Name = "lblBlock";
            this.lblBlock.Size = new System.Drawing.Size(110, 32);
            this.lblBlock.TabIndex = 76;
            this.lblBlock.Text = "블럭";
            this.lblBlock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPerformDate
            // 
            this.lblPerformDate.BackColor = System.Drawing.Color.Gray;
            this.lblPerformDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPerformDate.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPerformDate.ForeColor = System.Drawing.Color.White;
            this.lblPerformDate.Location = new System.Drawing.Point(2, 62);
            this.lblPerformDate.Name = "lblPerformDate";
            this.lblPerformDate.Size = new System.Drawing.Size(146, 32);
            this.lblPerformDate.TabIndex = 67;
            this.lblPerformDate.Text = "실 적 일";
            this.lblPerformDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPerformDate.Click += new System.EventHandler(this.LblPerformDate_Click);
            // 
            // lblSHOPValue
            // 
            this.lblSHOPValue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSHOPValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSHOPValue.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSHOPValue.Location = new System.Drawing.Point(154, 30);
            this.lblSHOPValue.Name = "lblSHOPValue";
            this.lblSHOPValue.Size = new System.Drawing.Size(154, 32);
            this.lblSHOPValue.TabIndex = 65;
            this.lblSHOPValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSHOPValue.Click += new System.EventHandler(this.LblManagerValue1_Click);
            // 
            // lblSHOP
            // 
            this.lblSHOP.BackColor = System.Drawing.Color.Gray;
            this.lblSHOP.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSHOP.ForeColor = System.Drawing.Color.White;
            this.lblSHOP.Location = new System.Drawing.Point(2, 30);
            this.lblSHOP.Name = "lblSHOP";
            this.lblSHOP.Size = new System.Drawing.Size(146, 32);
            this.lblSHOP.TabIndex = 64;
            this.lblSHOP.Text = "SHOP";
            this.lblSHOP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDivision
            // 
            this.lblDivision.BackColor = System.Drawing.Color.Gray;
            this.lblDivision.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDivision.ForeColor = System.Drawing.Color.White;
            this.lblDivision.Location = new System.Drawing.Point(566, 65);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(118, 32);
            this.lblDivision.TabIndex = 76;
            this.lblDivision.Text = "구 분";
            this.lblDivision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlockValue
            // 
            this.lblBlockValue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBlockValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBlockValue.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBlockValue.Location = new System.Drawing.Point(430, 29);
            this.lblBlockValue.Name = "lblBlockValue";
            this.lblBlockValue.Size = new System.Drawing.Size(130, 32);
            this.lblBlockValue.TabIndex = 81;
            this.lblBlockValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("함초롬돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(145, 27);
            this.label1.TabIndex = 82;
            this.label1.Text = "계획대실적";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(154, 68);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 83;
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Location = new System.Drawing.Point(360, 68);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime2.TabIndex = 84;
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroCheckBox2.Location = new System.Drawing.Point(700, 69);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(123, 25);
            this.metroCheckBox2.TabIndex = 85;
            this.metroCheckBox2.Text = "페인트 실적";
            this.metroCheckBox2.UseCustomBackColor = true;
            this.metroCheckBox2.UseCustomForeColor = true;
            this.metroCheckBox2.UseSelectable = true;
            this.metroCheckBox2.UseStyleColors = true;
            // 
            // btnExpandCommend
            // 
            this.btnExpandCommend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(161)))));
            this.btnExpandCommend.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnExpandCommend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExpandCommend.Highlight = true;
            this.btnExpandCommend.Location = new System.Drawing.Point(842, 3);
            this.btnExpandCommend.Name = "btnExpandCommend";
            this.btnExpandCommend.Size = new System.Drawing.Size(255, 91);
            this.btnExpandCommend.TabIndex = 86;
            this.btnExpandCommend.Text = "조회";
            this.btnExpandCommend.UseCustomBackColor = true;
            this.btnExpandCommend.UseCustomForeColor = true;
            this.btnExpandCommend.UseSelectable = true;
            this.btnExpandCommend.UseStyleColors = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(3, 103);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 23;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1094, 445);
            this.metroGrid1.TabIndex = 106;
            // 
            // PlanPerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.btnExpandCommend);
            this.Controls.Add(this.metroCheckBox2);
            this.Controls.Add(this.metroDateTime2);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBlockValue);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.lblBlock);
            this.Controls.Add(this.lblPerformDate);
            this.Controls.Add(this.lblSHOPValue);
            this.Controls.Add(this.lblSHOP);
            this.Name = "PlanPerform";
            this.Size = new System.Drawing.Size(1100, 551);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBlock;
        private System.Windows.Forms.Label lblPerformDate;
        private System.Windows.Forms.Label lblSHOPValue;
        private System.Windows.Forms.Label lblSHOP;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblBlockValue;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
        private MetroFramework.Controls.MetroButton btnExpandCommend;
        private MetroFramework.Controls.MetroGrid metroGrid1;
    }
}
