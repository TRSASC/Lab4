using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simcorp.IMS.Phone.Speaker;

namespace IPlayTest {
    [TestClass]
    public class IPlayTest {
        private void IPlayBaseTest(IPlay device, string expectedResult, FakeOutput output) {
            //-- Act
            device.Play(new Track());

            //-- Assert
            Assert.AreEqual(output.Result, expectedResult);
        }

        [TestMethod]
        public void IPlayUnitTest() {
            FakeOutput output;
            IPlay device;
            string expectedMessage;

            ///MonauralSpeaker Test
            output = new FakeOutput();
            device = new MonauralSpeakerSystem(new RealSpeaker(2), 20, output);
            expectedMessage = $"{nameof(MonauralSpeakerSystem)} sound";
            IPlayBaseTest(device, expectedMessage, output);

            ///StereoSpeaker Test
            output = new FakeOutput();
            device = new StereoSpeakerSystem(new RealSpeaker(2), new RealSpeaker(2), 20, output);
            expectedMessage = $"{nameof(StereoSpeakerSystem)} sound";
            IPlayBaseTest(device, expectedMessage, output);

            ///UnofficialHeadset Test
            output = new FakeOutput();
            device = new UnofficialHeadset(new RealSpeaker(2), new RealSpeaker(2), 20, output);
            expectedMessage = $"{nameof(UnofficialHeadset)} sound";
            IPlayBaseTest(device, expectedMessage, output);

            ///SamsungHeadset Test
            output = new FakeOutput();
            device = new SamsungHeadset(new RealSpeaker(2), new RealSpeaker(2), 20, output);
            expectedMessage = $"{nameof(SamsungHeadset)} sound";
            IPlayBaseTest(device, expectedMessage, output);

            ///ExternalSpeaker Test
            output = new FakeOutput();
            device = new ExternalSpeaker(new RealSpeaker(2), 20, output);
            expectedMessage = $"{nameof(ExternalSpeaker)} sound";
            IPlayBaseTest(device, expectedMessage, output);
        }

    }
}
