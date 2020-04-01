using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Action {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ActionValue Value { get; set; }

  }
}