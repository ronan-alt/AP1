using MauiApp1;

namespace AP1.Vues;

public partial class Register : ContentPage
{
	public Register()
	{
		InitializeComponent();


    }
    private void OnRegisterClicked(object sender, EventArgs e)
    {
        DisplayAlert("Inscription", "Tu as cliqué sur le bouton S'inscrire !", "OK");
    }
}