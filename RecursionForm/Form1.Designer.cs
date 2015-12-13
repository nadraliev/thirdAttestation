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
            this.label1 = new System.Windows.Forms.Label();
            this.pathTb = new System.Windows.Forms.TextBox();
            this.countCommas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfCommas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Путь к файлу";
            // 
            // pathTb
            // 
            this.pathTb.Location = new System.Drawing.Point(94, 13);
            this.pathTb.Name = "pathTb";
            this.pathTb.Size = new System.Drawing.Size(512, 20);
            this.pathTb.TabIndex = 1;
            // 
            // countCommas
            // 
            this.countCommas.Location = new System.Drawing.Point(205, 60);
            this.countCommas.Name = "countCommas";
            this.countCommas.Size = new System.Drawing.Size(198, 26);
            this.countCommas.TabIndex = 2;
            this.countCommas.Text = "Посчитать кол-во запятых";
            this.countCommas.UseVisualStyleBackColor = true;
            this.countCommas.Click += new System.EventHandler(this.countCommas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Результат";
            // 
            // numberOfCommas
            // 
            this.numberOfCommas.AutoSize = true;
            this.numberOfCommas.Location = new System.Drawing.Point(301, 112);
            this.numberOfCommas.Name = "numberOfCommas";
            this.numberOfCommas.Size = new System.Drawing.Size(35, 13);
            this.numberOfCommas.TabIndex = 4;
            this.numberOfCommas.Text = "label3";
            this.numberOfCommas.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 543);
            this.Controls.Add(this.numberOfCommas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countCommas);
            this.Controls.Add(this.pathTb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathTb;
        private System.Windows.Forms.Button countCommas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numberOfCommas;
    }
}

