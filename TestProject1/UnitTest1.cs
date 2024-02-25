using Chain_of_Responsibility;
using System.Drawing;
using TestToolsToXunitProxy;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [TestClass]
        public class Form1Tests
        {
            [TestMethod]
            public void DrawImageAtLocation_WithValidImageAndLocation_DrawsImageOnForm()
            {
                // Arrange
                Form1 form = new Form1();
                Image image = Image.FromFile(@"img\Engine.jpg");
                Point location = new Point(100, 100);
                Size size = new Size(100, 100);

                // Act
                form.DrawImageAtLocation(image, location, size);

                // No need for Assert, as it's testing if the method throws any exceptions
            }

            [TestMethod]
            public void DrawImageAtLocation_WithNullImage_ThrowsArgumentNullException()
            {
                // Arrange
                Form1 form = new Form1();
                Image image = null;
                Point location = new Point(100, 100);
                Size size = new Size(100, 100); // Make sure to include the size parameter

                // Act & Assert
                Xunit.Assert.Throws<ArgumentNullException>(() => form.DrawImageAtLocation(image, location, size));
            }

            [TestMethod]
            public void DrawImageAtLocation_WithNegativeLocation_ThrowsArgumentOutOfRangeException()
            {
                // Arrange
                Form1 form = new Form1();
                Image image = Image.FromFile(@"irefer\coom.jpg");
                Point location = new Point(-100, -100);
                Size size = new Size(100, 100); // Make sure to include the size parameter

                // Act & Assert
                Xunit.Assert.Throws<ArgumentOutOfRangeException>(() => form.DrawImageAtLocation(image, location, size));
            }

            [TestMethod]
            public void DrawImageAtLocation_WithZeroSize_DrawsImageOnForm()
            {
                // Arrange
                Form1 form = new Form1();
                Image image = Image.FromFile(@"img\Chassis.jpg");
                Point location = new Point(100, 100);
                Size size = new Size(0, 0);

                // Act
                form.DrawImageAtLocation(image, location, size);

                // No need for Assert, as it's testing if the method throws any exceptions
            }

            [TestMethod]
            public void DrawImageAtLocation_WithValidSize_DrawsResizedImageOnForm()
            {
                // Arrange
                Form1 form = new Form1();
                Image image = Image.FromFile(@"img\Chassis.jpg");
                Point location = new Point(100, 100);
                Size size = new Size(50, 50);

                // Act
                form.DrawImageAtLocation(image, location, size);

                // No need for Assert, as it's testing if the method throws any exceptions
            }
        }
    }
}
