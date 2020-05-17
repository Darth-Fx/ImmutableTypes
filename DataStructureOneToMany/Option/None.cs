using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureOneToMany.Option
{
    public sealed class None<T> : Option<T>
    {
    }

    public sealed class None
    {
        public static None Value { get; } = new None();

        private None() { }
    }
}
