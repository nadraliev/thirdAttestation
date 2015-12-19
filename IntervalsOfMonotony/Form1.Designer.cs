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
            this.countIntervalsOfMonotony = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.increasingIntervals = new System.Windows.Forms.Label();
            this.monotonyIntervals = new System.Windows.Forms.Label();
            this.decreasingIntervals = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // countIntervalsOfMonotony
            // 
            this.countIntervalsOfMonotony.Location = new System.Drawing.Point(305, 102);
            this.countIntervalsOfMonotony.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.countIntervalsOfMonotony.Name = "countIntervalsOfMonotony";
            this.countIntervalsOfMonotony.Size = new System.Drawing.Size(310, 42);
            this.countIntervalsOfMonotony.TabIndex = 2;
            this.countIntervalsOfMonotony.Text = "Открыть файл посчитать участки монотонности";
            this.countIntervalsOfMonotony.UseVisualStyleBackColor = true;
            this.countIntervalsOfMonotony.Click += new System.EventHandler(this.countIntervalsOfMonotony_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Участков возрастания:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Участков убывания:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 302);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Участков монотонности:";
            // 
            // increasingIntervals
            // 
            this.increasingIntervals.AutoSize = true;
            this.increasingIntervals.Location = new System.Drawing.Point(246, 195);
            this.increasingIntervals.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.increasingIntervals.Name = "increasingIntervals";
            this.increasingIntervals.Size = new System.Drawing.Size(51, 20);
            this.increasingIntervals.TabIndex = 6;
            this.increasingIntervals.Text = "label5";
            this.increasingIntervals.Visible = false;
            // 
            // monotonyIntervals
            // 
            this.monotonyIntervals.AutoSize = true;
            this.monotonyIntervals.Location = new System.Drawing.Point(246, 302);
            this.monotonyIntervals.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.monotonyIntervals.Name = "monotonyIntervals";
            this.monotonyIntervals.Size = new System.Drawing.Size(51, 20);
            this.monotonyIntervals.TabIndex = 7;
            this.monotonyIntervals.Text = "label6";
            this.monotonyIntervals.Visible = false;
            // 
            // decreasingIntervals
            // 
            this.decreasingIntervals.AutoSize = true;
            this.decreasingIntervals.Location = new System.Drawing.Point(246, 246);
            this.decreasingIntervals.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.decreasingIntervals.Name = "decreasingIntervals";
            this.decreasingIntervals.Size = new System.Drawing.Size(51, 20);
            this.decreasingIntervals.TabIndex = 8;
            this.decreasingIntervals.Text = "label7";
            this.decreasingIntervals.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 622);
            this.Controls.Add(this.decreasingIntervals);
            this.Controls.Add(this.monotonyIntervals);
            this.Controls.Add(this.increasingIntervals);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countIntervalsOfMonotony);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button countIntervalsOfMonotony;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label increasingIntervals;
        private System.Windows.Forms.Label monotonyIntervals;
        private System.Windows.Forms.Label decreasingIntervals;
    }
}

