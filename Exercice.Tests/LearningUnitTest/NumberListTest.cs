using Learning;

namespace LearningUnitTest;

public class NumberListTest
{
    [Fact]
    public void Add_Number_IncreasesCount()
    {
        // Arrange
        var list = new NumberList();

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
        var list = new NumberList();
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
        var list = new NumberList();
        list.Add(5);

        // Act
        bool removed = list.Remove(10);

        // Assert
        Assert.False(removed);
        Assert.Equal(1, list.Count());
    }

    [Fact]
    public void GetMax_WithNumbers_ReturnsMaximum()
    {
        // Arrange
        var list = new NumberList();
        list.Add(1);
        list.Add(3);
        list.Add(2);

        // Act
        int max = list.Max();

        // Assert
        Assert.Equal(3, max);
    }

    [Fact]
    public void GetMin_WithNumbers_ReturnsMinimum()
    {
        // Arrange
        var list = new NumberList();
        list.Add(1);
        list.Add(3);
        list.Add(2);

        // Act
        int min = list.Min();

        // Assert
        Assert.Equal(1, min);
    }

    [Fact]
    public void GetAverage_WithNumbers_ReturnsCorrectAverage()
    {
        var list = new NumberList();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);

        // Act
        double average = list.Average();

        // Assert
        Assert.Equal(3.0, average);
    }

    [Theory]
    [InlineData(true, 1, 2, 3)]
    [InlineData(true)]
    public void Clear_ResetsList(bool expectedEmpty, params int[] numbers)
    {
        // Arrange
        var list = new NumberList();
        foreach (var number in numbers)
        {
            list.Add(number);
        }

        // Act
        list.Clear();

        // Assert
        Assert.Equal(expectedEmpty ? 0 : numbers.Length, list.Count());
    }
}