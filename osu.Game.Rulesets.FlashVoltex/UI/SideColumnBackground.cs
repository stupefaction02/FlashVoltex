using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace osu.Game.Rulesets.FlashVoltex.UI
{
    public class SideColumnBackground : CompositeDrawable
    {
        [Resolved]
        private SideColumn column { get; set; }

        public SideColumnBackground()
        {
            RelativeSizeAxes = Axes.Both;
        }

        [BackgroundDependencyLoader]
        private void load()
        { 
            InternalChildren = new[]
            {
                new Box
                {
                    Name = "Background",
                    RelativeSizeAxes = Axes.Both,
                    Colour = column.BackgroundColor
                },
            };
        }
    }
}
