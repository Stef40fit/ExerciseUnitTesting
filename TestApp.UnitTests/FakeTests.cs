using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveStringNumbers_NullInput_ThrowsException()
    {
        // Arrange
        char[]? input = null;

        // Act + Assert
        Assert.That(() => Fake.RemoveStringNumbers(input), Throws.ArgumentException);
    }

    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {  // Arrange
        char[] inputArray = { '1', 'a' };
       // Act
        char[] result = Fake.RemoveStringNumbers(inputArray);

       // Assert
        char[] expected = { 'a' };
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[] inputArray = { 'b', 'a' };
        // Act
        char[] result = Fake.RemoveStringNumbers(inputArray);

        // Assert
        char[] expected = { 'b', 'a' };
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[] inputArray = Array.Empty<char>();
        // Act
        char[] result = Fake.RemoveStringNumbers(inputArray);

        // Assert
        //char[] expected = Array.Empty<char>();
        Assert.That(result, Is.EqualTo(Array.Empty<char>()));
    }
}
