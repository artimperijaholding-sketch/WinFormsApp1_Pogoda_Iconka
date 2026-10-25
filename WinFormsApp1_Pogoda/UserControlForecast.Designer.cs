namespace WinFormsApp1_Pogoda
{
    partial class UserControlForecast
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            labelData = new Label();
            labelTemp = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.BackColor = Color.Transparent;
            labelData.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelData.Location = new Point(-4, 1);
            labelData.Name = "labelData";
            labelData.Size = new Size(40, 15);
            labelData.TabIndex = 0;
            labelData.Text = "label1";
            // 
            // labelTemp
            // 
            labelTemp.AutoSize = true;
            labelTemp.BackColor = Color.Transparent;
            labelTemp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTemp.Location = new Point(8, 23);
            labelTemp.Name = "labelTemp";
            labelTemp.Size = new Size(40, 15);
            labelTemp.TabIndex = 1;
            labelTemp.Text = "label2";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(10, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 25);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // UserControlForecast
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(pictureBox1);
            Controls.Add(labelTemp);
            Controls.Add(labelData);
            ForeColor = Color.WhiteSmoke;
            Name = "UserControlForecast";
            Size = new Size(58, 83);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelData;
        private Label labelTemp;
        private PictureBox pictureBox1;
    }
}
