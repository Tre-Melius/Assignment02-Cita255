namespace Assingment2
{
    public partial class MainPage : ContentPage
    {


        List<string> games = new List<string>
            {
                "Assassin's Creed Odyssey",
                "Assassin`s Creed Valhalla",
                "Assassin's Creed Unity",
                "Assassin's Creed Syndicate",
                "Assassin's Creed Rogue",
                "Assassin's Creed Revelations",
                "Assassin's Creed IV: Black Flag Resynced",
                "Assassin's Creed III",
                "Assassin's Creed II",
                "Assassin's Creed Brotherhood",
                "Assassin's Creed",
                "Assassin's Creed Liberation HD",
                "Assassin's Creed Chronicles: China",
                "Assassin's Creed Chronicles: India",
                "Assassin's Creed Chronicles: Russia",
                "Assassin's Creed Origins",
                "Assassin's Creed Discovery",
                "Assassin's Creed Freedom Cry",
                "Assassin's Creed Mirage",
                "Assassin's_CREED: Shadows"
            };
        List<double> gamesPlaytime = new List<double>()
            {
                68.6,
                19.4,
                6.5,
                21.5,
                0.80,
                0.0,
                85.5,
                60.2,
                50.0,
                0.5,
                2.3,
                60.2,
                0.2,
                0.0,
                0.0,
                100.2,
                50.0,
                63.0,
                109.7
            };

        public MainPage()
        {

            InitializeComponent();
            MygamesList.ItemsSource = games;
            MygamesPlaytimeList.ItemsSource = gamesPlaytime;

        }

        private void AddGame_Clicked(object sender, EventArgs e)
        {

        }
    }
}

