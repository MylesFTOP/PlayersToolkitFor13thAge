﻿using System;

namespace ToolkitLibrary
{
    public class AbilityStat
    {
        public uint AbilityStatValue { get; set; }

        public int CalculateModifier(uint abilityStat) {
            double modifier = Math.Floor(((double)abilityStat - 10) / 2);
            return (int)modifier;
        }

        public int CalculateModifierWithLevel(uint abilityStat, uint characterLevel) {
            int modifierWithLevel = CalculateModifier(abilityStat) + (int)characterLevel;
            return modifierWithLevel;
        }

        public AbilityStat() {

        }

        public AbilityStat(uint inputValue) {
            AbilityStatValue = inputValue;
        }

        public AbilityStat(string inputValue) {
            AbilityStatValue = uint.Parse(inputValue);
        }
    }
}
