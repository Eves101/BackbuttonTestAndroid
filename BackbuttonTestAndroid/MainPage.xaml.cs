namespace BackbuttonTestAndroid
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
            OpenPages();
        }

        private void OpenPages()
        {
            for (int i = 0; i < 20; i++)
            {
                Navigation.PushAsync(new SamplePage($"Page {i}"));
            }
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }

}
