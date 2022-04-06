using System;

namespace _07_04_2022_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> ls = new MyList<int>();
            ls.AddItem(5);
            ls.AddItem(8);
            ls.AddItem(9);
            ls.AddItems(3, 4, 6,6,8);

            //ls.PrintArrayElements();

            // Console.WriteLine(ls.Exsist(5) ); 
            //ls.Reverse();
            ls.Indexof(0);
            ls.LastIndexOf(6);

        }
    }
}
/*C#-da istifadə etdiyimiz. List<T> classını custom olaraq yazın.
Indexlə get və ya set etmək mümkün olsun.
- Capacity
- Count
- Add()
- Clear()
- Exist()
- Remove()
- Reverse()
- IndexOf()
- LastIndexOf()
memberləri olacaq*/
