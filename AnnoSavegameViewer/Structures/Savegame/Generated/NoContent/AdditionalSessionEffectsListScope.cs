using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AdditionalSessionEffectsListScope {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public AdditionalSessionEffectsListScopeValue Value { get; set; }

  }
}