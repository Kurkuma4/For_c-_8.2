namespace tamaGosha1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            progressBarHunger.Value = 50;
            progressBarEnergy.Value = 50;
            progressBarHappy.Value = 50;

            timer1.Start();
        }
        private void buttonFeed_Click(object sender, EventArgs e)
        {
            if (progressBarHunger.Value >= 10) progressBarHunger.Value -= 10;
            else progressBarHunger.Value = 0;
            if (progressBarEnergy.Value <= 95) progressBarEnergy.Value += 5;
            else progressBarEnergy.Value = 100;
            if (progressBarHappy.Value <= 95) progressBarHappy.Value += 5;
            else progressBarHappy.Value = 100;

            MessageBox.Show("Гоша поїв!");

            CheckGameOver();
        }
        private void buttonSleep_Click(object sender, EventArgs e)
        {
            if (progressBarEnergy.Value <= 80) progressBarEnergy.Value += 20;
            else progressBarEnergy.Value = 100;
            if (progressBarHappy.Value >= 10) progressBarHappy.Value -= 10;
            else progressBarHappy.Value = 0;
            if (progressBarHunger.Value <= 90) progressBarHunger.Value += 10;
            else progressBarHunger.Value = 100;

            MessageBox.Show("Гоша поспав!");

            CheckGameOver();
        }
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (progressBarEnergy.Value >= 10) progressBarEnergy.Value -= 10;
            else progressBarEnergy.Value = 0;
            if (progressBarHappy.Value <= 80) progressBarHappy.Value += 20;
            else progressBarHappy.Value = 100;
            if (progressBarHunger.Value <= 90) progressBarHunger.Value += 10;
            else progressBarHunger.Value = 100;

            MessageBox.Show("Гоша щасливий!");

            CheckGameOver();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBarHunger.Value <= 95) progressBarHunger.Value += 5;
            else progressBarHunger.Value = 100;
            if (progressBarEnergy.Value >= 5) progressBarEnergy.Value -= 5;
            else progressBarEnergy.Value = 0;
            if (progressBarHappy.Value >= 5) progressBarHappy.Value -= 5;
            else progressBarHappy.Value = 0;

            CheckGameOver();
        }
        private void CheckGameOver()
        {
            if (progressBarEnergy.Value == 0 &&
                progressBarHappy.Value == 0)
            {
                timer1.Stop();

                MessageBox.Show("Сталася бідося , Гоша помер (від нестачі щастя або енергії) :(");
            }

            if (progressBarHunger.Value == 100)
            {
                timer1.Stop();

                MessageBox.Show("Сталася бідося , Гоша помер (від голоду) :(");
            }
        }
    }
}
