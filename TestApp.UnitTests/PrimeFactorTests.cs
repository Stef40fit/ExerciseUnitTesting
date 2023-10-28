using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_NumberLowerThanTwo()
    { //Arrange
        long largestFactor = 3;
        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(largestFactor);
        //Assert
        Assert.That(result, Is.EqualTo(largestFactor));
    }

    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        // Arrange
        long largestFactor = 2;
        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(largestFactor);
        //Assert
        Assert.That(result, Is.EqualTo(largestFactor));
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {

        // Arrange
        long largestFactor = 7;
        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(largestFactor);
        //Assert
        Assert.That(result, Is.EqualTo(largestFactor));
    }
}
