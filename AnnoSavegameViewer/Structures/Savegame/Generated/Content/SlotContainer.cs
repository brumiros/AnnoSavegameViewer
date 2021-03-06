using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SlotContainer {

    [BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
    public object AreaID { get; set; }

    [BinaryContent(Name = "UnlimitedSlotCount", NodeType = BinaryContentTypes.Attribute)]
    public object UnlimitedSlotCount { get; set; }

    [BinaryContent(Name = "UnlimitedStack", NodeType = BinaryContentTypes.Attribute)]
    public object UnlimitedStack { get; set; }

    [BinaryContent(Name = "SlotList", NodeType = BinaryContentTypes.Node)]
    public SlotContainerSlotList SlotList { get; set; }

  }
}