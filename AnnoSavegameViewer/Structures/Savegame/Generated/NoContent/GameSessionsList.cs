using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class GameSessionsList {

    [BinaryContent(Name = "SessionDesc", NodeType = BinaryContentTypes.Node)]
    public SessionDesc SessionDesc { get; set; }

    [BinaryContent(Name = "SessionData", NodeType = BinaryContentTypes.Node)]
    public SessionData SessionData { get; set; }

  }
}