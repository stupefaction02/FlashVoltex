using osu.Framework.Allocation;
using osu.Framework.Extensions.Color4Extensions;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Colour;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Input.Bindings;
using osuTK.Graphics;

namespace osu.Game.Rulesets.FlashVoltex.UI
{
    public class ColumnBackground : CompositeDrawable, IKeyBindingHandler<FlashVoltexAction>
    {
        private Box background;
        private Box backgroundOverlay;

        [Resolved]
        private Column column { get; set; }

        public ColumnBackground()
        {
            RelativeSizeAxes = Axes.Both;
        }

        [BackgroundDependencyLoader]
        private void load()
        {
            InternalChildren = new[]
            {
                background = new Box
                {
                    Name = "Background",
                    RelativeSizeAxes = Axes.Both,
                    Colour = column.BackgroundColor
                },
                backgroundOverlay = new Box
                {
                    Name = "Background Gradient Overlay",
                    RelativeSizeAxes = Axes.Both,
                    Height = 1.5f,
                    Blending = BlendingParameters.Additive,
                    Alpha = 0,
                    Origin = Anchor.BottomLeft,
                    Anchor = Anchor.BottomLeft
                }
            };

            var brightColour = column.HighlightColor.Opacity(0.9f);
            var dimColour = column.HighlightColor.Opacity(0);

            backgroundOverlay.Anchor = backgroundOverlay.Origin = Anchor.BottomLeft;
            backgroundOverlay.Colour = ColourInfo.GradientVertical(dimColour, brightColour);
        }

        public bool OnPressed(FlashVoltexAction action)
        {
            if (action == column.Action.Value)
                backgroundOverlay.FadeTo(1, 50, Easing.OutQuint).Then().FadeTo(0.5f, 250, Easing.OutQuint);
            return false;
        }

        public void OnReleased(FlashVoltexAction action)
        {
            if (action == column.Action.Value)
                backgroundOverlay.FadeTo(0, 250, Easing.OutQuint);
        }
    }
}
