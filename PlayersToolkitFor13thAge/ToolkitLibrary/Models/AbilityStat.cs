﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToolkitLibrary
{
    public class AbilityStat
    {
        public int AbilityStatValue { get; set; }

        public string AbilityStatName { get; private set; }
        public int Modifier { get; private set; }
        public int ModifierWithLevel { get; private set; }

        public int CalculateModifier(int abilityStat) {
            double modifier = Math.Floor(((double)abilityStat - 10) / 2);
            return (int)modifier;
        }

        public int CalculateModifierWithLevel(int abilityStat, int characterLevel) {
            int modifierWithLevel = CalculateModifier(abilityStat) + characterLevel;
            return modifierWithLevel;
        }
    }
}