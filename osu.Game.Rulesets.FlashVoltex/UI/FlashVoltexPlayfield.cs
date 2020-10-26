// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Allocation;
using osu.Framework.Bindables;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Input.Bindings;
using osu.Game.Rulesets.UI;
using osuTK.Graphics;

namespace osu.Game.Rulesets.FlashVoltex.UI
{
    [Cached]
    public class FlashVoltexPlayfield : Playfield
    {
        private FillFlowContainer<Column> columns;

        private Color4 columnColor = new Color4(48, 53, 60, 255);
        private Color4 rightSideColumnColor = new Color4(15, 155, 255, 255);
        private Color4 leftSideColumnColor = new Color4(254, 42, 143, 255);

        private Color4 highlightColor = new Color4(59, 74, 187, 255);

        [BackgroundDependencyLoader]
        private void load()
        {
            Anchor = Anchor.Centre;
            Origin = Anchor.Centre;
            RelativeSizeAxes = Axes.Y;
            AutoSizeAxes = Axes.X;

            Padding = new MarginPadding(10);

            var leftSideColumn = new SideColumn
            {
                BackgroundColor = leftSideColumnColor,
                RelativeSizeAxes = Axes.Y,
            };

            var rightSideColumn = new SideColumn
            {
                BackgroundColor = rightSideColumnColor,
                RelativeSizeAxes = Axes.Y,
            };

            columns = new FillFlowContainer<Column>
            {
                Anchor = Anchor.TopCentre,
                RelativeSizeAxes = Axes.Y,
                AutoSizeAxes = Axes.X,
                Direction = FillDirection.Horizontal
            };

            Container mainContainer = new Container
            {
                Anchor = Anchor.Centre,
                Origin = Anchor.Centre,
                RelativeSizeAxes = Axes.Y,
                AutoSizeAxes = Axes.X,
                Colour = Color4.AliceBlue,
                Children = new Drawable[]
                {
                    columns
                }
            };

            var action = FlashVoltexAction.Key1;

            columns.Add(leftSideColumn);

            for (int i = 0; i < 4; i++)
            {
                var column = new Column 
                { 
                    Action = new Bindable<FlashVoltexAction>(action++),
                    RelativeSizeAxes = Axes.Y, 
                    BackgroundColor = columnColor,
                    HighlightColor = highlightColor
                };

                if (i > 0)
                    column.Margin = new MarginPadding { Left = 5.0f };

                columns.Add(column);
            }

            columns.Add(rightSideColumn);

            AddRangeInternal(new Drawable[]
            {
                HitObjectContainer,
                mainContainer
            });
        }
    }
}
