using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class StreetID {

    [BinaryContent(Name = "x", NodeType = BinaryContentTypes.Attribute)]
    public object X { get; set; }

    [BinaryContent(Name = "y", NodeType = BinaryContentTypes.Attribute)]
    public object Y { get; set; }

    [BinaryContent(Name = "val", NodeType = BinaryContentTypes.Attribute)]
    public object Val { get; set; }

  }
}