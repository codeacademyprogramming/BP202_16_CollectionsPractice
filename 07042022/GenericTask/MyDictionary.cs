using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTask
{
    internal class MyDictionary<TKey,TValue>
    {
        KeyValuePair<TKey, TValue>[] _keyValuePairs = new KeyValuePair<TKey, TValue>[0];

        public KeyValuePair<TKey, TValue> this[TKey key]
        {
            get
            {
                foreach (var item in _keyValuePairs)
                {
                    if ((object)item.Key == (object)key)
                        return item;
                }
                throw new NullReferenceException();
            }
           
        }

    }
}
