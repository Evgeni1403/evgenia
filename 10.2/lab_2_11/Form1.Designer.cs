namespace lab_2_11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rubleTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.euroRadioButton = new System.Windows.Forms.RadioButton();
            this.dollarRadioButton = new System.Windows.Forms.RadioButton();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Рубли";
            // 
            // rubleTextBox
            // 
            this.rubleTextBox.Location = new System.Drawing.Point(12, 26);
            this.rubleTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rubleTextBox.Name = "rubleTextBox";
            this.rubleTextBox.Size = new System.Drawing.Size(228, 20);
            this.rubleTextBox.TabIndex = 1;
            this.rubleTextBox.TextChanged += new System.EventHandler(this.rubleTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dollarRadioButton);
            this.groupBox1.Controls.Add(this.euroRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(10, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(230, 71);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Валюты";
            // 
            // euroRadioButton
            // 
            this.euroRadioButton.AutoSize = true;
            this.euroRadioButton.Location = new System.Drawing.Point(8, 20);
            this.euroRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.euroRadioButton.Name = "euroRadioButton";
            this.euroRadioButton.Size = new System.Drawing.Size(50, 17);
            this.euroRadioButton.TabIndex = 0;
            this.euroRadioButton.TabStop = true;
            this.euroRadioButton.Text = "Евро";
            this.euroRadioButton.UseVisualStyleBackColor = true;
            this.euroRadioButton.CheckedChanged += new System.EventHandler(this.euroRadioButton_CheckedChanged);
            // 
            // dollarRadioButton
            // 
            this.dollarRadioButton.AutoSize = true;
            this.dollarRadioButton.Location = new System.Drawing.Point(8, 45);
            this.dollarRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dollarRadioButton.Name = "dollarRadioButton";
            this.dollarRadioButton.Size = new System.Drawing.Size(64, 17);
            this.dollarRadioButton.TabIndex = 1;
            this.dollarRadioButton.TabStop = true;
            this.dollarRadioButton.Text = "Доллар";
            this.dollarRadioButton.UseVisualStyleBackColor = true;
            this.dollarRadioButton.CheckedChanged += new System.EventHandler(this.dollarRadioButton_CheckedChanged);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(12, 143);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(228, 20);
            this.resultTextBox.TabIndex = 4;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(12, 126);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(37, 13);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Рубли";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 173);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rubleTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(270, 212);
            this.MinimumSize = new System.Drawing.Size(270, 212);
            this.Name = "Form1";
            this.Text = "Валюта";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rubleTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton dollarRadioButton;
        private System.Windows.Forms.RadioButton euroRadioButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label resultLabel;
    }
}

