using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;
using Memorare.Logic;

namespace Memorare.visual
{
    public abstract class VisualLayer : Panel
    {
        protected Panel baseLayer;
        protected Grid root;

        public VisualLayer()
        {
        }
        public void setView(Grid root)
        {
            this.root = root;
        
            if(root.Children.ToArray().Length > 0)
            {
                root.Children.RemoveAt(0);
            }
            root.Children.Add(baseLayer);
        }
    }
}