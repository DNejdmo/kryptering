using Org.BouncyCastle.Bcpg.OpenPgp;
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

    [Fact]
    public void EncryptToRovarspraket_VowelsOnly_ShouldRemainUnchanged()
    {
        // Arrange
        string input = "aeiouyåäö";
        string expected = "aeiouyåäö";

        // Act
        string result = _service.EncryptToRovarspraket(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void EncryptToRovarspraket_EmptyString_ShouldRreturnEmptyString()
    {
        string result = _service.EncryptToRovarspraket("");
        Assert.Equal("", result);    
    }

    [Fact]
    public void DecryptFromRovarspraket_EmptyString_ShouldReturnEmptyString()
    {
        string result = _service.DecryptFromRovarspraket("");
        Assert.Equal("", result);
    }

    [Fact]
    public void EncryptToRovarspraket_OnlyVowels_ShouldRemainUnchanged()
    {
        string result = _service.EncryptToRovarspraket("aeiouyåäö");
        Assert.Equal("aeiouyåäö", result);
    }

    [Fact]
    public void EncryptToRovarspraket_OnlyConsonents_ShouldEncodeCorrectly()
    {
        string result = _service.EncryptToRovarspraket("bcdfghjklmnpqrstvwxz");
        Assert.Equal("bobcocdodfofgoghohjojkoklolmomnonpopqoqrorsostotvovwowxoxzoz", result);
    }

}

