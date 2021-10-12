namespace AD
{
    public partial class FirstChildNextSiblingNode<T> : IFirstChildNextSiblingNode<T>
    {
        public FirstChildNextSiblingNode<T> firstChild;
        public FirstChildNextSiblingNode<T> nextSibling;
        public T data;

        public FirstChildNextSiblingNode(T data, FirstChildNextSiblingNode<T> firstChild, FirstChildNextSiblingNode<T> nextSibling)
        {
            this.data = data;
            this.firstChild = firstChild;
            this.nextSibling = nextSibling;
        }

        public FirstChildNextSiblingNode(T data)
        {
            this.data = data;
        }

        public T GetData()
        {
            return data;
        }

        public FirstChildNextSiblingNode<T> GetFirstChild()
        {
            return firstChild;
        }

        public FirstChildNextSiblingNode<T> GetNextSibling()
        {
            return nextSibling;
        }
        
        public override string ToString()
        {
            string toReturn = "";
            toReturn += data.ToString();
            if (firstChild != null)
            {
                toReturn += ",FC(";
                toReturn += firstChild.ToString();
                toReturn += ")";
            }

            if (nextSibling != null)
            {
                toReturn += ",NS(";
                toReturn += nextSibling.ToString();
                toReturn += ")";
            }

            return toReturn;
        }
    }
}