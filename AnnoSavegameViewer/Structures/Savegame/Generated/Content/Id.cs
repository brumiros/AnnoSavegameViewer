using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Id {

    [BinaryContent(Name = "Index", NodeType = BinaryContentTypes.Attribute)]
    public object Index { get; set; }

    [BinaryContent(Name = "ResolverBuilding", NodeType = BinaryContentTypes.Node)]
    public ResolverBuilding ResolverBuilding { get; set; }

  }
}