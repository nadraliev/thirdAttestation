namespace IntervalsOfMonotony
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
            this.countIntervalsOfMonotony = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.increasingIntervals = new System.Windows.Forms.Label();
            this.monotonyIntervals = new System.Windows.Forms.Label();
            this.decreasingIntervals = new System.Windows.Forms.Label();
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
            this.pathTb.Size = new System.Drawing.Size(484, 20);
            this.pathTb.TabIndex = 1;
            // 
            // countIntervalsOfMonotony
            // 
            this.countIntervalsOfMonotony.Location = new System.Drawing.Point(182, 60);
            this.countIntervalsOfMonotony.Name = "countIntervalsOfMonotony";
            this.countIntervalsOfMonotony.Size = new System.Drawing.Size(207, 27);
            this.countIntervalsOfMonotony.TabIndex = 2;
            this.countIntervalsOfMonotony.Text = "Посчитать участки монотонности";
            this.countIntervalsOfMonotony.UseVisualStyleBackColor = true;
            this.countIntervalsOfMonotony.Click += new System.EventHandler(this.countIntervalsOfMonotony_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Участков возрастания:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Участков убывания:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Участков монотонности:";
            // 
            // increasingIntervals
            // 
            this.increasingIntervals.AutoSize = true;
            this.increasingIntervals.Location = new System.Drawing.Point(164, 127);
            this.increasingIntervals.Name = "increasingIntervals";
            this.increasingIntervals.Size = new System.Drawing.Size(35, 13);
            this.increasingIntervals.TabIndex = 6;
            this.increasingIntervals.Text = "label5";
            this.increasingIntervals.Visible = false;
            // 
            // monotonyIntervals
            // 
            this.monotonyIntervals.AutoSize = true;
            this.monotonyIntervals.Location = new System.Drawing.Point(164, 196);
            this.monotonyIntervals.Name = "monotonyIntervals";
            this.monotonyIntervals.Size = new System.Drawing.Size(35, 13);
            this.monotonyIntervals.TabIndex = 7;
            this.monotonyIntervals.Text = "label6";
            this.monotonyIntervals.Visible = false;
            // 
            // decreasingIntervals
            // 
            this.decreasingIntervals.AutoSize = true;
            this.decreasingIntervals.Location = new System.Drawing.Point(164, 160);
            this.decreasingIntervals.Name = "decreasingIntervals";
            this.decreasingIntervals.Size = new System.Drawing.Size(35, 13);
            this.decreasingIntervals.TabIndex = 8;
            this.decreasingIntervals.Text = "label7";
            this.decreasingIntervals.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 404);
            this.Controls.Add(this.decreasingIntervals);
            this.Controls.Add(this.monotonyIntervals);
            this.Controls.Add(this.increasingIntervals);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countIntervalsOfMonotony);
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
        private System.Windows.Forms.Button countIntervalsOfMonotony;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label increasingIntervals;
        private System.Windows.Forms.Label monotonyIntervals;
        private System.Windows.Forms.Label decreasingIntervals;
    }
}

