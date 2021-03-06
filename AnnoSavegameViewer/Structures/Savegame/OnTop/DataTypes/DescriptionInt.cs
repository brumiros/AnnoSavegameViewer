﻿using AnnoSavegameViewer.Serialization.Core;
using System;
using System.Diagnostics;

namespace AnnoSavegameViewer.Structures.Savegame {

  [DebuggerDisplay("GUID = {GUID}, {CurrentLang}")]
  public class DescriptionInt : Description {

    #region Public Properties

    [BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Both)]
    public override int GUID { get; set; }

    public override string CurrentLang {
      get { ProgrammSettings.Texts.TryGetValue(GUID, out var result); return result ?? ""; }
    }

    #endregion Public Properties

    #region Public Constructors

    public DescriptionInt(int guid) {
      GUID = guid;
    }

    public DescriptionInt() {
    }
    #endregion Public Constructors

  }
}