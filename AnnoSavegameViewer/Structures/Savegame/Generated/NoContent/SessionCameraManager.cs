using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SessionCameraManager {

    [BinaryContent(Name = "UserSavedCameraStates", NodeType = BinaryContentTypes.Node)]
    public UserSavedCameraStates UserSavedCameraStates { get; set; }

    [BinaryContent(Name = "LastCameraState", NodeType = BinaryContentTypes.Node)]
    public LastCameraState LastCameraState { get; set; }

  }
}