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
            User U1 = await Apis.GetOneAsync<User>($"api/mobile/GetFindUser", new User(email, password));

            await Navigation.PushAsync(new Accueil());
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