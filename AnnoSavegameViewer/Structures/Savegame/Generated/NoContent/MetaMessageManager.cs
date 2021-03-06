using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MetaMessageManager {

    [BinaryContent(Name = "NGT", NodeType = BinaryContentTypes.Node)]
    public NGT NGT { get; set; }

    [BinaryContent(Name = "ActionQueue", NodeType = BinaryContentTypes.Node)]
    public ActionQueue ActionQueue { get; set; }

  }
}