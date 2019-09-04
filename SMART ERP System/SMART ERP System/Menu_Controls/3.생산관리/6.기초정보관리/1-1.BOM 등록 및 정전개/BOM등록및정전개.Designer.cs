namespace SMART_ERP_System.MenuUserControl
{
    partial class BOM등록및정전개
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.검색btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.자재번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.공정순서 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.모품목 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txb자재 = new System.Windows.Forms.TextBox();
            this.txb자재명 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxJo = new System.Windows.Forms.ComboBox();
            this.cbxLocal = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txbPrentM = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txbProcessNum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbQty = new System.Windows.Forms.TextBox();
            this.txbMaterialName = new System.Windows.Forms.TextBox();
            this.txbMaterialNum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1018, 1);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.검색btn);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnCopy);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(7, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "▷▶▷▶";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(297, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 9;
            // 
            // 검색btn
            // 
            this.검색btn.Location = new System.Drawing.Point(191, 17);
            this.검색btn.Name = "검색btn";
            this.검색btn.Size = new System.Drawing.Size(41, 24);
            this.검색btn.TabIndex = 3;
            this.검색btn.Text = "검색";
            this.검색btn.UseVisualStyleBackColor = true;
            this.검색btn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(403, 20);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(74, 18);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "BOM 복사";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "제품번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(51, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "BOM등록 및 정전개";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 146);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 478F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 478F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1016, 478);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowDrop = true;
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.자재번호,
            this.수량,
            this.공정순서,
            this.모품목});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(502, 472);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGridView2_CellBeginEdit);
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellEndEdit);
            this.dataGridView2.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellEnter);
            this.dataGridView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView2_KeyDown);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 45;
            // 
            // 자재번호
            // 
            this.자재번호.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.자재번호.HeaderText = "자재번호";
            this.자재번호.Name = "자재번호";
            this.자재번호.ReadOnly = true;
            this.자재번호.Width = 140;
            // 
            // 수량
            // 
            this.수량.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.수량.HeaderText = "수량";
            this.수량.Name = "수량";
            this.수량.ReadOnly = true;
            this.수량.Width = 65;
            // 
            // 공정순서
            // 
            this.공정순서.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.공정순서.HeaderText = "공정순서";
            this.공정순서.Name = "공정순서";
            this.공정순서.ReadOnly = true;
            this.공정순서.Width = 65;
            // 
            // 모품목
            // 
            this.모품목.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.모품목.HeaderText = "모품목";
            this.모품목.Name = "모품목";
            this.모품목.ReadOnly = true;
            this.모품목.Width = 140;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(511, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(248, 470);
            this.treeView1.TabIndex = 12;
            this.treeView1.Click += new System.EventHandler(this.TreeView1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txb자재);
            this.groupBox2.Controls.Add(this.txb자재명);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbxJo);
            this.groupBox2.Controls.Add(this.cbxLocal);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txbPrentM);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txbPrice);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txbProcessNum);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txbQty);
            this.groupBox2.Controls.Add(this.txbMaterialName);
            this.groupBox2.Controls.Add(this.txbMaterialNum);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(765, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 470);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "속성변경";
            // 
            // txb자재
            // 
            this.txb자재.Location = new System.Drawing.Point(53, 66);
            this.txb자재.Name = "txb자재";
            this.txb자재.Size = new System.Drawing.Size(188, 21);
            this.txb자재.TabIndex = 38;
            // 
            // txb자재명
            // 
            this.txb자재명.AutoSize = true;
            this.txb자재명.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txb자재명.Location = new System.Drawing.Point(7, 69);
            this.txb자재명.Name = "txb자재명";
            this.txb자재명.Size = new System.Drawing.Size(31, 12);
            this.txb자재명.TabIndex = 37;
            this.txb자재명.Text = "자재";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(7, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 12);
            this.label9.TabIndex = 36;
            this.label9.Text = "조   달";
            // 
            // cbxJo
            // 
            this.cbxJo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxJo.FormattingEnabled = true;
            this.cbxJo.Location = new System.Drawing.Point(53, 235);
            this.cbxJo.Name = "cbxJo";
            this.cbxJo.Size = new System.Drawing.Size(58, 20);
            this.cbxJo.TabIndex = 35;
            // 
            // cbxLocal
            // 
            this.cbxLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLocal.FormattingEnabled = true;
            this.cbxLocal.Location = new System.Drawing.Point(53, 209);
            this.cbxLocal.Name = "cbxLocal";
            this.cbxLocal.Size = new System.Drawing.Size(58, 20);
            this.cbxLocal.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(7, 212);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 12);
            this.label15.TabIndex = 32;
            this.label15.Text = "단   위";
            // 
            // txbPrentM
            // 
            this.txbPrentM.Location = new System.Drawing.Point(53, 142);
            this.txbPrentM.Name = "txbPrentM";
            this.txbPrentM.Size = new System.Drawing.Size(188, 21);
            this.txbPrentM.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(6, 146);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 12);
            this.label17.TabIndex = 23;
            this.label17.Text = "모품목";
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(53, 182);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.ReadOnly = true;
            this.txbPrice.Size = new System.Drawing.Size(58, 21);
            this.txbPrice.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(7, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 12);
            this.label16.TabIndex = 21;
            this.label16.Text = "단   가";
            // 
            // txbProcessNum
            // 
            this.txbProcessNum.Location = new System.Drawing.Point(184, 118);
            this.txbProcessNum.Name = "txbProcessNum";
            this.txbProcessNum.Size = new System.Drawing.Size(58, 21);
            this.txbProcessNum.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(125, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 12);
            this.label11.TabIndex = 19;
            this.label11.Text = "공정순서";
            // 
            // txbQty
            // 
            this.txbQty.Location = new System.Drawing.Point(53, 117);
            this.txbQty.Name = "txbQty";
            this.txbQty.Size = new System.Drawing.Size(74, 21);
            this.txbQty.TabIndex = 10;
            // 
            // txbMaterialName
            // 
            this.txbMaterialName.Location = new System.Drawing.Point(53, 93);
            this.txbMaterialName.Name = "txbMaterialName";
            this.txbMaterialName.ReadOnly = true;
            this.txbMaterialName.Size = new System.Drawing.Size(188, 21);
            this.txbMaterialName.TabIndex = 8;
            // 
            // txbMaterialNum
            // 
            this.txbMaterialNum.Location = new System.Drawing.Point(53, 36);
            this.txbMaterialNum.Name = "txbMaterialNum";
            this.txbMaterialNum.ReadOnly = true;
            this.txbMaterialNum.Size = new System.Drawing.Size(188, 21);
            this.txbMaterialNum.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(6, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 12);
            this.label12.TabIndex = 5;
            this.label12.Text = "수   량";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(6, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "품   명";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(6, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "품   번";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(514, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "공정 순서도";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(10, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "BOM정전개";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(951, 115);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(74, 25);
            this.btnupdate.TabIndex = 11;
            this.btnupdate.Text = "등록";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(871, 115);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(74, 25);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "삭제";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.Button2_Click);
            // 
            // BOM등록및정전개
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BOM등록및정전개";
            this.Size = new System.Drawing.Size(1044, 645);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button 검색btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn 자재번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 공정순서;
        private System.Windows.Forms.DataGridViewTextBoxColumn 모품목;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbQty;
        private System.Windows.Forms.TextBox txbMaterialName;
        private System.Windows.Forms.TextBox txbMaterialNum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.ComboBox cbxLocal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txbPrentM;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txbProcessNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxJo;
        private System.Windows.Forms.TextBox txb자재;
        private System.Windows.Forms.Label txb자재명;
    }
}
