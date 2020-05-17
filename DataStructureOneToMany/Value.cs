using DataStructureOneToMany.Option;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DataStructureOneToMany
{
    public class Value
    {
        private readonly Option<Key> key;

        public Option<Key> Key
        {
            get => key;
        }

        public Option<Key> TryGetKey
        {
            get
            {
                if (key != null) return key;
                return None.Value;
            }
        }

        public static Value Create(Key key) => new Value(key);
      

        public static Value Create() => new Value();

        private Value(Key key)
        {
            this.key = key;
        }
        private Value() 
        {
            this.key = None.Value;   
        }
    }
}
