using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SessionSoundManager {

    [BinaryContent(Name = "AmbientMoodSoundHandler", NodeType = BinaryContentTypes.Node)]
    public AmbientMoodSoundHandler AmbientMoodSoundHandler { get; set; }

    [BinaryContent(Name = "EnvironmentHandler", NodeType = BinaryContentTypes.Node)]
    public EnvironmentHandler EnvironmentHandler { get; set; }

  }
}