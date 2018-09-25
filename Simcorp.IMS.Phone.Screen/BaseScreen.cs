using System;
using System.Text;

namespace Simcorp.IMS.Phone.Screen {
    public abstract class BaseScreen :IShowImage {
        private double vDiagonal;
        private int vPixelDencity;
        private int vHorizontalResolution;
        private int vVerticalResolution;

        public double Diagonal {
            get { return vDiagonal; }
            private set { vDiagonal = value; }
        }

        public virtual int PixelDencity {
            get { return vPixelDencity; }
            protected set {
                if (value <= 0) { throw new ArgumentOutOfRangeException("Pixel dencity cannot be less or equal to zero."); }
                if (value > 300) { throw new ArgumentOutOfRangeException("Only retina screens can have pixel dencity higher then 300."); }
                vPixelDencity = value; }
        }

        public int HorizontalResolution {
            get { return vHorizontalResolution; }
            private set {
                if (value <= 0) { throw new ArgumentOutOfRangeException("Horizontal resolution cannot be less or equal to zero."); }
                vHorizontalResolution = value; }
        }

        public int VerticalResolution {
            get { return vVerticalResolution; }
            private set {
                if (value <= 0) { throw new ArgumentOutOfRangeException("Vertical resolution cannot be less or equal to zero."); }
                vVerticalResolution = value; }
        }

        public BaseScreen(int vertRes, int horRes, int pixelDencity) {
            VerticalResolution = vertRes;
            HorizontalResolution = horRes;
            PixelDencity = pixelDencity;
            Diagonal = Math.Pow(Math.Pow(VerticalResolution, 2) + Math.Pow(HorizontalResolution, 2), 0.5)/ PixelDencity;
        }

        protected string ScreenDescription(string screenType) {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Screen type: {screenType}");
            descriptionBuilder.AppendLine($"Screen diagonal: {Math.Round(Diagonal,1)}\"");
            descriptionBuilder.Append($"Screen resolution: {VerticalResolution}x{HorizontalResolution}");
            return descriptionBuilder.ToString();
        }

        public abstract void Show(IScreenable screenImage);
    }
}
