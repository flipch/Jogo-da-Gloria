using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace Jogo_da_Glória
{
    /// <summary>
    ///     First page where you select how many players are playing.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationCacheMode = NavigationCacheMode.Required;

            var obj = Application.Current as App;

            for (var i = 1; i <= obj.maxplayers; i++)
            {
                list_players.Items.Add(i);
            }
            list_players.SelectedItem = list_players.SelectedIndex = 1;
            list_players.HorizontalContentAlignment = HorizontalAlignment.Center;
            list_players.VerticalContentAlignment = VerticalAlignment.Center;
        }

        /// <summary>
        ///     Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">
        ///     Event data that describes how this page was reached.
        ///     This parameter is typically used to configure the page.
        /// </param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void bt_go_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (Game), int.Parse(list_players.SelectedValue.ToString()));
        }

        private void list_players_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}