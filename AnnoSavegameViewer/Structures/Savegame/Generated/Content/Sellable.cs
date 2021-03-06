using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Sellable {

    [BinaryContent(Name = "allowedBuyers", NodeType = BinaryContentTypes.Attribute)]
    public object AllowedBuyers { get; set; }

    [BinaryContent(Name = "onSale", NodeType = BinaryContentTypes.Attribute)]
    public object OnSale { get; set; }

  }
}