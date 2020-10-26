// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Game.Rulesets.Replays;
using osuTK;

namespace osu.Game.Rulesets.FlashVoltex.Replays
{
    public class FlashVoltexReplayFrame : ReplayFrame
    {
        public List<FlashVoltexAction> Actions = new List<FlashVoltexAction>();
        public Vector2 Position;

        public FlashVoltexReplayFrame(FlashVoltexAction? button = null)
        {
            if (button.HasValue)
                Actions.Add(button.Value);
        }
    }
}
