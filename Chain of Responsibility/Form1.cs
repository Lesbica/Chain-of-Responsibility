using System;
using System.Drawing;
using System.Windows.Forms;
using Chain_of_Responsibility.Classes;

namespace Chain_of_Responsibility
{
    public partial class Form1 : Form
    {
        AssemblyNode assemblyLine;
        Point nextImageLocation = new Point(10, 10);

        public Form1()
        {
            InitializeComponent();
            assemblyLine = new EngineAssemblyNode();
            AssemblyNode chassisNode = new ChassisAssemblyNode();
            AssemblyNode bodyNode = new BodyAssemblyNode();

            assemblyLine.SetDisplayForm(this);
            chassisNode.SetDisplayForm(this);
            bodyNode.SetDisplayForm(this);

            assemblyLine.SetNextNode(chassisNode);
            chassisNode.SetNextNode(bodyNode);

            this.BackgroundImageLayout = ImageLayout.None;
        }

        private void btnStartAssembly_Click(object sender, EventArgs e)
        {
            CarPart engine = new CarPart("Engine", @"img\Engine.jpg");
            CarPart chassis = new CarPart("Chassis", @"img\Chassis.jpg");
            CarPart body = new CarPart("Body", @"img\Body.jpg");
            CarPart otherPart = new CarPart("Other", null);

            assemblyLine.ProcessPart(engine);
            assemblyLine.ProcessPart(chassis);
            assemblyLine.ProcessPart(body);
            assemblyLine.ProcessPart(otherPart);
        }

        public void DrawImageAtLocation(Image image, Point location, Size newSize)
        {
            Image resizedImage = new Bitmap(image, newSize);

            using (Graphics g = this.CreateGraphics())
            {
                g.DrawImage(resizedImage, location);
            }
        }
    }
}
