using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class RewardList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public RewardListList RewardListList { get; set; }

  }
}