using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureOneToMany.Option
{
    public sealed class Some<T> : Option<T>
    {
        public T Content { get; }

        public Some(T value)
        {
            this.Content = value;
        }
    }
}
