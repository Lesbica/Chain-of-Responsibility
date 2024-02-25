namespace Chain_of_Responsibility.Classes
{
    abstract class AssemblyNode
    {
        protected AssemblyNode NextNode;
        protected Form1 DisplayForm;

        public void SetNextNode(AssemblyNode nextNode)
        {
            NextNode = nextNode;
        }

        public void SetDisplayForm(Form1 form)
        {
            DisplayForm = form;
        }

        public abstract void ProcessPart(CarPart carPart);
    }
}