﻿using System.Collections.Generic;

namespace OverworldChests
{
	public class ModConfig
	{
		public bool ModEnabled { get; set; } = true;
		public bool IncludeIndoorLocations { get; set; } = true;
		public string OnlyAllowLocations { get; set; } = "";
		public string DisallowLocations { get; set; } = "";
		public bool RoundNumberOfChestsUp { get; set; } = false;
		public int RespawnInterval { get; set; } = 7;
		public float ChestDensity { get; set; } = 0.001f;
		public int Mult { get; set; } = 100;
		public int MaxItems { get; set; } = 5;
		public int ItemsBaseMaxValue { get; set; } = 100;
		public int MinItemValue { get; set; } = 20;
		public int MaxItemValue { get; set; } = -1;
		public int CoinBaseMin { get; set; } = 20;
		public int CoinBaseMax { get; set; } = 100;
		public float RarityChance { get; set; } = 0.2f;
		public float IncreaseRate { get; set; } = 0.3f;
		public Dictionary<string, int> ItemListChances { get; set; } = new Dictionary<string, int>
		{
			{"MeleeWeapon", 100},
			{"Shirt", 0},
			{"Pants", 0},
			{"Hat", 0},
			{"Boots", 100},
			{"BigCraftable", 50},
			{"Ring", 100},
			{"Seed", 100},
			{"Mineral", 100},
			{"Relic", 100},
			{"Cooking", 0},
			{"Fish", 0},
			{"BasicObject", 0}
		};
	}
}
