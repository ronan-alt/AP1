using AP1.Services;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Maui.Controls;
using System;

namespace AP1.Vues;

public partial class Register : ContentPage
{
    private readonly Apis Apis = new Apis();
    public Register()
    {
        InitializeComponent();

    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        string name = NameEntry.Text;
        string email = EmailEntry.Text;
        string password = PasswordEntry.Text;
        string confirmPassword = ConfirmPasswordEntry.Text;

        if (name == "" || email == "" || password == "" || confirmPassword == "")
        {
            await DisplayAlert("Erreur", "Tous les champs sont obligatoires.", "OK");
            return;
        }

        if (password != confirmPassword)
        {
            await DisplayAlert("Erreur", "Les mots de passe ne correspondent pas.", "OK");
            return;
        }

        await DisplayAlert("Succès", "Compte créé avec succès !", "OK");
    }
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }


}

