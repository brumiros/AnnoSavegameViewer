// Copyright � 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class EventBuffer {

		[BinaryContent(Name = "IslandRatings", NodeType = BinaryContentTypes.Node)]
		public IslandRatings IslandRatings { get; set; }

		[BinaryContent(Name = "StartResources", NodeType = BinaryContentTypes.Node)]
		public StartResources StartResources { get; set; }

		[BinaryContent(Name = "WorkforceRaw", NodeType = BinaryContentTypes.Node)]
		public WorkforceRaw WorkforceRaw { get; set; }

		[BinaryContent(Name = "Workforce", NodeType = BinaryContentTypes.Node)]
		public Workforce Workforce { get; set; }

		[BinaryContent(Name = "ChangeObjects", NodeType = BinaryContentTypes.Node)]
		public ChangeObjects ChangeObjects { get; set; }

		[BinaryContent(Name = "ChangeStreets", NodeType = BinaryContentTypes.Node)]
		public ChangeStreets ChangeStreets { get; set; }

		[BinaryContent(Name = "RoundtripsFinished", NodeType = BinaryContentTypes.Node)]
		public RoundtripsFinished RoundtripsFinished { get; set; }

		[BinaryContent(Name = "IslandLeave", NodeType = BinaryContentTypes.Node)]
		public IslandLeave IslandLeave { get; set; }

		[BinaryContent(Name = "IslandSettle", NodeType = BinaryContentTypes.Node)]
		public IslandSettle IslandSettle { get; set; }

		[BinaryContent(Name = "TradedGoods", NodeType = BinaryContentTypes.Node)]
		public EventBufferTradedGoods TradedGoods { get; set; }

		[BinaryContent(Name = "RuinOrAbandon", NodeType = BinaryContentTypes.Node)]
		public RuinOrAbandon RuinOrAbandon { get; set; }

		[BinaryContent(Name = "RestoreMilitaryFleet", NodeType = BinaryContentTypes.Attribute)]
		public HexString RestoreMilitaryFleet { get; set; }

	}
}