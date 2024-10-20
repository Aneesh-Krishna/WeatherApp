namespace WeatherService
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cityName = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.temperature = new System.Windows.Forms.Label();
            this.weathercondition = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.Label();
            this.windspeed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cityName
            // 
            this.cityName.BackColor = System.Drawing.Color.Gainsboro;
            this.cityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityName.Location = new System.Drawing.Point(90, 29);
            this.cityName.Name = "cityName";
            this.cityName.Size = new System.Drawing.Size(255, 22);
            this.cityName.TabIndex = 0;
            this.cityName.Text = "City Name";
            this.cityName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Gainsboro;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(90, 57);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(129, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // temperature
            // 
            this.temperature.BackColor = System.Drawing.Color.Honeydew;
            this.temperature.Location = new System.Drawing.Point(73, 165);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(189, 98);
            this.temperature.TabIndex = 2;
            this.temperature.Text = "Temperature";
            this.temperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weathercondition
            // 
            this.weathercondition.BackColor = System.Drawing.Color.Honeydew;
            this.weathercondition.Location = new System.Drawing.Point(73, 275);
            this.weathercondition.Name = "weathercondition";
            this.weathercondition.Size = new System.Drawing.Size(189, 98);
            this.weathercondition.TabIndex = 2;
            this.weathercondition.Text = "WeatherCondition";
            this.weathercondition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // humidity
            // 
            this.humidity.BackColor = System.Drawing.Color.Honeydew;
            this.humidity.Location = new System.Drawing.Point(532, 165);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(189, 98);
            this.humidity.TabIndex = 2;
            this.humidity.Text = "Humidity";
            this.humidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windspeed
            // 
            this.windspeed.BackColor = System.Drawing.Color.Honeydew;
            this.windspeed.Location = new System.Drawing.Point(532, 275);
            this.windspeed.Name = "windspeed";
            this.windspeed.Size = new System.Drawing.Size(189, 98);
            this.windspeed.TabIndex = 2;
            this.windspeed.Text = "WindSpeed";
            this.windspeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.windspeed);
            this.Controls.Add(this.humidity);
            this.Controls.Add(this.weathercondition);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.cityName);
            this.Name = "Form1";
            this.Text = "WeatherService";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cityName;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label temperature;
        private System.Windows.Forms.Label weathercondition;
        private System.Windows.Forms.Label humidity;
        private System.Windows.Forms.Label windspeed;
    }
}

