using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SocketItems {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<SocketItemsList> SocketItemsList { get; set; }

  }
}