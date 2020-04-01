using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ThreadStateOfEachPeerListValue {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ThreadStateOfEachPeerListValueValue Value { get; set; }

  }
}