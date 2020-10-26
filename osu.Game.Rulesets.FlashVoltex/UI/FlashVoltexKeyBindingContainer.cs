using System;
using System.Collections.Generic;
using System.Text;
using osu.Framework.Input.Bindings;

namespace osu.Game.Rulesets.FlashVoltex.UI
{
    public class FlashVoltexKeyBindingContainer : KeyBindingContainer<FlashVoltexAction>
    {
        public override IEnumerable<KeyBinding> DefaultKeyBindings => new[]
        {
            new KeyBinding(new[] { InputKey.S }, FlashVoltexAction.Key1),
            new KeyBinding(new[] { InputKey.D }, FlashVoltexAction.Key2),
            new KeyBinding(new[] { InputKey.K }, FlashVoltexAction.Key3),
            new KeyBinding(new[] { InputKey.L }, FlashVoltexAction.Key4),
        };

        protected override void LoadComplete()
        {
            base.LoadComplete();
        }
    }
}
