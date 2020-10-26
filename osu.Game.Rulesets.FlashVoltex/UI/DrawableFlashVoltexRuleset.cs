// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Framework.Allocation;
using osu.Framework.Input;
using osu.Game.Beatmaps;
using osu.Game.Input.Handlers;
using osu.Game.Replays;
using osu.Game.Rulesets.FlashVoltex.Objects;
using osu.Game.Rulesets.FlashVoltex.Objects.Drawables;
using osu.Game.Rulesets.FlashVoltex.Replays;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Objects.Drawables;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.FlashVoltex.UI
{
    [Cached]
    public class DrawableFlashVoltexRuleset : DrawableRuleset<FlashVoltexHitObject>
    {
        public DrawableFlashVoltexRuleset(FlashVoltexRuleset ruleset, IBeatmap beatmap, IReadOnlyList<Mod> mods = null)
            : base(ruleset, beatmap, mods)
        {
        }

        protected override Playfield CreatePlayfield() => new FlashVoltexPlayfield();

        protected override ReplayInputHandler CreateReplayInputHandler(Replay replay) => new FlashVoltexFramedReplayInputHandler(replay);

        public override DrawableHitObject<FlashVoltexHitObject> CreateDrawableRepresentation(FlashVoltexHitObject h) => new DrawableFlashVoltexHitObject(h);

        protected override PassThroughInputManager CreateInputManager() => new FlashVoltexInputManager(Ruleset?.RulesetInfo);
    }
}
