﻿using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Serialization.Memory;
using System.Text;

namespace AnnoSavegameViewer.Structures.RDA {

  public class FileHeader {

    #region Public Properties

    public string FilePath { get; set; }
    public ulong DataOffset { get; set; }
    public ulong CompressedSize { get; set; }
    public ulong UncompressedSize { get; set; }
    public ulong TimeStamp { get; set; }
    public ulong Unknown { get; set; }

    #endregion Public Properties

    #region Public Constructors

    public FileHeader(ref MemoryReader reader) {
      FilePath = reader.ReadString(Encoding.UTF8, StringPattern.FixByteCount, 520).TrimEnd('\0');
      DataOffset = reader.ReadUInt64();
      CompressedSize = reader.ReadUInt64();
      UncompressedSize = reader.ReadUInt64();
      TimeStamp = reader.ReadUInt64();
      Unknown = reader.ReadUInt64();
    }

    #endregion Public Constructors
  }
}