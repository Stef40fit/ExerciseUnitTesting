using Newtonsoft.Json.Linq;
using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    // TODO: finish test
    [Test]
    public void Test_SortInPattern_NullInput_ThrowsException()
    {
        // Arrange
        int[]? inputArray = null;

        // Act + Assert
        Assert.That(() => Pattern.SortInPattern(inputArray), Throws.ArgumentException);
    }

    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        // Arrange
        int[] inputArray = { 1, 2, 1, 3, 4, 10, 12, 15 };
        int[] expectedArray = { 1, 15 ,2 ,12 ,3 ,10, 4 }; // Define the expected sorted array in the specified pattern

        // Act
        int[] result = Pattern.SortInPattern(inputArray);

        // Assert
        CollectionAssert.AreEqual(expectedArray, result);
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {   //Arrange
        int[] emptyArray = Array.Empty<int>();
        // Act
        int[] result = Pattern.SortInPattern(emptyArray);

        // Assert

        Assert.That(result, Is.EqualTo(Array.Empty<int>()));
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        //Arrange
        int[] inputArray = { 1 };
        // Act
        int[] result = Pattern.SortInPattern(inputArray);

        // Assert

        Assert.That(result, Is.EqualTo(inputArray));
    }
}
