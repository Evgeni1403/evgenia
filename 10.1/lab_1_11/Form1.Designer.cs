namespace lab_1_11
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
            this.R1Label = new System.Windows.Forms.Label();
            this.R2Label2 = new System.Windows.Forms.Label();
            this.R3Label = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.R1TextBox = new System.Windows.Forms.TextBox();
            this.R2TextBox = new System.Windows.Forms.TextBox();
            this.R3TextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // R1Label
            // 
            this.R1Label.AutoSize = true;
            this.R1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold);
            this.R1Label.Location = new System.Drawing.Point(12, 24);
            this.R1Label.Name = "R1Label";
            this.R1Label.Size = new System.Drawing.Size(35, 22);
            this.R1Label.TabIndex = 0;
            this.R1Label.Text = "R1";
            // 
            // R2Label2
            // 
            this.R2Label2.AutoSize = true;
            this.R2Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold);
            this.R2Label2.Location = new System.Drawing.Point(12, 50);
            this.R2Label2.Name = "R2Label2";
            this.R2Label2.Size = new System.Drawing.Size(35, 22);
            this.R2Label2.TabIndex = 1;
            this.R2Label2.Text = "R2";
            // 
            // R3Label
            // 
            this.R3Label.AutoSize = true;
            this.R3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold);
            this.R3Label.Location = new System.Drawing.Point(12, 76);
            this.R3Label.Name = "R3Label";
            this.R3Label.Size = new System.Drawing.Size(35, 22);
            this.R3Label.TabIndex = 2;
            this.R3Label.Text = "R3";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.calculateButton.Location = new System.Drawing.Point(12, 103);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(141, 32);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Вычислить";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // R1TextBox
            // 
            this.R1TextBox.Location = new System.Drawing.Point(53, 26);
            this.R1TextBox.Name = "R1TextBox";
            this.R1TextBox.Size = new System.Drawing.Size(100, 20);
            this.R1TextBox.TabIndex = 4;
            // 
            // R2TextBox
            // 
            this.R2TextBox.Location = new System.Drawing.Point(53, 51);
            this.R2TextBox.Name = "R2TextBox";
            this.R2TextBox.Size = new System.Drawing.Size(100, 20);
            this.R2TextBox.TabIndex = 5;
            // 
            // R3TextBox
            // 
            this.R3TextBox.Location = new System.Drawing.Point(53, 77);
            this.R3TextBox.Name = "R3TextBox";
            this.R3TextBox.Size = new System.Drawing.Size(100, 20);
            this.R3TextBox.TabIndex = 6;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold);
            this.resultLabel.Location = new System.Drawing.Point(12, 147);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 22);
            this.resultLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 216);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.R3TextBox);
            this.Controls.Add(this.R2TextBox);
            this.Controls.Add(this.R1TextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.R3Label);
            this.Controls.Add(this.R2Label2);
            this.Controls.Add(this.R1Label);
            this.MaximumSize = new System.Drawing.Size(185, 255);
            this.MinimumSize = new System.Drawing.Size(185, 255);
            this.Name = "Form1";
            this.Text = "Сопротивление";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label R1Label;
        private System.Windows.Forms.Label R2Label2;
        private System.Windows.Forms.Label R3Label;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox R1TextBox;
        private System.Windows.Forms.TextBox R2TextBox;
        private System.Windows.Forms.TextBox R3TextBox;
        private System.Windows.Forms.Label resultLabel;
    }
}

