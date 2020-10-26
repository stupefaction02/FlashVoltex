// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.ComponentModel;
using osu.Framework.Input.Bindings;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.FlashVoltex
{
    public class FlashVoltexInputManager : RulesetInputManager<FlashVoltexAction>
    {
        public FlashVoltexInputManager(RulesetInfo ruleset)
            : base(ruleset, 0, SimultaneousBindingMode.Unique)
        {
        }
    }

    public enum FlashVoltexAction
    {
        [Description("Far left button")]
        Key1,

        [Description("Left button")]
        Key2,

        [Description("Right button")]
        Key3,

        [Description("Far right button")]
        Key4
    }
}

