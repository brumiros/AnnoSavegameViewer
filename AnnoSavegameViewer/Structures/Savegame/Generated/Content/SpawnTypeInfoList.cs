using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SpawnTypeInfoList {

    [BinaryContent(Name = "SpawnObjectCount", NodeType = BinaryContentTypes.Attribute)]
    public object SpawnObjectCount { get; set; }

    [BinaryContent(Name = "SpawnedObjectIDs", NodeType = BinaryContentTypes.Attribute)]
    public object SpawnedObjectIDs { get; set; }

  }
}