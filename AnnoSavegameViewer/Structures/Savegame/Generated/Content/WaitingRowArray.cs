using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class WaitingRowArray {

    [BinaryContent(Name = "size", NodeType = BinaryContentTypes.Attribute)]
    public object Size { get; set; }

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public WaitingRowArrayList WaitingRowArrayList { get; set; }

  }
}