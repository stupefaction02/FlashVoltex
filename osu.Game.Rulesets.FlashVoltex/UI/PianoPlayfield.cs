using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osuTK.Graphics;

namespace Snake.Game.FlashVoltex
{
    public class PianoPlayfield : CompositeDrawable
    {
        private FillFlowContainer<Column> columns;

        private Color4 columnColor = new Color4(48, 53, 60, 255);

        public PianoPlayfield()
        {
            Anchor = Anchor.Centre;
            Origin = Anchor.Centre;
            RelativeSizeAxes = Axes.Y;
            AutoSizeAxes = Axes.X;

            Padding = new MarginPadding(30);

            var boxes = new FillFlowContainer<Box>
            {
                Anchor = Anchor.TopCentre,
                RelativeSizeAxes = Axes.Y,
                Direction = FillDirection.Horizontal
            };

            boxes.Add(new Box
            {
                Colour = Color4.Red,
                Width = 50,
                RelativeSizeAxes = Axes.Y
            });
            boxes.Add(new Box
            {
                Colour = Color4.White,
                Width = 50,
                RelativeSizeAxes = Axes.Y,
            });

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
                  //  boxes
                }
            };

            for (int i = 0; i < 4; i++)
            {
                var column = new Column { RelativeSizeAxes = Axes.Y, BackgroundColor = columnColor };
                column.Margin = new MarginPadding { Left = 5.0f };
                columns.Add(column);
            }

            AddInternal(mainContainer);
        }

        [BackgroundDependencyLoader]
        private void load()
        {
          
        }
    }
}
