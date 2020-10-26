using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osuTK.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace osu.Game.Rulesets.FlashVoltex.UI
{
    [Cached]
    public class SideColumn : Column
    {
        public Color4 BackgroundColor { get; set; }

        public SideColumn()
        {
            Width = 45;
            RelativeSizeAxes = Axes.Y;

            var background = new SideColumnBackground { RelativeSizeAxes = Axes.Both };

            InternalChildren = new[]
            {
                background
                //background.CreateProxy(),
            };
        }
    }
}
