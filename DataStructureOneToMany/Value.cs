using DataStructureOneToMany.Option;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DataStructureOneToMany
{
    public class Value 
    {
        public Option<Key> Key { get; }

        private string valueContent { get; }

        public Option<Key> TryGetKey
        {
            get
            {
                if (Key != null) return Key;
                return None.Value;
            }
        }

        public static Value Create(Key key) => new Value(key);
      

        public static Value Create() => new Value();

        private Value(Key key)
        {
            this.Key = key;
        }
        private Value() 
        {
            this.Key = None.Value;   
        }

        
    }
}
