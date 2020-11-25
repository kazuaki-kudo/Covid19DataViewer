namespace Covid19DataViewer
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonDownloadCancel = new System.Windows.Forms.Button();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.textBoxConfirmed = new System.Windows.Forms.TextBox();
            this.textBoxDeaths = new System.Windows.Forms.TextBox();
            this.textBoxRecovered = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConfirmed = new System.Windows.Forms.Button();
            this.buttonDeaths = new System.Windows.Forms.Button();
            this.buttonRecovered = new System.Windows.Forms.Button();
            this.comboBoxArea = new System.Windows.Forms.ComboBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.buttonRead = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(44, 219);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(75, 23);
            this.buttonDownload.TabIndex = 13;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonDownloadCancel
            // 
            this.buttonDownloadCancel.Location = new System.Drawing.Point(44, 248);
            this.buttonDownloadCancel.Name = "buttonDownloadCancel";
            this.buttonDownloadCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonDownloadCancel.TabIndex = 14;
            this.buttonDownloadCancel.Text = "Cancel";
            this.buttonDownloadCancel.UseVisualStyleBackColor = true;
            this.buttonDownloadCancel.Click += new System.EventHandler(this.buttonDownloadCancel_Click);
            // 
            // listBoxLog
            // 
            this.listBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.HorizontalScrollbar = true;
            this.listBoxLog.Location = new System.Drawing.Point(3, 291);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.ScrollAlwaysVisible = true;
            this.listBoxLog.Size = new System.Drawing.Size(617, 147);
            this.listBoxLog.TabIndex = 12;
            // 
            // textBoxConfirmed
            // 
            this.textBoxConfirmed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConfirmed.Location = new System.Drawing.Point(12, 25);
            this.textBoxConfirmed.MaxLength = 512;
            this.textBoxConfirmed.Name = "textBoxConfirmed";
            this.textBoxConfirmed.ReadOnly = true;
            this.textBoxConfirmed.Size = new System.Drawing.Size(260, 20);
            this.textBoxConfirmed.TabIndex = 1;
            this.textBoxConfirmed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxConfirmed.WordWrap = false;
            // 
            // textBoxDeaths
            // 
            this.textBoxDeaths.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDeaths.Location = new System.Drawing.Point(12, 65);
            this.textBoxDeaths.MaxLength = 512;
            this.textBoxDeaths.Name = "textBoxDeaths";
            this.textBoxDeaths.ReadOnly = true;
            this.textBoxDeaths.Size = new System.Drawing.Size(260, 20);
            this.textBoxDeaths.TabIndex = 4;
            this.textBoxDeaths.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDeaths.WordWrap = false;
            // 
            // textBoxRecovered
            // 
            this.textBoxRecovered.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRecovered.Location = new System.Drawing.Point(12, 105);
            this.textBoxRecovered.MaxLength = 512;
            this.textBoxRecovered.Name = "textBoxRecovered";
            this.textBoxRecovered.ReadOnly = true;
            this.textBoxRecovered.Size = new System.Drawing.Size(260, 20);
            this.textBoxRecovered.TabIndex = 7;
            this.textBoxRecovered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxRecovered.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirmed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Deaths";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Recovered";
            // 
            // buttonConfirmed
            // 
            this.buttonConfirmed.Location = new System.Drawing.Point(275, 23);
            this.buttonConfirmed.Name = "buttonConfirmed";
            this.buttonConfirmed.Size = new System.Drawing.Size(30, 23);
            this.buttonConfirmed.TabIndex = 2;
            this.buttonConfirmed.Text = "...";
            this.buttonConfirmed.UseVisualStyleBackColor = true;
            this.buttonConfirmed.Click += new System.EventHandler(this.buttonConfirmed_Click);
            // 
            // buttonDeaths
            // 
            this.buttonDeaths.Location = new System.Drawing.Point(275, 63);
            this.buttonDeaths.Name = "buttonDeaths";
            this.buttonDeaths.Size = new System.Drawing.Size(30, 23);
            this.buttonDeaths.TabIndex = 5;
            this.buttonDeaths.Text = "...";
            this.buttonDeaths.UseVisualStyleBackColor = true;
            this.buttonDeaths.Click += new System.EventHandler(this.buttonDeaths_Click);
            // 
            // buttonRecovered
            // 
            this.buttonRecovered.Location = new System.Drawing.Point(275, 103);
            this.buttonRecovered.Name = "buttonRecovered";
            this.buttonRecovered.Size = new System.Drawing.Size(30, 23);
            this.buttonRecovered.TabIndex = 8;
            this.buttonRecovered.Text = "...";
            this.buttonRecovered.UseVisualStyleBackColor = true;
            this.buttonRecovered.Click += new System.EventHandler(this.buttonRecovered_Click);
            // 
            // comboBoxArea
            // 
            this.comboBoxArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxArea.Enabled = false;
            this.comboBoxArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxArea.FormattingEnabled = true;
            this.comboBoxArea.Location = new System.Drawing.Point(8, 62);
            this.comboBoxArea.Name = "comboBoxArea";
            this.comboBoxArea.Size = new System.Drawing.Size(280, 28);
            this.comboBoxArea.TabIndex = 1;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.Enabled = false;
            this.comboBoxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(8, 22);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(280, 28);
            this.comboBoxCountry.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboBoxCountry);
            this.groupBox1.Controls.Add(this.comboBoxArea);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(326, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 103);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Region selection";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dateTimePickerEnd);
            this.groupBox2.Controls.Add(this.dateTimePickerStart);
            this.groupBox2.Controls.Add(this.labelEnd);
            this.groupBox2.Controls.Add(this.labelStart);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(464, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 121);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date selection";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerStart.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerStart.Enabled = false;
            this.dateTimePickerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(9, 34);
            this.dateTimePickerStart.MinDate = new System.DateTime(2020, 1, 22, 0, 0, 0, 0);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(140, 26);
            this.dateTimePickerStart.TabIndex = 1;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerEnd.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerEnd.Enabled = false;
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(9, 82);
            this.dateTimePickerEnd.MinDate = new System.DateTime(2020, 1, 22, 0, 0, 0, 0);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(140, 26);
            this.dateTimePickerEnd.TabIndex = 3;
            // 
            // labelStart
            // 
            this.labelStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStart.AutoSize = true;
            this.labelStart.Enabled = false;
            this.labelStart.Location = new System.Drawing.Point(12, 16);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(29, 13);
            this.labelStart.TabIndex = 0;
            this.labelStart.Text = "Start";
            // 
            // labelEnd
            // 
            this.labelEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEnd.AutoSize = true;
            this.labelEnd.Enabled = false;
            this.labelEnd.Location = new System.Drawing.Point(12, 66);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(26, 13);
            this.labelEnd.TabIndex = 2;
            this.labelEnd.Text = "End";
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(230, 137);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 23);
            this.buttonRead.TabIndex = 9;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonRecovered);
            this.Controls.Add(this.buttonDeaths);
            this.Controls.Add(this.buttonConfirmed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRecovered);
            this.Controls.Add(this.textBoxDeaths);
            this.Controls.Add(this.textBoxConfirmed);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.buttonDownloadCancel);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonDownloadCancel;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.TextBox textBoxConfirmed;
        private System.Windows.Forms.TextBox textBoxDeaths;
        private System.Windows.Forms.TextBox textBoxRecovered;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonConfirmed;
        private System.Windows.Forms.Button buttonDeaths;
        private System.Windows.Forms.Button buttonRecovered;
        private System.Windows.Forms.ComboBox comboBoxArea;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Button buttonRead;
    }
}

