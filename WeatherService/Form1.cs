using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace WeatherService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            string city = cityName.Text;
            if (!string.IsNullOrEmpty(city))
            {
                weatherService Service = new weatherService();
                try
                {
                    var weatherData = await Service.GetWeatherAsync(city);

                    temperature.Text = $"Temperature: {weatherData.Current.Temp}°C";
                    weathercondition.Text = $"Condition: {weatherData.Current.WeatherDescription[0]}";
                    humidity.Text = $"Humidity: {weatherData.Current.Humidity}%";
                    windspeed.Text = $"Wind Speed: {weatherData.Current.WindSpeed} m/s";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching weather data: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a city name.");
            }
        }
    }
}
