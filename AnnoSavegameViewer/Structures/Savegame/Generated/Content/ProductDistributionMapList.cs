using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ProductDistributionMapList {

    [BinaryContent(Name = "ProductLeft", NodeType = BinaryContentTypes.Attribute)]
    public object ProductLeft { get; set; }

    [BinaryContent(Name = "ProductConsumption", NodeType = BinaryContentTypes.Attribute)]
    public object ProductConsumption { get; set; }

    [BinaryContent(Name = "DistributionPausedInfo", NodeType = BinaryContentTypes.Node)]
    public DistributionPausedInfo DistributionPausedInfo { get; set; }

  }
}