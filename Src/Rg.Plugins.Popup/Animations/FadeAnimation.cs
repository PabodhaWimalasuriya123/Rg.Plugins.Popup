﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;

namespace Rg.Plugins.Popup.Animations
{
    internal class FadeAnimation : BaseAnimation
    {
        public override void Preparing(View content, PopupPage page)
        {
            content.Opacity = 0;
        }

        public override void Disposing(View content, PopupPage page)
        {

        }

        public override async Task Appearing(View content, PopupPage page)
        {
            await content.FadeTo(1, Duration);
        }

        public override async Task Disappearing(View content, PopupPage page)
        {
            await content.FadeTo(0, Duration);
        }
    }
}
