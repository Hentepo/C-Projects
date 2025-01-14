using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using static System.Net.WebRequestMethods;

namespace MyWeatherAppCs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string APIKey = "c326c076fb93dd74a4322b1e6394490c";
        double lon;
        double lat;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
            getForecast();
        }

        void getWeather()
        {
            using (WebClient web = new WebClient())  
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", CityTextBox.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                labelCondition.Text = Info.weather[0].main;
                labelDetails.Text = Info.weather[0].description;
                labelSunset.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();
                labelSunrise.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();
                labelWindSpeed.Text = Info.wind.speed.ToString();
                labelPressure.Text = Info.main.pressure.ToString();

                lon = Info.coord.lon;
                lat = Info.coord.lat;
            }

        }

        DateTime convertDateTime(long millisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(millisec).ToLocalTime();
            return day;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        void getForecast()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&exclude=current,minutely,hourly,alerts&appid={2}", lat, lon,APIKey);
                var json = web.DownloadString(url);

                WeatherForecast.forecastInfo forecastInfo = JsonConvert.DeserializeObject<WeatherForecast.forecastInfo>(json);

               ForecastUC FUC;

                for (int i = 0; i < 8; i++)
                {
                    FUC = new ForecastUC();
                    FUC.pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + forecastInfo.daily[i].weather[0].icon + ",png";
                    FUC.labelMainWeather.Text = forecastInfo.daily[i].weather[0].main;
                    FUC.labelDescription.Text = forecastInfo.daily[i].weather[0].description;
                    FUC.labelDateTime.Text = convertDateTime(forecastInfo.daily[i].dt).DayOfWeek.ToString();
                
                    FLP.Controls.Add(FUC);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FLP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelCondition_Click(object sender, EventArgs e)
        {

        }
    }
}


