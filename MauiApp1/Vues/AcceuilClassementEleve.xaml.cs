using AP1.Modeles;
using AP1.Services;
using AP1.Vues;
using MauiApp1.Vues;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Maui.Controls;
using System;

namespace AP1.Vues;

public partial class AcceuilClassementEleve : ContentPage
{
    private readonly Apis Apis = new Apis();

    public AcceuilClassementEleve()
	{
        InitializeComponent();
	}
}