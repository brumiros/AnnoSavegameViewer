using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class WaitingQueueMap {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<WaitingQueueMapList> WaitingQueueMapList { get; set; }

  }
}