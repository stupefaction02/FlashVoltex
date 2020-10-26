// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Game.Beatmaps;
using osu.Game.Replays;
using osu.Game.Rulesets.FlashVoltex.Objects;
using osu.Game.Rulesets.Replays;

namespace osu.Game.Rulesets.FlashVoltex.Replays
{
    public class FlashVoltexAutoGenerator : AutoGenerator
    {
        protected Replay Replay;
        protected List<ReplayFrame> Frames => Replay.Frames;

        public new Beatmap<FlashVoltexHitObject> Beatmap => (Beatmap<FlashVoltexHitObject>)base.Beatmap;

        public FlashVoltexAutoGenerator(IBeatmap beatmap)
            : base(beatmap)
        {
            Replay = new Replay();
        }

        public override Replay Generate()
        {
            Frames.Add(new FlashVoltexReplayFrame());

            foreach (FlashVoltexHitObject hitObject in Beatmap.HitObjects)
            {
                Frames.Add(new FlashVoltexReplayFrame
                {
                    Time = hitObject.StartTime,
                    Position = hitObject.Position,
                    // todo: add required inputs and extra frames.
                });
            }

            return Replay;
        }
    }
}
