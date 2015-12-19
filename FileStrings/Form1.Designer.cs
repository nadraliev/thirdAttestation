namespace FileStrings
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
            this.label2 = new System.Windows.Forms.Label();
            this.stringNumberNumeric = new System.Windows.Forms.NumericUpDown();
            this.deleteString = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stringNumberNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Удалить строку с номером:";
            // 
            // stringNumberNumeric
            // 
            this.stringNumberNumeric.Location = new System.Drawing.Point(240, 167);
            this.stringNumberNumeric.Name = "stringNumberNumeric";
            this.stringNumberNumeric.Size = new System.Drawing.Size(120, 26);
            this.stringNumberNumeric.TabIndex = 3;
            // 
            // deleteString
            // 
            this.deleteString.Location = new System.Drawing.Point(117, 90);
            this.deleteString.Name = "deleteString";
            this.deleteString.Size = new System.Drawing.Size(255, 41);
            this.deleteString.TabIndex = 4;
            this.deleteString.Text = "Выбрать файл";
            this.deleteString.UseVisualStyleBackColor = true;
            this.deleteString.Click += new System.EventHandler(this.deleteString_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Удалить строки и сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteString);
            this.Controls.Add(this.stringNumberNumeric);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.stringNumberNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown stringNumberNumeric;
        private System.Windows.Forms.Button deleteString;
        private System.Windows.Forms.Button button1;
    }
}

