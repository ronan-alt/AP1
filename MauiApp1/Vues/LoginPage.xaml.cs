using AP1.Modeles;
using AP1.Services;
using MauiApp1.Vues;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Maui.Controls;
using System;

namespace AP1.Vues;

public partial class LoginPage : ContentPage
{
    private readonly Apis Apis = new Apis();
    public LoginPage()
    {
        InitializeComponent();
    }



    private async void OnLoginClicked(object sender, EventArgs e)
    {
        var email = EmailEntry.Text;
        var password = PasswordEntry.Text;
        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
        {
            await DisplayAlert("Erreur", "Veuillez entrer votre email et mot de passe.", "OK");
            return;
        }
        else
        {
            User u1 = new User(email, password);
            bool BB = await Apis.GetOneAsync("api/mobile/GetFindUser", u1);
            if (BB == true)
            {
                await Navigation.PushAsync(new Accueil());

            }
            else
            {
                await DisplayAlert("Erreur", "email ou mot de passe incorrect.", "OK");
                await Navigation.PushAsync(new LoginPage());


            }

        }
        return;
    }
    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Register());
    }
    private async void OnForgotPasswordClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ForgotPassword());
    }
}