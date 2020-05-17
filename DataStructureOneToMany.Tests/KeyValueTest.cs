using DataStructureOneToMany.Option;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DataStructureOneToMany.Tests
{
    [TestClass]
    public class KeyValueTest
    {
        [TestMethod]
        public void Add_Values_WithOutKeys_To_Existing_Key()
        {
            var key = Key.Create();
            ImmutableArray<Value> values = ImmutableArray.Create(
                Value.Create(),
                Value.Create(),
                Value.Create()
                );
            
            foreach(var value in values)
            {
                key.AddValue(value);
            }
            
            Assert.AreEqual(3, key.Values.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ValuesHasPriorMappingToKeyException))]
        public void ValuesAssociating_Value_Previously_Associated_To_Another_Value_Should_Throw_ValuesHasPriorMappingToKeyException()
        {
            var valueWithKey1 = Value.Create(Key.Create());
            var key2 = Key.Create();
            key2.AddValue(valueWithKey1);

        }

        [TestMethod]
        public void Given_Value_With_Key_Should_Return_Key()
        {
            var key1 = Key.Create();
            var valueWithKey1 = Value.Create(key1);
            var key = valueWithKey1.Key as Some<Key>;
            Assert.AreEqual(key.Content,key1);
        }

        [TestMethod]
        public void Given_Value_Without_Key_Should_Return_None_OptionType()
        {
            var valueWithoutKey = Value.Create();
            Option<Key> key = valueWithoutKey.Key;
            Assert.IsTrue(key is None<Key>);
        }
    }
}
