using System.Net.NetworkInformation;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {


        public Random rnd { get; set; } = new Random();
        public int Number { get; set; }
        public int Hp { get; set; }
        public string HpString { get; set; }
        public bool IsWon { get; set; }
        public bool IsPlaying {  get; set; }

        public MainPage()
        {
            InitializeComponent();
            Number = rnd.Next(0, 21);
            Hp = 5;
            ReplayButton.IsVisible = false;
            this.BindingContext = this;

        }
        private void Play(object sender, EventArgs e)
        {

            int.TryParse(UserEntry.Text, out int valueToTest);

            if (valueToTest == Number)
            {
                Result.TextColor = Color.FromArgb("#4FF533");
                ReplayButton.IsVisible = true;
                WinLabel.IsVisible = true;
                PlayButton.IsVisible = false;

                return;
            }

            if (valueToTest > Number)

                Result.Text = $"The number is too high";
            else
                Result.Text = $"The number is too small";

            Result.TextColor = Color.FromArgb("#F52A1B");
            Hp--;

            if( Hp == 0 )
            {
                LostLabel.IsVisible = true;
                ReplayButton.IsVisible = true;
                PlayButton.IsVisible = false;
            }

            string tmpString = "";

            for (int i = 0; i < Hp; i++)
            {
                tmpString += "❤";
            }

            HpBar.Text = tmpString;
        }

        private void Replay(object sender, EventArgs e)
        {
            Number = rnd.Next(0, 21);
            Hp = 5;
            HpBar.Text = "❤❤❤❤❤";
            ReplayButton.IsVisible = false;
            WinLabel.IsVisible = false;
            LostLabel.IsVisible = false;
            PlayButton.IsVisible = true;

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
