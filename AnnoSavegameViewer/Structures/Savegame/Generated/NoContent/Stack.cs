using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Stack {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<StackList> StackList { get; set; }

  }
}