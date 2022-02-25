using SingletonExample;
using Xunit;

namespace UnitTesting
{
    public class UnitTest1
    {
        [Fact]
        public void CallGetInstance_ReturnsNotNullInstance()
        {
            //Arrange
            SingletonClass single;
             
            //Act
            single = SingletonClass.GetInstance;

            //Assert
            Assert.NotNull(single);
        }

        [Fact]
        public void MakeTwoObjects_CheckTheyAreTheSameInstance()
        {
            //Arrange
            SingletonClass single1;
            SingletonClass single2;

            //Act
            single1 = SingletonClass.GetInstance;
            single2 = SingletonClass.GetInstance;

            //Assert
            Assert.Equal(single1, single2);
        }
    }
}