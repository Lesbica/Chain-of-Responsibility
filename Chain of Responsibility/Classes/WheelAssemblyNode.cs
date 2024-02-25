using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Classes
{
    class ChassisAssemblyNode : AssemblyNode
    {
        public override void ProcessPart(CarPart carPart)
        {
            if (carPart.Name == "Chassis")
            {
                if (DisplayForm != null)
                {
                    DisplayForm.DrawImageAtLocation(Image.FromFile(carPart.ImagePath), new Point(100, 10), new Size(100, 100));
                }
                MessageBox.Show("Додано шасі");
            }
            else if (NextNode != null)
            {
                NextNode.ProcessPart(carPart);
            }
        }
    }

}
