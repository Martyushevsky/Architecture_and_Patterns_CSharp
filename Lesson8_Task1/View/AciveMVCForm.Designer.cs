namespace ActiveMVC
{
    partial class ActiveMVCForm
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
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.buttonIncrementValue = new System.Windows.Forms.Button();
            this.labelValue = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(12, 36);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(214, 20);
            this.textBoxValue.TabIndex = 0;
            // 
            // buttonIncrementValue
            // 
            this.buttonIncrementValue.Location = new System.Drawing.Point(13, 84);
            this.buttonIncrementValue.Name = "buttonIncrementValue";
            this.buttonIncrementValue.Size = new System.Drawing.Size(126, 23);
            this.buttonIncrementValue.TabIndex = 1;
            this.buttonIncrementValue.Text = "Добавить строку";
            this.buttonIncrementValue.UseVisualStyleBackColor = true;
            this.buttonIncrementValue.Click += new System.EventHandler(this.ButtonAddString_Click);
            
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(13, 17);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(55, 13);
            this.labelValue.TabIndex = 2;
            this.labelValue.Text = "Значение";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 143);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(214, 173);
            this.listBox.TabIndex = 3;
            // 
            // ActiveMVCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 388);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.buttonIncrementValue);
            this.Controls.Add(this.textBoxValue);
            this.Name = "ActiveMVCForm";
            this.Text = "ActiveMVC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Button buttonIncrementValue;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.ListBox listBox;
    }
}

