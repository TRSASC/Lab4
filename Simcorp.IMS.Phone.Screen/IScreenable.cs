namespace Simcorp.IMS.Phone.Screen {
    public interface IScreenable {
        int Height { get; set; }
        int Width { get; set; }

        void Drawing();
    }
}
