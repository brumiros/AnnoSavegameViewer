namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class SetBuffs {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<SetBuffsList> SetBuffsList { get; set; }

  }
}