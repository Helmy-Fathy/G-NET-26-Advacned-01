namespace G_NET_26_Advacned_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Q1: What is a Generic Class? Why Use Generics?
            /*
             A generic class is a class that uses a type parameter (e.g., T) as a placeholder for a data type. 
             The actual type is specified when an instance is created , making one class work for any type.

            Why Use Generics?
            -	Type Safety : Errors are caught at compile time, not runtime.
            -	Performance : No boxing/unboxing for value types (unlike object).
            -	Code Reuse : Write one class/method for all types instead of duplicating code.
            -	Better IntelliSense : IDE knows the real type, giving better auto-complete.
             */
            #endregion

            #region Q2
            //Q2: Write a Generic Class Container<T> with Add and Get Methods
            /*
            public class Container<T>
            {
                private T _item;

                public void Add(T item)
                {
                    _item = item;
                }

                public T Get()
                {
                    return _item;
                }
            }
            */
            #endregion

            #region Q3
            //Q3: What Are Multiple Type Parameters? Write Pair<TKey, TValue>
            /*
             A generic class can declare more than one type parameter. Each parameter is independently replaced when the class is instantiated.

            public class Pair<TKey, TValue>
            {
                public TKey   Key   { get; set; }
                public TValue Value { get; set; }

                public Pair(TKey key, TValue value)
                {
                    Key   = key;
                    Value = value;
                }
                public override string ToString()
                    => $"[{Key}] = {Value}";
            }
             */
            #endregion

            #region Q4
            //Q4: What Is a Generic Method? Write Swap<T> Method
            /*
             A generic method declares its own type parameter(s) independently of any containing class. 
             The compiler can usually infer the type argument from the arguments you pass, so you rarely need to specify it explicitly.

            public static class Utilities
            {
                public static void Swap<T>(ref T a, ref T b)
                {
                    T temp = a;
                    a = b;
                    b = temp;
                }
            }
             */
            #endregion

            #region Q5
            //Q5: Write a Generic Method FindMax<T> that Finds the Maximum Value
            /*
             public static T FindMax<T>(T[] array) where T : IComparable<T>
            {
                if (array == null || array.Length == 0)
                    throw new ArgumentException("Array is empty!");

                T max = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i].CompareTo(max) > 0)
                        max = array[i];
                }
                return max;
            }
             */
            #endregion

            #region Q6
            //Q6: What Is a Generic Interface? Write IRepository<T>
            /*
             A generic interface defines a contract using type parameters. 
             Any class that implements it must specify the actual type, providing a reusable, type-safe abstraction.

            public interface IRepository<T> where T : class
            {
                T?              GetById(int id);
                IEnumerable<T>  GetAll();
                void            Add(T entity);
                void            Update(T entity);
                void            Delete(int id);
            }

             */
            #endregion

        }
    }
}
