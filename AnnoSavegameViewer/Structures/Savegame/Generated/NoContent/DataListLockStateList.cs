using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DataListLockStateList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public DataListLockStateListValue Value { get; set; }

  }
}