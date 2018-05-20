namespace Lesson8_Task1
{
    partial class FormView
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
            this.InputField = new System.Windows.Forms.TextBox();
            this.DataListBox = new System.Windows.Forms.ListBox();
            this.LoadData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputField
            // 
            this.InputField.Location = new System.Drawing.Point(12, 12);
            this.InputField.Name = "InputField";
            this.InputField.Size = new System.Drawing.Size(260, 20);
            this.InputField.TabIndex = 0;
            this.InputField.Leave += new System.EventHandler(this.InputField_Leave);
            // 
            // DataListBox
            // 
            this.DataListBox.FormattingEnabled = true;
            this.DataListBox.Location = new System.Drawing.Point(12, 67);
            this.DataListBox.Name = "DataListBox";
            this.DataListBox.Size = new System.Drawing.Size(260, 186);
            this.DataListBox.TabIndex = 1;
            // 
            // LoadData
            // 
            this.LoadData.Location = new System.Drawing.Point(12, 38);
            this.LoadData.Name = "LoadData";
            this.LoadData.Size = new System.Drawing.Size(260, 23);
            this.LoadData.TabIndex = 2;
            this.LoadData.Text = "Load data";
            this.LoadData.UseVisualStyleBackColor = true;
            this.LoadData.Click += new System.EventHandler(this.LoadData_Click);
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LoadData);
            this.Controls.Add(this.DataListBox);
            this.Controls.Add(this.InputField);
            this.Name = "FormView";
            this.Text = "FormView";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox InputField;
        private System.Windows.Forms.ListBox DataListBox;
        private System.Windows.Forms.Button LoadData;
    }
}

