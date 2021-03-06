using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SessionTradeRouteManager {

    [BinaryContent(Name = "IDManager", NodeType = BinaryContentTypes.Node)]
    public SessionTradeRouteManagerIDManager IDManager { get; set; }

    [BinaryContent(Name = "RouteMap", NodeType = BinaryContentTypes.Node)]
    public RouteMap RouteMap { get; set; }

  }
}