﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.PowerToys.Settings.UI.Library;
using Microsoft.PowerToys.Settings.UI.Library.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.PowerToys.Settings.UI.Flyout
{
    public sealed partial class AwakeView : Page
    {
        private AwakeViewModel ViewModel { get; set; }

        public AwakeView()
        {
            var settingsUtils = new SettingsUtils();
            ViewModel = new AwakeViewModel(SettingsRepository<GeneralSettings>.GetInstance(settingsUtils), SettingsRepository<AwakeSettings>.GetInstance(settingsUtils), ShellPage.SendDefaultIPCMessage);
            DataContext = ViewModel;
            this.InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Frame selectedFrame = this.Parent as Frame;
            selectedFrame.GoBack();
        }
    }
}
