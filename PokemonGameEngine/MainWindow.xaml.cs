﻿using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Kermalis.PokemonGameEngine
{
    public sealed class MainWindow : Window
    {
        public MainWindow()
        {
            AvaloniaXamlLoader.Load(this);
            MinWidth = MainView.RenderWidth;
            MinHeight = MainView.RenderHeight;
        }
    }
}
