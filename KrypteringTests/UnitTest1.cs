using Xunit;

namespace KrypteringTests
{
  
        public class KrypteringServiceTests
        {
         private readonly KrypteringService _service;

        public KrypteringServiceTests()
        {
            _service = new KrypteringService();
        }
            // Test för kryptering
            [Fact]
            public void EncryptToRovarspraket_ShouldEncryptCorrectly()
            {
            // Arrange
            string input = "hejsan";
            string expected = "hohejojsosanon";  // Förväntat resultat

            // Act
            string result = _service.EncryptToRovarspraket(input);

                // Assert
                Assert.Equal(expected, result);
            }

            // Test för dekryptering
            [Fact]
            public void DecryptFromRovarspraket_ShouldDecryptCorrectly()
            {
            // Arrange
            string input = "hohejojsosanon";
            string expected = "hejsan";  // Förväntat resultat

            // Act
            string result = _service.DecryptFromRovarspraket(input);

                // Assert
                Assert.Equal(expected, result);
            }


        }
}

