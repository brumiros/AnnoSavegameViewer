using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CreatedTreeMap {

    #region Public Properties

    [BinaryContent(Name = "x", NodeType = BinaryContentTypes.Attribute)]
    public object X { get; set; }

    [BinaryContent(Name = "y", NodeType = BinaryContentTypes.Attribute)]
    public object Y { get; set; }

    [BinaryContent(Name = "bits", NodeType = BinaryContentTypes.Attribute)]
    public object Bits { get; set; }

    #endregion Public Properties
  }
}