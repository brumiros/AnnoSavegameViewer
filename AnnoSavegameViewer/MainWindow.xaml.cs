﻿using AnnoSavegameViewer.Controls;
using AnnoSavegameViewer.Controls.Loading;
using AnnoSavegameViewer.Templates;
using Microsoft.Win32;
using System;
using System.IO.Compression;
using System.Windows;

namespace AnnoSavegameViewer {

  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {

    #region Public Constructors

    public MainWindow() {
      ProgrammSettings.MainWindow = this;
      InitializeComponent();
      Loaded += MainWindow_Loaded;
      ComboBoxLanguage.SelectedItem = ProgrammSettings.Language;
      ComboBoxLanguage.SelectionChanged += ComboBoxLanguage_SelectionChanged;
    }

    #endregion Public Constructors

    #region Public Events

    public event Action SaveGameChanged;

    #endregion Public Events

    #region Private Methods

    private void MainWindow_Loaded(object sender, RoutedEventArgs e) {
      cbMode.SelectedIndex = 0;
    }

    private void ComboBoxLanguage_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e) {
      if (ComboBoxLanguage.SelectedItem is Languages lang) {
        ProgrammSettings.Language = lang;
      }
      var temp = DataContext;
      DataContext = null;
      DataContext = temp;
    }

    private void cbMode_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e) {
      if (Presenter != null) {
        switch (cbMode.SelectedIndex) {
          case 0:
            Presenter.Content = new SavegameItemsView();
            break;

          case 1:
            Presenter.Content = new SavegameBuildingsView();
            break;

          case 2:
            Presenter.Content = new SavegameUpgradesView();
            break;

          default:
            break;
        }
      }
    }

    private async void btnLoadSavegame_Click(object sender, RoutedEventArgs e) {
      var dialog = new OpenFileDialog { Filter = "Savegames (*.A7S)|*.A7S|All files (*.*)|*.*" };
      if (dialog.ShowDialog() == true) {
        var loadingDialog = new LoadingDialog() { Owner = this };
        loadingDialog.Show();
        await FileReader.ReadFileAsync(dialog.FileName);
        SaveGameChanged?.Invoke();
        loadingDialog.Close();
      }
    }

    #endregion Private Methods
  }
}