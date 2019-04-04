namespace scalarFunctionProject
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.combobxTableName = new System.Windows.Forms.ComboBox();
            this.groupdataFunctionName = new System.Windows.Forms.GroupBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.buttonbtnSum = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxColName = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxResult = new System.Windows.Forms.TextBox();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.btnShowData = new System.Windows.Forms.Button();
            this.groupdataFunctionName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TableName :";
            // 
            // combobxTableName
            // 
            this.combobxTableName.FormattingEnabled = true;
            this.combobxTableName.Items.AddRange(new object[] {
            "Employee"});
            this.combobxTableName.Location = new System.Drawing.Point(227, 54);
            this.combobxTableName.Name = "combobxTableName";
            this.combobxTableName.Size = new System.Drawing.Size(505, 24);
            this.combobxTableName.TabIndex = 1;
            // 
            // groupdataFunctionName
            // 
            this.groupdataFunctionName.Controls.Add(this.btnCount);
            this.groupdataFunctionName.Controls.Add(this.btnMax);
            this.groupdataFunctionName.Controls.Add(this.btnMin);
            this.groupdataFunctionName.Controls.Add(this.btnAverage);
            this.groupdataFunctionName.Controls.Add(this.buttonbtnSum);
            this.groupdataFunctionName.Location = new System.Drawing.Point(95, 131);
            this.groupdataFunctionName.Name = "groupdataFunctionName";
            this.groupdataFunctionName.Size = new System.Drawing.Size(637, 156);
            this.groupdataFunctionName.TabIndex = 2;
            this.groupdataFunctionName.TabStop = false;
            this.groupdataFunctionName.Text = "FunctionName";
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(517, 76);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(95, 38);
            this.btnCount.TabIndex = 4;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(386, 76);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(95, 38);
            this.btnMax.TabIndex = 3;
            this.btnMax.Text = "Maximum";
            this.btnMax.UseVisualStyleBackColor = true;
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(262, 76);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(95, 38);
            this.btnMin.TabIndex = 2;
            this.btnMin.Text = "Minimam";
            this.btnMin.UseVisualStyleBackColor = true;
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(143, 76);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(95, 38);
            this.btnAverage.TabIndex = 1;
            this.btnAverage.Text = "Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            // 
            // buttonbtnSum
            // 
            this.buttonbtnSum.Location = new System.Drawing.Point(18, 76);
            this.buttonbtnSum.Name = "buttonbtnSum";
            this.buttonbtnSum.Size = new System.Drawing.Size(95, 38);
            this.buttonbtnSum.TabIndex = 0;
            this.buttonbtnSum.Text = "Sum";
            this.buttonbtnSum.UseVisualStyleBackColor = true;
            this.buttonbtnSum.Click += new System.EventHandler(this.buttonbtnSum_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ColumName :";
            // 
            // comboBoxColName
            // 
            this.comboBoxColName.FormattingEnabled = true;
            this.comboBoxColName.Items.AddRange(new object[] {
            "Employee"});
            this.comboBoxColName.Location = new System.Drawing.Point(212, 329);
            this.comboBoxColName.Name = "comboBoxColName";
            this.comboBoxColName.Size = new System.Drawing.Size(505, 24);
            this.comboBoxColName.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(282, 428);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(246, 38);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result";
            // 
            // textboxResult
            // 
            this.textboxResult.Location = new System.Drawing.Point(197, 507);
            this.textboxResult.Multiline = true;
            this.textboxResult.Name = "textboxResult";
            this.textboxResult.Size = new System.Drawing.Size(520, 39);
            this.textboxResult.TabIndex = 7;
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Location = new System.Drawing.Point(738, 131);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.RowTemplate.Height = 24;
            this.dataGridViewTable.Size = new System.Drawing.Size(526, 415);
            this.dataGridViewTable.TabIndex = 8;
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(903, 54);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(180, 38);
            this.btnShowData.TabIndex = 9;
            this.btnShowData.Text = "ShowData";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 603);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.dataGridViewTable);
            this.Controls.Add(this.textboxResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.comboBoxColName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupdataFunctionName);
            this.Controls.Add(this.combobxTableName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupdataFunctionName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combobxTableName;
        private System.Windows.Forms.GroupBox groupdataFunctionName;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button buttonbtnSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxColName;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxResult;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.Button btnShowData;
    }
}

