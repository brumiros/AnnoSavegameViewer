using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class TransportTasksListTransportType {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public TransportTasksListTransportTypeValue Value { get; set; }

  }
}