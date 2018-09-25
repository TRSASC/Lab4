namespace Simcorp.IMS.Phone.Screen
{
    public class MonochromeScreen : BaseScreen, IShowImage {
        public MonochromeScreen(int vertRes, int horRes, int pixelDencity) : base(vertRes, horRes, pixelDencity) { }

        public override void Show(IScreenable screenImage) {
            //here logic that draws monochrome image can be added
        }

        public override string ToString() {
            return this.ScreenDescription("Monochrome screen");
        }

    }
}

