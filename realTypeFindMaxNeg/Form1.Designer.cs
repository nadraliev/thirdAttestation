namespace realTypeFindMaxNeg
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
            this.generatedNumbersTb = new System.Windows.Forms.TextBox();
            this.generateNumbers = new System.Windows.Forms.Button();
            this.findMin = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generatedNumbersTb
            // 
            this.generatedNumbersTb.Location = new System.Drawing.Point(13, 13);
            this.generatedNumbersTb.Multiline = true;
            this.generatedNumbersTb.Name = "generatedNumbersTb";
            this.generatedNumbersTb.ReadOnly = true;
            this.generatedNumbersTb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.generatedNumbersTb.Size = new System.Drawing.Size(229, 414);
            this.generatedNumbersTb.TabIndex = 0;
            this.generatedNumbersTb.WordWrap = false;
            // 
            // generateNumbers
            // 
            this.generateNumbers.Location = new System.Drawing.Point(259, 13);
            this.generateNumbers.Name = "generateNumbers";
            this.generateNumbers.Size = new System.Drawing.Size(172, 33);
            this.generateNumbers.TabIndex = 1;
            this.generateNumbers.Text = "Сгенерировать 30 чисел";
            this.generateNumbers.UseVisualStyleBackColor = true;
            this.generateNumbers.Click += new System.EventHandler(this.generateNumbers_Click);
            // 
            // findMin
            // 
            this.findMin.Location = new System.Drawing.Point(259, 83);
            this.findMin.Name = "findMin";
            this.findMin.Size = new System.Drawing.Size(172, 37);
            this.findMin.TabIndex = 2;
            this.findMin.Text = "Найти минимальное";
            this.findMin.UseVisualStyleBackColor = true;
            this.findMin.Click += new System.EventHandler(this.findMin_Click);
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Location = new System.Drawing.Point(259, 169);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(30, 13);
            this.min.TabIndex = 3;
            this.min.Text = "Min: ";
            this.min.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 439);
            this.Controls.Add(this.min);
            this.Controls.Add(this.findMin);
            this.Controls.Add(this.generateNumbers);
            this.Controls.Add(this.generatedNumbersTb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox generatedNumbersTb;
        private System.Windows.Forms.Button generateNumbers;
        private System.Windows.Forms.Button findMin;
        private System.Windows.Forms.Label min;
    }
}

