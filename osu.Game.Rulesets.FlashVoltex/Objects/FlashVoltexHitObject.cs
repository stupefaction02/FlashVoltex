﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Rulesets.Judgements;
using osu.Game.Rulesets.Objects;
using osu.Game.Rulesets.Objects.Types;
using osuTK;

namespace osu.Game.Rulesets.FlashVoltex.Objects
{
    public class FlashVoltexHitObject : HitObject, IHasPosition
    {
        public override Judgement CreateJudgement() => new Judgement();

        public Vector2 Position { get; set; }

        public float X => Position.X;
        public float Y => Position.Y;
    }
}
