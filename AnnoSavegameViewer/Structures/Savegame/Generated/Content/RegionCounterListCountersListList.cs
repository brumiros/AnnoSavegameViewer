using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class RegionCounterListCountersListList {

    [BinaryContent(Name = "Context", NodeType = BinaryContentTypes.Attribute)]
    public object Context { get; set; }

    [BinaryContent(Name = "Value", NodeType = BinaryContentTypes.Attribute)]
    public object Value { get; set; }

    [BinaryContent(Name = "PlayerCounter", NodeType = BinaryContentTypes.Node)]
    public RegionCounterListCountersListListPlayerCounter PlayerCounter { get; set; }

  }
}