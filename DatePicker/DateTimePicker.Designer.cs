namespace DatePicker
{
    partial class DateTimePicker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.top_Panel = new System.Windows.Forms.Panel();
            this.lbl_CurrentCalendarDate = new System.Windows.Forms.Label();
            this.btn_LastMonth = new System.Windows.Forms.Button();
            this.btn_LastYear = new System.Windows.Forms.Button();
            this.btn_NextMonth = new System.Windows.Forms.Button();
            this.btn_NextYear = new System.Windows.Forms.Button();
            this.buttom_Panel = new System.Windows.Forms.Panel();
            this.btn_GoToToday = new System.Windows.Forms.Button();
            this.btn_SelecedDate = new System.Windows.Forms.Button();
            this.lbl_SelectedDate = new System.Windows.Forms.Label();
            this.dgv_Calenar = new System.Windows.Forms.DataGridView();
            this.Day1Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day2Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day3Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day4Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day5Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day6Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day7Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.top_Panel.SuspendLayout();
            this.buttom_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Calenar)).BeginInit();
            this.SuspendLayout();
            // 
            // top_Panel
            // 
            this.top_Panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.top_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.top_Panel.Controls.Add(this.lbl_CurrentCalendarDate);
            this.top_Panel.Controls.Add(this.btn_LastMonth);
            this.top_Panel.Controls.Add(this.btn_LastYear);
            this.top_Panel.Controls.Add(this.btn_NextMonth);
            this.top_Panel.Controls.Add(this.btn_NextYear);
            this.top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_Panel.Location = new System.Drawing.Point(0, 0);
            this.top_Panel.Name = "top_Panel";
            this.top_Panel.Size = new System.Drawing.Size(497, 30);
            this.top_Panel.TabIndex = 0;
            // 
            // lbl_CurrentCalendarDate
            // 
            this.lbl_CurrentCalendarDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CurrentCalendarDate.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_CurrentCalendarDate.Location = new System.Drawing.Point(174, 3);
            this.lbl_CurrentCalendarDate.Name = "lbl_CurrentCalendarDate";
            this.lbl_CurrentCalendarDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_CurrentCalendarDate.Size = new System.Drawing.Size(146, 23);
            this.lbl_CurrentCalendarDate.TabIndex = 4;
            this.lbl_CurrentCalendarDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_LastMonth
            // 
            this.btn_LastMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LastMonth.BackColor = System.Drawing.Color.White;
            this.btn_LastMonth.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_LastMonth.Location = new System.Drawing.Point(334, 2);
            this.btn_LastMonth.Name = "btn_LastMonth";
            this.btn_LastMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_LastMonth.Size = new System.Drawing.Size(75, 25);
            this.btn_LastMonth.TabIndex = 3;
            this.btn_LastMonth.Text = "ماه قبل";
            this.btn_LastMonth.UseVisualStyleBackColor = false;
            this.btn_LastMonth.Click += new System.EventHandler(this.btn_LastMonth_Click);
            // 
            // btn_LastYear
            // 
            this.btn_LastYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LastYear.BackColor = System.Drawing.Color.White;
            this.btn_LastYear.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_LastYear.Location = new System.Drawing.Point(417, 2);
            this.btn_LastYear.Name = "btn_LastYear";
            this.btn_LastYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_LastYear.Size = new System.Drawing.Size(75, 25);
            this.btn_LastYear.TabIndex = 2;
            this.btn_LastYear.Text = "سال قبل";
            this.btn_LastYear.UseVisualStyleBackColor = false;
            this.btn_LastYear.Click += new System.EventHandler(this.btn_LastYear_Click);
            // 
            // btn_NextMonth
            // 
            this.btn_NextMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NextMonth.BackColor = System.Drawing.Color.White;
            this.btn_NextMonth.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_NextMonth.Location = new System.Drawing.Point(81, 2);
            this.btn_NextMonth.Name = "btn_NextMonth";
            this.btn_NextMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_NextMonth.Size = new System.Drawing.Size(75, 25);
            this.btn_NextMonth.TabIndex = 1;
            this.btn_NextMonth.Text = "ماه بعد";
            this.btn_NextMonth.UseVisualStyleBackColor = false;
            this.btn_NextMonth.Click += new System.EventHandler(this.btn_NextMonth_Click);
            // 
            // btn_NextYear
            // 
            this.btn_NextYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_NextYear.BackColor = System.Drawing.Color.White;
            this.btn_NextYear.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_NextYear.Location = new System.Drawing.Point(3, 2);
            this.btn_NextYear.Name = "btn_NextYear";
            this.btn_NextYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_NextYear.Size = new System.Drawing.Size(75, 25);
            this.btn_NextYear.TabIndex = 0;
            this.btn_NextYear.Text = "سال بعد";
            this.btn_NextYear.UseVisualStyleBackColor = false;
            this.btn_NextYear.Click += new System.EventHandler(this.btn_NextYear_Click);
            // 
            // buttom_Panel
            // 
            this.buttom_Panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttom_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttom_Panel.Controls.Add(this.btn_GoToToday);
            this.buttom_Panel.Controls.Add(this.btn_SelecedDate);
            this.buttom_Panel.Controls.Add(this.lbl_SelectedDate);
            this.buttom_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttom_Panel.Location = new System.Drawing.Point(0, 185);
            this.buttom_Panel.Name = "buttom_Panel";
            this.buttom_Panel.Size = new System.Drawing.Size(497, 30);
            this.buttom_Panel.TabIndex = 1;
            // 
            // btn_GoToToday
            // 
            this.btn_GoToToday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GoToToday.BackColor = System.Drawing.Color.White;
            this.btn_GoToToday.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_GoToToday.Location = new System.Drawing.Point(417, 2);
            this.btn_GoToToday.Name = "btn_GoToToday";
            this.btn_GoToToday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_GoToToday.Size = new System.Drawing.Size(75, 25);
            this.btn_GoToToday.TabIndex = 6;
            this.btn_GoToToday.Text = "تاریخ امروز";
            this.btn_GoToToday.UseVisualStyleBackColor = false;
            this.btn_GoToToday.Click += new System.EventHandler(this.btn_GoToToday_Click);
            // 
            // btn_SelecedDate
            // 
            this.btn_SelecedDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_SelecedDate.BackColor = System.Drawing.Color.White;
            this.btn_SelecedDate.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_SelecedDate.Location = new System.Drawing.Point(3, 2);
            this.btn_SelecedDate.Name = "btn_SelecedDate";
            this.btn_SelecedDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_SelecedDate.Size = new System.Drawing.Size(75, 25);
            this.btn_SelecedDate.TabIndex = 5;
            this.btn_SelecedDate.Text = "تاریخ انتخابی";
            this.btn_SelecedDate.UseVisualStyleBackColor = false;
            this.btn_SelecedDate.Click += new System.EventHandler(this.btn_SelecedDate_Click);
            // 
            // lbl_SelectedDate
            // 
            this.lbl_SelectedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SelectedDate.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_SelectedDate.Location = new System.Drawing.Point(177, 2);
            this.lbl_SelectedDate.Name = "lbl_SelectedDate";
            this.lbl_SelectedDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_SelectedDate.Size = new System.Drawing.Size(143, 23);
            this.lbl_SelectedDate.TabIndex = 5;
            this.lbl_SelectedDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_Calenar
            // 
            this.dgv_Calenar.AllowUserToAddRows = false;
            this.dgv_Calenar.AllowUserToDeleteRows = false;
            this.dgv_Calenar.AllowUserToResizeColumns = false;
            this.dgv_Calenar.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgv_Calenar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Calenar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Calenar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Calenar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Calenar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Calenar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Calenar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Calenar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Calenar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Calenar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day1Column1,
            this.Day2Column1,
            this.Day3Column1,
            this.Day4Column1,
            this.Day5Column1,
            this.Day6Column1,
            this.Day7Column1});
            this.dgv_Calenar.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Calenar.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_Calenar.Location = new System.Drawing.Point(0, 30);
            this.dgv_Calenar.MultiSelect = false;
            this.dgv_Calenar.Name = "dgv_Calenar";
            this.dgv_Calenar.ReadOnly = true;
            this.dgv_Calenar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_Calenar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Calenar.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_Calenar.RowHeadersVisible = false;
            this.dgv_Calenar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgv_Calenar.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_Calenar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_Calenar.Size = new System.Drawing.Size(497, 155);
            this.dgv_Calenar.TabIndex = 2;
            // 
            // Day1Column1
            // 
            this.Day1Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Day1Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Day1Column1.HeaderText = "شنبه";
            this.Day1Column1.Name = "Day1Column1";
            this.Day1Column1.ReadOnly = true;
            this.Day1Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Day1Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Day2Column1
            // 
            this.Day2Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Day2Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Day2Column1.HeaderText = "یکشنبه";
            this.Day2Column1.Name = "Day2Column1";
            this.Day2Column1.ReadOnly = true;
            this.Day2Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Day2Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Day3Column1
            // 
            this.Day3Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Day3Column1.DefaultCellStyle = dataGridViewCellStyle5;
            this.Day3Column1.HeaderText = "دوشنبه";
            this.Day3Column1.Name = "Day3Column1";
            this.Day3Column1.ReadOnly = true;
            this.Day3Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Day3Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Day4Column1
            // 
            this.Day4Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Day4Column1.DefaultCellStyle = dataGridViewCellStyle6;
            this.Day4Column1.HeaderText = "سه شنبه";
            this.Day4Column1.Name = "Day4Column1";
            this.Day4Column1.ReadOnly = true;
            this.Day4Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Day4Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Day5Column1
            // 
            this.Day5Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Day5Column1.DefaultCellStyle = dataGridViewCellStyle7;
            this.Day5Column1.HeaderText = "چهارشنبه";
            this.Day5Column1.Name = "Day5Column1";
            this.Day5Column1.ReadOnly = true;
            this.Day5Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Day5Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Day6Column1
            // 
            this.Day6Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Day6Column1.DefaultCellStyle = dataGridViewCellStyle8;
            this.Day6Column1.HeaderText = "پنجشنبه";
            this.Day6Column1.Name = "Day6Column1";
            this.Day6Column1.ReadOnly = true;
            this.Day6Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Day6Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Day7Column1
            // 
            this.Day7Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Day7Column1.DefaultCellStyle = dataGridViewCellStyle9;
            this.Day7Column1.HeaderText = "جمعه";
            this.Day7Column1.Name = "Day7Column1";
            this.Day7Column1.ReadOnly = true;
            this.Day7Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Day7Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_Calenar);
            this.Controls.Add(this.buttom_Panel);
            this.Controls.Add(this.top_Panel);
            this.Name = "DateTimePicker";
            this.Size = new System.Drawing.Size(497, 215);
            this.Load += new System.EventHandler(this.DateTimePicker_Load);
            this.top_Panel.ResumeLayout(false);
            this.buttom_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Calenar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_Panel;
        private System.Windows.Forms.Panel buttom_Panel;
        private System.Windows.Forms.DataGridView dgv_Calenar;
        private System.Windows.Forms.Button btn_LastMonth;
        private System.Windows.Forms.Button btn_LastYear;
        private System.Windows.Forms.Button btn_NextMonth;
        private System.Windows.Forms.Button btn_NextYear;
        private System.Windows.Forms.Label lbl_CurrentCalendarDate;
        private System.Windows.Forms.Label lbl_SelectedDate;
        private System.Windows.Forms.Button btn_GoToToday;
        private System.Windows.Forms.Button btn_SelecedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day1Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day2Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day3Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day4Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day5Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day6Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day7Column1;
    }
}
