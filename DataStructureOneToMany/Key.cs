using DataStructureOneToMany.Option;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace DataStructureOneToMany
{
    public class Key
    {
        private Key() => Values = ImmutableList.Create<Value>();

        public static Key Create() => new Key();

        public IImmutableList<Value> Values { get; set; }

        public void AddValue(Value value)
        {
            switch (value.TryGetKey)
            {
                case Some<Key> somekey when !somekey.Equals(this):
                    throw new ValuesHasPriorMappingToKeyException(); //could just break as value has a key not same as @this
                case Some<Key> somekey: 
                    Values = Values.Add(value);
                    break;
                case None<Key> nonekey: 
                    Value.Create(this);
                    Values = Values.Add(value);
                    break;
                default:
                    break;
            }
        }
    }
}
