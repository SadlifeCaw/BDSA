using System;
using System.IO;
using Xunit;

namespace MyApp.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void main_prints_hallo_world()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            //Assert
            Assert.Equal("Hello World!", output);
        }
    }
}
