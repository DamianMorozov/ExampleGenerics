namespace ExampleGenerics
{
    internal class ClassGenericChild<U> : ClassGeneric<U>
    {
        public ClassGenericChild(U value) : base(value)
        {
        }
    }
}
