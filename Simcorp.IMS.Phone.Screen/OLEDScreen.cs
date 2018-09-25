namespace Simcorp.IMS.Phone.Screen {
    public class OLEDScreen : ColourfulScreen, IShowImage, IShowImageBright {
        public OLEDScreen(int vertRes, int horRes, int pixelDencity) : base(vertRes, horRes, pixelDencity) { }

        public override void Show(IScreenable screenImage)
        {
            //here logic that draws monochrome image can be added
        }
        public override void Show(IScreenable screenImage, int brightness)
        {
            //here logic that draws monochrome image can be added
        }

        public override string ToString()
        {
            return this.ScreenDescription("OLED screen");
        }
    }
}

