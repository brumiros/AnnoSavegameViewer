using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class StorageTrendsList {

    [BinaryContent(Name = "LastPointTime", NodeType = BinaryContentTypes.Attribute)]
    public object LastPointTime { get; set; }

    [BinaryContent(Name = "Estimation", NodeType = BinaryContentTypes.Attribute)]
    public object Estimation { get; set; }

    [BinaryContent(Name = "Points", NodeType = BinaryContentTypes.Node)]
    public Points Points { get; set; }

  }
}