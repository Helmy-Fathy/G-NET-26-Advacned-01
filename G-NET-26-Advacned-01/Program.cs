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

            #region Q7
            //Q7: What Is the 'struct' Constraint? Write an Example
            /*
            The struct constraint (where T : struct) restricts T to value types only (int, double, bool, DateTime, custom structs, etc.). 

            public class Nullable<T> where T : struct
            {
                private T?   _value;
                public bool  HasValue => _value.HasValue;

                public void SetValue(T value) => _value = value;

                public T GetValue()
                {
                    if (!HasValue)
                        throw new InvalidOperationException("No value set.");
                    return _value!.Value;
                }
            }
             */
            #endregion

            #region Q8
            //Q8: What Is the 'class' Constraint? Write an Example

            /*
             The class constraint (where T : class) restricts T to reference types only (classes, interfaces, delegates, arrays). 

            public class Repository<T> where T : class
            {
                private readonly List<T> _store = new();

                public void Add(T item)
                {
                    if (item == null) throw new ArgumentNullException(nameof(item));
                    _store.Add(item);
                }

                // Can return null safely because T is a reference type
                public T? Find(Predicate<T> match) => _store.Find(match);

                public int Count => _store.Count;
            }
             */
            #endregion

            #region Q9
            //Q9: What Is the 'new()' Constraint? Write an Example
            /*
             The new() constraint (where T : new()) requires T to have a public parameterless constructor. This allows you to create instances of T inside the generic class/method using new T().

            public class Factory<T> where T : new()
            {
                // Can safely call new T() because of the constraint
                public T Create() => new T();

                public List<T> CreateMany(int count)
                {
                    var list = new List<T>();
                    for (int i = 0; i < count; i++)
                        list.Add(new T());
                    return list;
                }
            }

            public class Product
            {
                public string Name { get; set; } = "Default Product";
            }
             */
            #endregion

            #region Q10
            //Q10: What Is the Interface Constraint? Write an Example
            /*
             The interface constraint restricts T to types that implement a specific interface. This allows the generic code to call interface members on T.

            public static class Sorter
            {
                public static T[] BubbleSort<T>(T[] array) where T : IComparable<T>
                {
                    T[] result = (T[])array.Clone();
                    for (int i = 0; i < result.Length - 1; i++)
                        for (int j = 0; j < result.Length - 1 - i; j++)
                            if (result[j].CompareTo(result[j + 1]) > 0)
                            {
                                T temp      = result[j];
                                result[j]   = result[j + 1];
                                result[j+1] = temp;
                            }
                    return result;
                }
            }
             */

            #endregion

            #region Q11
            //Q11: What Is the Base Class Constraint? Write an Example
            /*
             The base class constraint (where T : SomeBaseClass) restricts T to the specified class or any of its derived classes. This lets you use members of the base class within the generic type.

            public abstract class Shape
            {
                public abstract double Area();
            }

            public class Circle : Shape
            {
                public double Radius { get; set; }
                public override double Area() => Math.PI * Radius * Radius;
            }

            public class Rectangle : Shape
            {
                public double Width { get; set; }
                public double Height { get; set; }
                public override double Area() => Width * Height;
            }

            // Base class constraint: T must be or inherit from Shape
            public class ShapeCollection<T> where T : Shape
            {
                private List<T> _shapes = new();
                public void Add(T shape) => _shapes.Add(shape);

                // Can call Area() because T : Shape
                public double TotalArea()
                    => _shapes.Sum(s => s.Area());
            }

             */
            #endregion

            #region Q12
            //Q12: How Do You Apply Multiple Constraints? Write an Example
            /*
             Rules for Multiple Constraints
             -	Use a separate where clause for each type parameter.
             -	Order within a single clause: class/struct first, then interfaces, then new() last.
             -	A type parameter can have multiple interface constraints.

            // Multiple constraints on one type parameter:
            public class SortedRepository<T> where T : class, IComparable<T>, new()
            {
                private List<T> _items = new();

                public void Add(T item) => _items.Add(item);

                public List<T> GetSorted()
                    => _items.OrderBy(x => x).ToList();

                public T CreateNew() => new T();   // new() allows this
            }

            // Multiple type parameters with different constraints:
            public class Mapper<TSource, TDest>
                where TSource : class
                where TDest   : class, new()
            {
                public TDest Map(TSource source)
                {
                    var dest = new TDest();    // new() on TDest
                    // Copy properties via reflection...
                    return dest;
                }
            }
             */
            #endregion

            #region Q13
            //Q13: What Does the 'default' Keyword Do in Generics?
            /*
             The default keyword returns the default value for a type T without knowing what T is at compile time:
             -	Reference types (class, string, interface): returns null
             -	Numeric types (int, double, etc.): returns 0
             -	bool: returns false
             -	struct types: returns a zero-initialized struct
             */
            #endregion

            #region Q14
            //Q14: Write a SafeList<T> that Returns default When the Index Is Invalid
            /*
             public class SafeList<T>
            {
                private readonly List<T> _items = new();

                public void Add(T item) => _items.Add(item);

                public int Count => _items.Count;

                // Returns default(T) instead of throwing for invalid index
                public T Get(int index)
                {
                    if (index < 0 || index >= _items.Count)
                        return default!;   // Safe fallback
                    return _items[index];
                }

                // Indexer version
                public T this[int index] => Get(index);
            }
             */
            #endregion

            #region Q15
            //Q15: What Is Covariance? Explain the 'out' Keyword
            /*
             Covariance allows a generic interface to be treated as if it works with a more derived (child) type. 
             It is marked with the out keyword. T can only appear in output (return) positions — it cannot be used as a method parameter.
             Memory aid: out = output = producer = covariant = Dog → Animal (child can be used where parent expected).
             */

            #endregion

            #region Q16
            //Q16: What Is Contravariance? Explain the 'in' Keyword
            /*
             Contravariance allows a generic interface to be treated as if it works with a less derived (parent) type. 
             It is marked with the in keyword. T can only appear in input (parameter) positions — it cannot be used as a return type.
             in = input = consumer = contravariant = Animal → Dog (parent can be used where child expected).
             */
            #endregion

        }
    }
}
