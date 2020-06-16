﻿using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Core2D.UI.Views.Settings.FileWriters
{
    /// <summary>
    /// Interaction logic for <see cref="WebpSkiaSharpSettings"/> xaml.
    /// </summary>
    public class WebpSkiaSharpSettings : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebpSkiaSharpSettings"/> class.
        /// </summary>
        public WebpSkiaSharpSettings()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialize the Xaml components.
        /// </summary>
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
