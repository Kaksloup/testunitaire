using Learning;

namespace LearningUnitTest;

public class NumberListTest
{
    [Fact]
    public void Add_Number_IncreasesCount()
    {
        // Arrange
        NumberList list = new NumberList();

        // Act
        list.Add(5);

        // Assert
        Assert.Equal(1, list.Count());
        Assert.True(list.Contains(5));
    }

    [Fact]
    public void Remove_ExistingNumber_DecreasesCount()
    {
        // Arrange
        NumberList list = new NumberList();
        list.Add(5);

        // Act
        bool removed = list.Remove(5);

        // Assert
        Assert.True(removed);
        Assert.Equal(0, list.Count());
        Assert.False(list.Contains(5));
    }

    [Fact]
    public void Remove_NonExistingNumber_ReturnsFalse()
    {
        // Arrange
        NumberList list = new NumberList();
        list.Add(5);

        // Act
        bool removed = list.Remove(10);

        // Assert
        Assert.False(removed);
        Assert.Equal(1, list.Count());
        Assert.True(list.Contains(5));
    }

    [Fact]
    public void GetMax_WithNumbers_ReturnsMaximum()
    {
        // Arrange
        NumberList list = new NumberList();
        list.Add(1);
        list.Add(3);
        list.Add(2);

        // Act
        int max = list.Max();

        // Assert
        Assert.Equal(3, max);
    }

    [Fact]
    public void GetAverage_WithNumbers_ReturnsCorrectAverage()
    {
        // Arrange
        NumberList list = new NumberList();
        list.Add(1);
        list.Add(3);
        list.Add(2);

        // Act
        double average = list.Average();

        // Assert
        Assert.Equal(2.0, average);
    }
}