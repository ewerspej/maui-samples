namespace MauiSamples.Graphics.Drawables
{
    public class CircleDrawable : BindableObject, IDrawable
    {
        public double Radius { get; set; }

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            canvas.StrokeColor = Colors.Black;
            canvas.StrokeSize = 5.0f;
            canvas.DrawCircle(dirtyRect.Center, Radius);
        }
    }
}
