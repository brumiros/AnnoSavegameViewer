using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MoralSubstractersList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
    public object None { get; set; }

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public MoralSubstractersListList MoralSubstractersListList { get; set; }

  }
}