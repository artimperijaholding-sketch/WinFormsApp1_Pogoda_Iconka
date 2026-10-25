using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1_Pogoda
{
    public partial class WeatherItemControl : UserControl
    {
        private WeatherItemData ItemData;

        public WeatherItemControl()
        {
            InitializeComponent();

            SetBackColor();

        }
        public WeatherItemControl(WeatherItemData weatherItemData)
        {
            InitializeComponent();     
            
            this.ItemData = weatherItemData;

            SetBackColor();

            this.Load += WeatherItemControl1_Load;
        }

        private void WeatherItemControl1_Load(object? sender, EventArgs e)
        {
            ShowItemData();
        }

        private void SetBackColor()
        {
            this.BackColor = Color.Transparent;
        }
        private void ShowItemData()
        {
            if(ItemData!=null)
            {
                labelTitle.Text = ItemData.Title;
                labelInfo.Text = ItemData.Data;
                pictureBoxIcon.Image = ItemData.Icon;
            }
        }

    }
}
