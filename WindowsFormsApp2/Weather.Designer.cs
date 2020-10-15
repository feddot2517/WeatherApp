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
            this.SuspendLayout();
            // 
            // inputCity
            // 
            this.inputCity.Location = new System.Drawing.Point(13, 13);
            this.inputCity.Name = "inputCity";
            this.inputCity.Size = new System.Drawing.Size(255, 20);
            this.inputCity.TabIndex = 0;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(274, 12);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(76, 23);
            this.search.TabIndex = 1;
            this.search.Text = "Найти";
            this.search.UseVisualStyleBackColor = true;
            // 
            // Weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

