using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ShipState {

    [BinaryContent(Name = "ShipState", NodeType = BinaryContentTypes.Attribute)]
    public object ShipStateItem { get; set; }

  }
}