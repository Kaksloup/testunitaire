using Xunit;
using Learning;

namespace LearningUnitTest;

public class MathHelperTest
{
    /// <summary>
    /// Tests that IsEven returns true for an even number.
    /// </summary>
    [Fact]
    public void IsEven_EvenNumber_ReturnsTrue()
    {
        // Arrange
        var helper = new MathHelper();
        int evenNumber = 4;

        // Act
        bool result = helper.IsEven(evenNumber);

        // Assert
        Assert.True(result);
    }

    /// <summary>
    /// Tests that IsEven returns false for an odd number.
    /// </summary>
    [Fact]
    public void IsEven_OddNumber_ReturnsFalse()
    {
        // Arrange
        var helper = new MathHelper();
        int oddNumber = 5;

        // Act
        bool result = helper.IsEven(oddNumber);

        // Assert
        Assert.False(result);
    }

    /// <summary>
    /// Tests that IsEven returns the correct result for various integers.
    /// </summary>
    /// <param name="number">The number to test.</param>
    /// <param name="expected">The expected boolean result.</param>
    [Theory]
    [InlineData(0, true)]
    [InlineData(-2, true)]
    [InlineData(100, true)]
    [InlineData(-3, false)]
    [InlineData(7, false)]
    public void IsEven_VariousNumbers_ReturnsCorrectResult(int number, bool expected)
    {
        // Arrange
        var helper = new MathHelper();

        // Act
        bool result = helper.IsEven(number);

        // Assert
        Assert.Equal(expected, result);
    }
}
