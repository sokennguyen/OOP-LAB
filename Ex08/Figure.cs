using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB
{
    internal class Figure:GraphicalObject
    {
        const int MAX = 100;
        GraphicalObject[] gObjects;
        int nbOfObjs = 0;
        public Figure(string color, GraphicalObject gObject):base (color)
        {
            gObjects = new GraphicalObject[MAX];
            gObjects[0] = gObject;
            nbOfObjs++;
        }        
        public void Add(int index,GraphicalObject obj)
        {
            if (nbOfObjs < 100)
            {
                gObjects[index] = obj;
                nbOfObjs++;
            }
            else return;
        }
        public void RemoveFrom(int index)
        {
            gObjects[index] = null;
            nbOfObjs--;
        }
        public GraphicalObject GetFrom(int index)
        {
            return gObjects[index];
        }
        public override void Display()
        {
            foreach (GraphicalObject obj in gObjects)
            {
                if (obj != null)
                    obj.Display();
            }
        }

    }
}
