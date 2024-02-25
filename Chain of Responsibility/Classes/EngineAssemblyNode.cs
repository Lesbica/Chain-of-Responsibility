namespace Chain_of_Responsibility.Classes
{
    class EngineAssemblyNode : AssemblyNode
    {
        public override void ProcessPart(CarPart carPart)
        {
            if (carPart.Name == "Engine")
            {
                if (DisplayForm != null)
                {
                    DisplayForm.DrawImageAtLocation(Image.FromFile(carPart.ImagePath), new Point(10, 10), new Size(100, 100));
                }
                MessageBox.Show("Додано двигун");
            }
            else if (NextNode != null)
            {
                NextNode.ProcessPart(carPart);
            }
        }
    }
}