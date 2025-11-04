using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using AP1.Modeles;
using AP1.Services;
using Microsoft.Maui.Controls;

namespace AP1.Vues;

public partial class HomePage : ContentPage
{
    private readonly Apis Apis = new Apis();
    private ObservableCollection<Competition> _competitions = new ObservableCollection<Competition>();

    public HomePage()
    {
        InitializeComponent();
        NewTournamentButton.Clicked += OnNewTournamentClicked;
        ManageTeamsButton.Clicked += OnManageTeamsClicked;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await LoadDataAsync();
    }

    private async Task LoadDataAsync()
    {
        SetLoading(true);
        ErrorLabel.IsVisible = false;
        try
        {
            _competitions = await Apis.GetAllAsync<Competition>("api/mobile/GetAllCompetitions");
        }
        catch (Exception)
        {
            // Fallback données test si API échoue
            _competitions = new ObservableCollection<Competition>
            {
                new Competition { Id = 1, DateDeb = DateTime.Today.AddDays(-1), DateFin = DateTime.Today.AddDays(1) },
                new Competition { Id = 2, DateDeb = DateTime.Today.AddDays(-7), DateFin = DateTime.Today.AddDays(-2) },
            };
            ErrorLabel.Text = "Mode déconnecté : données de test affichées.";
            ErrorLabel.IsVisible = true;
        }

        CompetitionsCollection.ItemsSource = _competitions;

        // Statistiques simples basées sur les données disponibles
        var now = DateTime.Now;
        int active = _competitions.Count(c => c.DateDeb <= now && now <= c.DateFin);
        ActiveTournamentsLabel.Text = active.ToString();

        // Sans nouvelles classes ni endpoints dédiés, on met 0 par défaut
        TeamsCountLabel.Text = "0";
        StudentsCountLabel.Text = "0";

        SetLoading(false);
    }

    private void SetLoading(bool isLoading)
    {
        LoadingIndicator.IsVisible = isLoading;
        LoadingIndicator.IsRunning = isLoading;
        CompetitionsCollection.IsVisible = !isLoading;
    }

    private async void OnNewTournamentClicked(object? sender, EventArgs e)
    {
        await DisplayAlert("Info", "Création de tournoi à implémenter.", "OK");
    }

    private async void OnManageTeamsClicked(object? sender, EventArgs e)
    {
        await DisplayAlert("Info", "Gestion des équipes à implémenter.", "OK");
    }
}


