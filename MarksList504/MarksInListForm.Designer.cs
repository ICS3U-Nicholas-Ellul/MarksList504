namespace MarksList504
{
    partial class frmMarksInList
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
            this.lstMarks = new System.Windows.Forms.ListBox();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.nudInput = new System.Windows.Forms.NumericUpDown();
            this.btnClearList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudInput)).BeginInit();
            this.SuspendLayout();
            // 
            // lstMarks
            // 
            this.lstMarks.FormattingEnabled = true;
            this.lstMarks.Location = new System.Drawing.Point(82, 44);
            this.lstMarks.Name = "lstMarks";
            this.lstMarks.Size = new System.Drawing.Size(120, 95);
            this.lstMarks.TabIndex = 0;
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(82, 195);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(120, 23);
            this.btnAddToList.TabIndex = 1;
            this.btnAddToList.Text = "Add to List";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(82, 262);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(120, 54);
            this.btnAverage.TabIndex = 3;
            this.btnAverage.Text = "Calculate Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // nudInput
            // 
            this.nudInput.Location = new System.Drawing.Point(82, 159);
            this.nudInput.Name = "nudInput";
            this.nudInput.Size = new System.Drawing.Size(120, 20);
            this.nudInput.TabIndex = 4;
            this.nudInput.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(82, 233);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(120, 23);
            this.btnClearList.TabIndex = 5;
            this.btnClearList.Text = "Clear";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // frmMarksInList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 341);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.nudInput);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnAddToList);
            this.Controls.Add(this.lstMarks);
            this.Name = "frmMarksInList";
            this.Text = "Mark Program";
            ((System.ComponentModel.ISupportInitialize)(this.nudInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstMarks;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.NumericUpDown nudInput;
        private System.Windows.Forms.Button btnClearList;
    }
}

