using Alpha_Records_WPF.Connectivity;
using Alpha_Records_WPF.Factory;
using System.Windows;
using System.Windows.Controls;

namespace Alpha_Records_WPF
{
    public partial class PageLogin : Page
    {
        public static Account BgCoderAccount;
        public static Account InTheCampAccount;
        public PageLogin()
        {
            InitializeComponent();
        }

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            BgCoderAccount = ConnectivityFactory.Instance.
                CreateAccount(this.mail.Text, this.bgcoder_pass.Password);
            InTheCampAccount = ConnectivityFactory.Instance.
                CreateAccount(this.mail.Text, this.inthecamp_pass.Password);
            //Start Connectiong to bgcoder and IntheCamp
            ConnectivityFactory.Instance.CreateConnection(BgCoderAccount).
                Connect("URL");
            ConnectivityFactory.Instance.CreateConnection(InTheCampAccount).
                Connect("URL");
        }
    }
}
