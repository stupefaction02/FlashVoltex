using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Screens;
using osuTK.Graphics;

namespace Snake.Game.FlashVoltex
{
    public class FlashVoltexPlayScreen : Screen
    {
        private PianoPlayfield pianoPlayfield;

        public static Box Box = new Box
        {
            Colour = Color4.Red,
            RelativeSizeAxes = Axes.Both,
            Anchor = Anchor.Centre,
            Origin = Anchor.Centre,
        };

        public FlashVoltexPlayScreen()
        {
            AddInternal(pianoPlayfield = new PianoPlayfield());
        }

        [BackgroundDependencyLoader]
        private void load()
        {
            
        }
    }
}
