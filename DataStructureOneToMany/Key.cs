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
                case Some<Key> somekey when somekey.Content != this:
                    throw new ValuesHasPriorMappingToKeyException(); //could just break as value has a key not same as @this
                case Some<Key> somekey when somekey.Content == this:
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

        public override int GetHashCode() => this.Values.GetHashCode();

        public static bool operator ==(Key a, Key b) => object.ReferenceEquals(a, b) || (!object.ReferenceEquals(a, null) && a.Equals(b));

        public static bool operator !=(Key a, Key b) => !(a == b);

        public bool Equals(Key other) =>
            !object.ReferenceEquals(other, null) && other.Values == this.Values;

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }
            return false;
            
        }
    }
}
