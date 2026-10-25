namespace WinFormsApp1_Pogoda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataPanel1 = new DataPanel();
            labelSummary = new Label();
            labelTemperature = new Label();
            pictureBoxIcon = new PictureBox();
            labelCity = new Label();
            buttonGetData = new Button();
            weatherItemsPanel = new FlowLayoutPanel();
            textBoxCityName = new TextBox();
            flowLayoutPanelForecast = new FlowLayoutPanel();
            dataPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // dataPanel1
            // 
            dataPanel1.BackColor = Color.Transparent;
            dataPanel1.Controls.Add(labelSummary);
            dataPanel1.Controls.Add(labelTemperature);
            dataPanel1.Controls.Add(pictureBoxIcon);
            dataPanel1.Controls.Add(labelCity);
            dataPanel1.Location = new Point(12, 11);
            dataPanel1.Margin = new Padding(3, 2, 3, 2);
            dataPanel1.Name = "dataPanel1";
            dataPanel1.Size = new Size(348, 202);
            dataPanel1.TabIndex = 0;
            // 
            // labelSummary
            // 
            labelSummary.AutoSize = true;
            labelSummary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelSummary.ForeColor = Color.WhiteSmoke;
            labelSummary.Location = new Point(25, 160);
            labelSummary.Name = "labelSummary";
            labelSummary.Size = new Size(70, 19);
            labelSummary.TabIndex = 3;
            labelSummary.Text = "Feels like";
            // 
            // labelTemperature
            // 
            labelTemperature.AutoSize = true;
            labelTemperature.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            labelTemperature.ForeColor = Color.WhiteSmoke;
            labelTemperature.Location = new Point(184, 63);
            labelTemperature.Name = "labelTemperature";
            labelTemperature.Size = new Size(109, 54);
            labelTemperature.TabIndex = 2;
            labelTemperature.Text = "10°C";
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Location = new Point(25, 47);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(96, 96);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 1;
            pictureBoxIcon.TabStop = false;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelCity.ForeColor = Color.WhiteSmoke;
            labelCity.Location = new Point(25, 9);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(154, 25);
            labelCity.TabIndex = 0;
            labelCity.Text = "Uknown city.AA";
            // 
            // buttonGetData
            // 
            buttonGetData.Location = new Point(263, 399);
            buttonGetData.Name = "buttonGetData";
            buttonGetData.Size = new Size(75, 23);
            buttonGetData.TabIndex = 2;
            buttonGetData.Text = "Get Data";
            buttonGetData.UseVisualStyleBackColor = true;
            buttonGetData.Click += buttonGetData_Click;
            // 
            // weatherItemsPanel
            // 
            weatherItemsPanel.BackColor = Color.Transparent;
            weatherItemsPanel.Location = new Point(12, 230);
            weatherItemsPanel.Name = "weatherItemsPanel";
            weatherItemsPanel.Size = new Size(348, 154);
            weatherItemsPanel.TabIndex = 4;
            // 
            // textBoxCityName
            // 
            textBoxCityName.Location = new Point(12, 400);
            textBoxCityName.Name = "textBoxCityName";
            textBoxCityName.Size = new Size(225, 23);
            textBoxCityName.TabIndex = 5;
            // 
            // flowLayoutPanelForecast
            // 
            flowLayoutPanelForecast.BackColor = Color.Transparent;
            flowLayoutPanelForecast.Location = new Point(12, 449);
            flowLayoutPanelForecast.Name = "flowLayoutPanelForecast";
            flowLayoutPanelForecast.Size = new Size(348, 176);
            flowLayoutPanelForecast.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(378, 637);
            Controls.Add(flowLayoutPanelForecast);
            Controls.Add(textBoxCityName);
            Controls.Add(weatherItemsPanel);
            Controls.Add(buttonGetData);
            Controls.Add(dataPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Weather App";
            Load += Form1_Load;
            dataPanel1.ResumeLayout(false);
            dataPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataPanel dataPanel1;
        private Button buttonGetData;
        private Label labelSummary;
        private Label labelTemperature;
        private PictureBox pictureBoxIcon;
        private Label labelCity;
        private FlowLayoutPanel weatherItemsPanel;
        private TextBox textBoxCityName;
        private FlowLayoutPanel flowLayoutPanelForecast;
    }
}
