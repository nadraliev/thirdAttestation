namespace RecursionForm
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
            this.addTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.queueTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addTb
            // 
            this.addTb.Location = new System.Drawing.Point(38, 28);
            this.addTb.Name = "addTb";
            this.addTb.Size = new System.Drawing.Size(138, 20);
            this.addTb.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить в очередь";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // queueTb
            // 
            this.queueTb.Location = new System.Drawing.Point(317, 28);
            this.queueTb.Multiline = true;
            this.queueTb.Name = "queueTb";
            this.queueTb.ReadOnly = true;
            this.queueTb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.queueTb.Size = new System.Drawing.Size(273, 482);
            this.queueTb.TabIndex = 2;
            this.queueTb.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 543);
            this.Controls.Add(this.queueTb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addTb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox queueTb;
    }
}

