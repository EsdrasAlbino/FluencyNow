using FluencyNow.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceAPI;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FluencyNow.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        List<tbl_Register> listClient;
        public LoginPage()
        {
            InitializeComponent();
            listClient = new List<tbl_Register>();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Login();
        }

        public async void Login()
        {
            listClient = await ApiService.ObterCliente();

            var client = listClient.Where(x => x.Email_User == txtEmail.Text && x.Password_User == txtPassword.Text).ToList();

            if(client.Count > 0)
            {
                await Navigation.PushAsync(new MainPage());
            }
            else
            {
                DisplayAlert("Error", "Email ou Senha errada", "Ok");
            }
        }
    }
}