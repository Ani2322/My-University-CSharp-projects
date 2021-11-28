using System;
using System.Collections.Generic;
using System.Text;

namespace lab9
{
    class Context
    {
        SortMethod sort;
        public Context(SortMethod sort)
        {
            this.sort = sort;
        }
        public void ContextInterface(int [] arr, string method)
        {
            sort.ShowMethod(method);
            sort.CreateSortMethod(arr);
            sort.printArray(arr);
          
        }
    }
}
