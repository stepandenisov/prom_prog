using Avalonia.Interactivity;
using Avalonia.ReactiveUI;
using Media.Client.ViewModels;
using ReactiveUI;
using System;

namespace Media.Client.Views;
public partial class GenreWindow : ReactiveWindow<GenreViewModel>
{
    public GenreWindow()
    {
        InitializeComponent();

        this.WhenActivated(d => d(ViewModel!.OnSubmitCommand.Subscribe(Close)));
    }

    public void CancelButtonOnClick(object? sender, RoutedEventArgs eventArgs)
    {
        Close();
    }
}
