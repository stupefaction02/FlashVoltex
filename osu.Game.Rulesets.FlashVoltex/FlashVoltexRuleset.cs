// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Input.Bindings;
using osu.Game.Beatmaps;
using osu.Game.Graphics;
using osu.Game.Rulesets.Difficulty;
using osu.Game.Rulesets.FlashVoltex.Beatmaps;
using osu.Game.Rulesets.FlashVoltex.Mods;
using osu.Game.Rulesets.FlashVoltex.UI;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.UI;
using osuTK;
using osuTK.Graphics;

namespace osu.Game.Rulesets.FlashVoltex
{
    public class FlashVoltexRuleset : Ruleset
    {
        public override string Description => "a very flashvoltexruleset ruleset";

        public override DrawableRuleset CreateDrawableRulesetWith(IBeatmap beatmap, IReadOnlyList<Mod> mods = null) =>
            new DrawableFlashVoltexRuleset(this, beatmap, mods);

        public override IBeatmapConverter CreateBeatmapConverter(IBeatmap beatmap) =>
            new FlashVoltexBeatmapConverter(beatmap, this);

        public override DifficultyCalculator CreateDifficultyCalculator(WorkingBeatmap beatmap) =>
            new FlashVoltexDifficultyCalculator(this, beatmap);

        public override IEnumerable<Mod> GetModsFor(ModType type)
        {
            switch (type)
            {
                case ModType.Automation:
                    return new[] { new FlashVoltexModAutoplay() };

                default:
                    return new Mod[] { null };
            }
        }

        public override string ShortName => "flashvoltexruleset";

        public override IEnumerable<KeyBinding> GetDefaultKeyBindings(int variant = 0) => new[]
        {
            new KeyBinding(InputKey.S, FlashVoltexAction.Key1),
            new KeyBinding(InputKey.D, FlashVoltexAction.Key2),
            new KeyBinding(InputKey.K, FlashVoltexAction.Key3),
            new KeyBinding(InputKey.L, FlashVoltexAction.Key4)
        };

        public override Drawable CreateIcon() => new Icon(ShortName[0]);

        public class Icon : CompositeDrawable
        {
            public Icon(char c)
            {
                InternalChildren = new Drawable[]
                {
                    new Circle
                    {
                        Size = new Vector2(20),
                        Colour = Color4.White,
                    },
                    new SpriteText
                    {
                        Anchor = Anchor.Centre,
                        Origin = Anchor.Centre,
                        Text = c.ToString(),
                        Font = OsuFont.Default.With(size: 18)
                    }
                };
            }
        }
    }
}
