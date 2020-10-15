using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.CodeDom.Compiler;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp2
{
    class WeatherInterfaceMain
    {
        public double temp;
        public double pressure;
        public double feels_like;
    }
    class WeatherInterface
    {
        public WeatherInterfaceMain main;
    }
    public partial class Weather : Form
    {
        public double getCelsiaFromFarengeitString(double t)
        {
            return t - 273.15;
        }
        public Weather()
        {
            InitializeComponent();
            this.Load += onLoadEnd;
        }
        public void onLoadEnd(object sender, EventArgs e)
        {
            search.Click += onClickHandler;

        }
        private async void onClickHandler(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://api.openweathermap.org/data/2.5/weather?q="+inputCity.Text+"&APPID=e8c94dad7f4ae805e4df3e195d3d2eb6");
            request.Method = "POST";
            request.ContentType = "application/x-www-urlencoded";
            WebResponse response = await request.GetResponseAsync();
            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(s))
                {
                    string weatherJson = await reader.ReadToEndAsync();
                    var currentWeather = JsonConvert.DeserializeObject<WeatherInterface>(weatherJson);
                    label1.Text = "Погода в " + inputCity.Text + ":\n\n";
                    label1.Text += "Температура C* "+getCelsiaFromFarengeitString(currentWeather.main.temp).ToString("#") + "\n";
                    label1.Text += "Ощущается как C* " + getCelsiaFromFarengeitString(currentWeather.main.feels_like).ToString("#") + "\n";
                    label1.Text += "Давление " + getCelsiaFromFarengeitString(currentWeather.main.pressure).ToString("#") + "\n";
                }
            }
            response.Close();

        }
    }
}
