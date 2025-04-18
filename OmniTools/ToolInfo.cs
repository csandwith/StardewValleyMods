﻿using Newtonsoft.Json;
using StardewValley;
using StardewValley.Tools;
using System;
using System.Collections.Generic;

namespace OmniTools
{
    // Compat: removed from StardewValley.Tools
    public struct ToolDescription {
        public byte index;

        public byte upgradeLevel;

        public string itemId;

        public ToolDescription(byte index, byte upgradeLevel = 0, string itemId = null) {
            this.index = index;
            this.upgradeLevel = upgradeLevel;
            this.itemId = itemId;
        }
    }

    public class ToolInfo
    {
        public ToolDescription description;
        public string displayName;
        public List<string> enchantments = new();
        public List<int> enchantLevels = new();
        public List<ObjectInfo> attachments = new();
        public Dictionary<string, string> modData = new();
        public List<object> vars = new();
        public ToolInfo()
        {

        }
        public ToolInfo(Tool tool)
        {
            description = ModEntry.GetDescriptionFromTool(tool).Value;
            ModEntry.skip = true;
            displayName = tool.DisplayName;
            ModEntry.skip = false;
            foreach (var e in tool.enchantments)
            {
                enchantments.Add(e.GetType().ToString());
                enchantLevels.Add(e.Level);
            }
            foreach (var o in tool.attachments)
            {
                attachments.Add(o is not null ? new ObjectInfo(o.ItemId, o.Stack, o.Quality, o.uses.Value) : null);
            }
            foreach (var kvp in tool.modData.Pairs)
            {
                if (kvp.Key == ModEntry.toolCountKey || kvp.Key == ModEntry.toolsKey)
                    continue;
                modData.Add(kvp.Key, kvp.Value);
            }
            if(tool is WateringCan)
            {
                vars.Add((tool as WateringCan).WaterLeft);
            }
        }
    }

    public class ObjectInfo
    {
        public string ItemId;
        public int stack;
        public int quality;
        public int uses;

        public ObjectInfo(string ItemId, int stack, int quality, int uses)
        {
            this.ItemId = ItemId;
            this.stack = stack;
            this.quality = quality;
            this.uses = uses;
        }
    }
}