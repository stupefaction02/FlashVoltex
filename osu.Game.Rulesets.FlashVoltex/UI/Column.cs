using osu.Framework.Allocation;
using osu.Framework.Bindables;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Input.Bindings;
using osuTK.Graphics;

namespace osu.Game.Rulesets.FlashVoltex.UI
{
    [Cached]
    public class Column : CompositeDrawable, IKeyBindingHandler<FlashVoltexAction>
    {
        public Color4 BackgroundColor { get; set; }

        public Color4 HighlightColor { get; set; }

        public IBindable<FlashVoltexAction> Action { get; set; }

        public Column()
        {
            Width = 70;
            RelativeSizeAxes = Axes.Y;

            var background = new ColumnBackground { RelativeSizeAxes = Axes.Both };

            InternalChildren = new[]
            {
                background
                //background.CreateProxy(),
            };
        }

        protected override IReadOnlyDependencyContainer CreateChildDependencies(IReadOnlyDependencyContainer parent)
        {
            var dependencies = new DependencyContainer(base.CreateChildDependencies(parent));

            if (Action != default)
                dependencies.CacheAs<IBindable<FlashVoltexAction>>(Action);
            return dependencies;
        }


        public bool OnPressed(FlashVoltexAction action)
        {
            return false;
        }

        public void OnReleased(FlashVoltexAction action)
        {
        }
    }
}
