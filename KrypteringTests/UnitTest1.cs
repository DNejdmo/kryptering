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
            // Test f�r kryptering
            [Fact]
            public void EncryptToRovarspraket_ShouldEncryptCorrectly()
            {
            // Arrange
            string input = "hejsan";
            string expected = "hohejojsosanon";  // F�rv�ntat resultat

            // Act
            string result = _service.EncryptToRovarspraket(input);

                // Assert
                Assert.Equal(expected, result);
            }

            // Test f�r dekryptering
            [Fact]
            public void DecryptFromRovarspraket_ShouldDecryptCorrectly()
            {
            // Arrange
            string input = "hohejojsosanon";
            string expected = "hejsan";  // F�rv�ntat resultat

            // Act
            string result = _service.DecryptFromRovarspraket(input);

                // Assert
                Assert.Equal(expected, result);
            }


        }
}

