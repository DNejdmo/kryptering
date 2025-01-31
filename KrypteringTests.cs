using Xunit;

namespace Kryptering;

public class KrypteringServiceTests
{
    private readonly KrypteringService _service;

    public KrypteringServiceTests()
    {
        _service = new KrypteringService();
    }

    [Fact]
    public void EncryptToRovarspraket_ShouldEncryptCorrectly()
    {
        // Arrange
        string input = "hej";
        string expected = "hohejoj";

        // Act
        string result = _service.EncryptToRovarspraket(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void DecryptFromRovarspraket_ShouldDecryptCorrectly()
    {
        // Arrange
        string input = "hohejoj";
        string expected = "hej";

        // Act
        string result = _service.DecryptFromRovarspraket(input);

        // Assert
        Assert.Equal(expected, result);
    }


}

