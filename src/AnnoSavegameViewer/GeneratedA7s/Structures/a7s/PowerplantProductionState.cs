// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class PowerplantProductionState {

		[BinaryContent(Name = "InProgress", NodeType = BinaryContentTypes.Attribute)]
		public HexString InProgress { get; set; }

		[BinaryContent(Name = "RemainingTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString RemainingTime { get; set; }

		[BinaryContent(Name = "Productivity", NodeType = BinaryContentTypes.Attribute)]
		public HexString Productivity { get; set; }

	}
}