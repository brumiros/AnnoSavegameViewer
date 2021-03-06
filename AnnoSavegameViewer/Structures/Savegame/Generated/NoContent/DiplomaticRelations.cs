using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DiplomaticRelations {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<DiplomaticRelationsList> DiplomaticRelationsList { get; set; }

  }
}