namespace WindowsFormsApp2
{
    partial class Weather
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
            this.inputCity = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.helpMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputCity
            // 
            this.inputCity.Location = new System.Drawing.Point(12, 30);
            this.inputCity.Name = "inputCity";
            this.inputCity.Size = new System.Drawing.Size(255, 20);
            this.inputCity.TabIndex = 0;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(273, 29);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(76, 23);
            this.search.TabIndex = 1;
            this.search.Text = "Найти";
            this.search.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 69);
            this.label1.MaximumSize = new System.Drawing.Size(334, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Здесь будет погода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // helpMessage
            // 
            this.helpMessage.AutoSize = true;
            this.helpMessage.Location = new System.Drawing.Point(12, 11);
            this.helpMessage.Name = "helpMessage";
            this.helpMessage.Size = new System.Drawing.Size(81, 13);
            this.helpMessage.TabIndex = 4;
            this.helpMessage.Text = "Введите город";
            // 
            // Weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 272);
            this.Controls.Add(this.helpMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.inputCity);
            this.Name = "Weather";
            this.Text = "Погода";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputCity;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label helpMessage;
    }
}

