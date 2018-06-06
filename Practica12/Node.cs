using System;

namespace Practica12
{
    class Node
    {
        private Node last;
        private Node next;
        private Node right;
        private Node left;
        private string value;

        public Node Last { get { return last; } set { last = value; } }
        public Node Next { get { return next; } set { last = value; } }
        public Node Right{ get { return right;} set { last = value; } }
        public Node Left { get { return left; } set { last = value; } }
        public string Value { get { return value; } set { this.value = value; } }
    }
}
