using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ElementType {

    [BinaryContent(Name = "ElementType", NodeType = BinaryContentTypes.Attribute)]
    public object ElementTypeItem { get; set; }

  }
}