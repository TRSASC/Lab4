namespace Simcorp.IMS.Phone.Screen {
    public class ColourfulScreen : BaseScreen, IShowImage, IShowImageBright {
        int brightness;

        public ColourfulScreen(int vertRes, int horRes, int pixelDencity) : base(vertRes, horRes, pixelDencity) { }

        public virtual int Brightness {
            get { return brightness; }
            set { brightness = value; }
        }

        public override void Show(IScreenable screenImage) {
            //here logic that draws monochrome image can be added
        }
        public virtual void Show(IScreenable screenImage, int brightness) {
            //here logic that draws monochrome image can be added
        }

        public override string ToString() {
            return this.ScreenDescription("Colourful screen");
        }

    }
}