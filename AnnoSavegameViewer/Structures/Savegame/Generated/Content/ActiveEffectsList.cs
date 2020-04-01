using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ActiveEffectsList {

    [BinaryContent(Name = "distance", NodeType = BinaryContentTypes.Attribute)]
    public object Distance { get; set; }

    [BinaryContent(Name = "targetArea", NodeType = BinaryContentTypes.Attribute)]
    public object TargetArea { get; set; }

    [BinaryContent(Name = "effect", NodeType = BinaryContentTypes.Attribute)]
    public object Effect { get; set; }

    [BinaryContent(Name = "scope", NodeType = BinaryContentTypes.Node)]
    public ActiveEffectsListScope Scope { get; set; }

    [BinaryContent(Name = "targetParticipant", NodeType = BinaryContentTypes.Node)]
    public ActiveEffectsListTargetParticipant TargetParticipant { get; set; }

    [BinaryContent(Name = "source", NodeType = BinaryContentTypes.Node)]
    public ActiveEffectsListSource Source { get; set; }

    [BinaryContent(Name = "distanceSource", NodeType = BinaryContentTypes.Node)]
    public ActiveEffectsListDistanceSource DistanceSource { get; set; }

  }
}