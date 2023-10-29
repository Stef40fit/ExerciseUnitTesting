using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_NumberLowerThanTwo()
    { //Arrange
        long largestFactor = 1;
        // Act
        //long result = PrimeFactor.FindLargestPrimeFactor(largestFactor);
        //Assert
        Assert.That(() => PrimeFactor.FindLargestPrimeFactor(largestFactor), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        // Arrange
        long largestFactor = 5;
        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(largestFactor);
        //Assert
        Assert.That(result, Is.EqualTo(largestFactor));
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {

        // Arrange
        long largestFactor = 123456789123456789;
        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(largestFactor);
        //Assert
        Assert.That(result, Is.EqualTo(52579));
    }
}
