using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class OccupyTimesList {

    [BinaryContent(Name = "TrainID", NodeType = BinaryContentTypes.Attribute)]
    public object TrainID { get; set; }

    [BinaryContent(Name = "EnterTime", NodeType = BinaryContentTypes.Attribute)]
    public object EnterTime { get; set; }

    [BinaryContent(Name = "LeaveTime", NodeType = BinaryContentTypes.Attribute)]
    public object LeaveTime { get; set; }

    [BinaryContent(Name = "TrainOwner", NodeType = BinaryContentTypes.Node)]
    public TrainOwner TrainOwner { get; set; }

  }
}