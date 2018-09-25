using System;

namespace Simcorp.IMS.Phone.Screen{
    public class RetinaScreen : ColourfulScreen, IShowImage, IShowImageBright {
        private int vPixelDencity;
        public override int PixelDencity {
            get { return vPixelDencity; }
            protected set {
                if (value <= 300) { throw new ArgumentOutOfRangeException("Pixel dencity cannot be less or equal to zero."); }
                vPixelDencity = value;
            }
        }

        public RetinaScreen(int vertRes, int horRes, int pixelDencity) : base(vertRes, horRes, pixelDencity) { }

        public override void Show(IScreenable screenImage) {
            //here logic that draws monochrome image can be added
        }
        public override void Show(IScreenable screenImage, int brightness) {
            //here logic that draws monochrome image can be added
        }

        public override string ToString() {
            return this.ScreenDescription("Retina screen");
        }

    }

}
