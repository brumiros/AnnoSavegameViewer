using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ThreadState {

    [BinaryContent(Name = "LastReservationTime", NodeType = BinaryContentTypes.Attribute)]
    public object LastReservationTime { get; set; }

    [BinaryContent(Name = "RequestingSessions", NodeType = BinaryContentTypes.Attribute)]
    public object RequestingSessions { get; set; }

    [BinaryContent(Name = "ThreadStateOfEachPeer", NodeType = BinaryContentTypes.Node)]
    public ThreadStateOfEachPeer ThreadStateOfEachPeer { get; set; }

    [BinaryContent(Name = "State", NodeType = BinaryContentTypes.Node)]
    public ThreadStateState State { get; set; }

  }
}