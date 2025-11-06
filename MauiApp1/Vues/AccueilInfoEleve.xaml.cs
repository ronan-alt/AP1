using AP1.Modeles;
using AP1.Services;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Maui.Controls;
using System;

namespace AP1.Vues;

public partial class AccueilInfoEleve : ContentPage
{
    private readonly Apis Apis = new Apis();

    public AccueilInfoEleve()
	{
		InitializeComponent();
	}
	private async void OnRetourClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new AcceuilEleve());
    }
}