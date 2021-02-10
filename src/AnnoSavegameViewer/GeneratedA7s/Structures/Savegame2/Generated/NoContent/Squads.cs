namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class Squads {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<SquadsList> SquadsList { get; set; }

  }
}