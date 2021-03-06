using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ModuleOwner {

    [BinaryContent(Name = "BuildingModules", NodeType = BinaryContentTypes.Attribute)]
    public object BuildingModules { get; set; }

    [BinaryContent(Name = "SlotIndexGenerator", NodeType = BinaryContentTypes.Attribute)]
    public object SlotIndexGenerator { get; set; }

  }
}