﻿using AnnoSavegameViewer.Templates.Filters;

namespace AnnoSavegameViewer.Templates {

  public class UpgradesHolderItems : ItemsHolder {

    #region Public Constructors

    public UpgradesHolderItems() : base(() => ProgrammSettings.CurrentSavegame?.GameObjects?.Upgrades) {
      StandardFilters.Add("Player", new PlayerFilter(this));
      StandardFilters.Add("Session", new SessionsFilter(this));
      StandardFilters.Add("Area", new AreasFilter(this));
      StandardFilters.Add("Text", new SearchTextFilter(this));
    }

    #endregion Public Constructors
  }
}