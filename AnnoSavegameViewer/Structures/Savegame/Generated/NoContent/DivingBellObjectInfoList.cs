using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DivingBellObjectInfoList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public DivingBellObjectInfoListList DivingBellObjectInfoListList { get; set; }

  }
}