namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {

        int count = 0;

        public Random rnd { get; set; } = new Random();
        public int Number { get; set; }

        public int UserInput { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Number = rnd.Next(0, 21);
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }



        private void Play(object sender, EventArgs e)
        {
            if (sender is Entry entry)
            {
                string num = entry.Text;
                //string num = e.NewTextValue;
                int.TryParse(num, out int userInput);
                UserInput = userInput;
            }
            
            if (UserInput == Number)
            {
                Result.Text = $"You won !";
                Result.TextColor = Color.FromHex("#4FF533");
            }

            if (UserInput > Number)
            {
                Result.Text = $"The number is too high";
                Result.TextColor = Color.FromHex("#F52A1B");
            }

            if (UserInput < Number)
            {
                Result.Text = $"The number is too small";
                Result.TextColor = Color.FromHex("#F52A1B");
            }
        }
    }

}
