using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CachePerSessionListValue {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public CachePerSessionListValueValue Value { get; set; }

  }
}