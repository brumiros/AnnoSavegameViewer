using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SocketContainer {

    [BinaryContent(Name = "ActivateEquippedItems", NodeType = BinaryContentTypes.Attribute)]
    public object ActivateEquippedItems { get; set; }

    [BinaryContent(Name = "IncidentBuff", NodeType = BinaryContentTypes.Attribute)]
    public object IncidentBuff { get; set; }

    [BinaryContent(Name = "SocketItems", NodeType = BinaryContentTypes.Node)]
    public SocketItems SocketItems { get; set; }

    [BinaryContent(Name = "ExternalSocketBuffs", NodeType = BinaryContentTypes.Node)]
    public ExternalSocketBuffs ExternalSocketBuffs { get; set; }

  }
}