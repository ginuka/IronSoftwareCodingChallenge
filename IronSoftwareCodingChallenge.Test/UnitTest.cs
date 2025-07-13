namespace IronSoftwareCodingChallenge.Test
{
    public class UnitTest
    {
        [Fact]
        public void BasicTest()
        {
            var result = KeyPadService.OldPhonePad("222#");
            Assert.Equal("C", result);
        }

        [Fact]
        public void WithoutSend()
        {
            var result = KeyPadService.OldPhonePad("222");
            Assert.Equal("Input not completed", result);
        }

        [Fact]
        public void EmptyTest()
        {
            var result = KeyPadService.OldPhonePad("");
            Assert.Equal("Input is empty", result);
        }

        [Fact]
        public void AdvanceTest01()
        {
            var result = KeyPadService.OldPhonePad("222 2 22#");
            Assert.Equal("CAB", result);
        }

        [Fact]
        public void AdvanceTest02()
        {
            var result = KeyPadService.OldPhonePad("4433555 555666#");
            Assert.Equal("HELLO", result);
        }

        [Fact]
        public void Backspacetest()
        {
            var result = KeyPadService.OldPhonePad("227*#");
            Assert.Equal("B", result);
        }
    }
}