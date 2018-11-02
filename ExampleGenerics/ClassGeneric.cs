using System;

namespace ExampleGenerics
{
    internal class ClassGeneric<T>
    {
        public T GenericProperty { get; set; }

        public ClassGeneric(T value)
        {
            GenericProperty = value;
        }

        public T GenericMethod(T genericParameter)
        {
            Console.WriteLine($"Constructor: Parameter type: {typeof(T).ToString()}, value: {GenericProperty}");
            Console.WriteLine($"Method: Return type: {typeof(T).ToString()}, value: {genericParameter}");

            return GenericProperty;
        }
    }
}
