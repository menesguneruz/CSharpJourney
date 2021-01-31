using System;
using System.Collections.Generic;
using System.Text;

namespace Generics1
{
    // We are making  a kind of List class manually.
    class MyList<Type>
    {
        Type[] items;

        //Constructor Method. This method's name is same with the class
        // Constructor method runs automatically when we create a new object from the class.
        public MyList()
        {
            items = new Type[0];
        }

        public void Add(Type item)
        {
            Type[] tempArray = items;
            items = new Type[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
