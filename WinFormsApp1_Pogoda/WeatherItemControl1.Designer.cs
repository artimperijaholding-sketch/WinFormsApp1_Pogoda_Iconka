namespace WinFormsApp1_Pogoda
{
    partial class WeatherItemControl
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
            dataPanel1 = new DataPanel();
            pictureBoxIcon = new PictureBox();
            labelInfo = new Label();
            labelTitle = new Label();
            dataPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // dataPanel1
            // 
            dataPanel1.BackColor = Color.Transparent;
            dataPanel1.Controls.Add(pictureBoxIcon);
            dataPanel1.Controls.Add(labelInfo);
            dataPanel1.Controls.Add(labelTitle);
            dataPanel1.Location = new Point(3, 2);
            dataPanel1.Margin = new Padding(3, 2, 3, 2);
            dataPanel1.Name = "dataPanel1";
            dataPanel1.Size = new Size(100, 56);
            dataPanel1.TabIndex = 0;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Location = new Point(7, 9);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(16, 16);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 2;
            pictureBoxIcon.TabStop = false;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.BackColor = Color.Transparent;
            labelInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelInfo.ForeColor = Color.White;
            labelInfo.Location = new Point(23, 31);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(47, 15);
            labelInfo.TabIndex = 1;
            labelInfo.Text = "<data>";
            labelInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTitle.Location = new Point(24, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(48, 15);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "<type>";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WeatherItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            Controls.Add(dataPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "WeatherItemControl";
            Size = new Size(105, 60);
            dataPanel1.ResumeLayout(false);
            dataPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataPanel dataPanel1;
        private Label labelInfo;
        private Label labelTitle;
        private PictureBox pictureBoxIcon;
    }
}
