using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        int [] result = Duplicates.RemoveDuplicates(numbers);
        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int[] numbers = { 1, 2 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);

        // Assert
        CollectionAssert.AreEqual(numbers, result);
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        int[] numbers = { 1, 2, 2 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);

        // Assert
        int[] expected = { 1, 2 };
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        int[] numbers = { 1, 2, 2 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);

        // Assert
        int[] expected = { 1, 2 };
        Assert.AreEqual(expected, result);
    }
}
