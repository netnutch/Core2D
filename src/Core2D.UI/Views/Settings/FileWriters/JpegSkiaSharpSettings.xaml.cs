﻿using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Core2D.UI.Views.Settings.FileWriters
{
    /// <summary>
    /// Interaction logic for <see cref="JpegSkiaSharpSettings"/> xaml.
    /// </summary>
    public class JpegSkiaSharpSettings : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JpegSkiaSharpSettings"/> class.
        /// </summary>
        public JpegSkiaSharpSettings()
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