using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ProductionLayoutBlockTypeValue {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ProductionLayoutBlockTypeValueValue Value { get; set; }

  }
}