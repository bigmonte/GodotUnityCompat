using Godot;

namespace Bigmonte.Entities
{
    internal class CanvasItemVisibilityHandler : VisibilityHandler
    {
        private readonly CanvasItem CanvasItem;


        public CanvasItemVisibilityHandler(CanvasItem canvasItem)
        {
            CanvasItem = canvasItem;
        }

        public override bool IsVisible
        {
            get
            {
                return CanvasItem.Visible;
            }
        }
    }
}