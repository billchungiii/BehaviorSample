using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BehaviorSample
{
    public  class ButtonRotateBehavior : Behavior<Button>
    {  
        protected override void OnAttachedTo(Button bindable)
        {
            bindable.Clicked += Bindable_Clicked; 
            base.OnAttachedTo(bindable);
        }

        async private void Bindable_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            await button.RotateTo(45, 500, Easing.BounceOut);
            await button.RotateTo(0, 500, Easing.BounceOut);
        }

        protected override void OnDetachingFrom(Button bindable)
        {
            bindable.Clicked -= Bindable_Clicked;
            base.OnDetachingFrom(bindable);
        }
    }
}
