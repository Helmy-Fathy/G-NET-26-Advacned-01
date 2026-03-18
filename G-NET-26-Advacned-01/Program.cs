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
    }
}
}
