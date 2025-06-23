using Learning;

namespace LearningUnitTest;

public class MathHelperTest
{
    [Fact]
    public void IsEven_EvenNumber_ReturnsTrue()
    {
        // Arrange
        int number = 4;

        // Act
        bool result = MathHelper.IsEven(number);

        // Assert
        Assert.True(result);
    }
}