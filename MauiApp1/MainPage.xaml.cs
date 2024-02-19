using System.Net.NetworkInformation;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {


        public Random rnd { get; set; } = new Random();
        public int Number { get; set; }
        public int Hp { get; set; }
        public string HpString { get; set; }


        public MainPage()
        {
            InitializeComponent();
            Number = rnd.Next(0, 21);
            Hp = 5;
            HpString = "❤❤❤❤❤";
            ReplayButton.IsVisible = false;
            this.BindingContext = this;

        }
        private void Play(object sender, EventArgs e)
        {

            int.TryParse(UserEntry.Text, out int valueToTest);

            if (valueToTest == Number)
            {
                Result.Text = $"You won !";
                Result.TextColor = Color.FromArgb("#4FF533");
                ReplayButton.IsVisible = true;
                return;
            }

            if (valueToTest > Number)

                Result.Text = $"The number is too high";
            else
                Result.Text = $"The number is too small";

            Result.TextColor = Color.FromArgb("#F52A1B");
            Hp--;

            for (int i = 0; i < Hp; i++)
            {
                HpString += "❤";
            }
        }

        private void Replay(object sender, EventArgs e)
        {
            Number = rnd.Next(0, 21);
            Hp = 5;
            HpString = "test";
            ReplayButton.IsVisible = false;
        }
        #region counter
        //public int UserInput { get; set; }

        //private void OnCounterClicked(object sender, EventArgs e)
        //{
        //    count++;

        //    if (count == 1)
        //        CounterBtn.Text = $"Clicked {count} time";
        //    else
        //        CounterBtn.Text = $"Clicked {count} times";

        //    SemanticScreenReader.Announce(CounterBtn.Text);
        //}
        #endregion
    }

}
