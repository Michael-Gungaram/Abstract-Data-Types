/*
 * 17/02/2015 : must writted but must be tested with units tests.
 * 
 * */

using System;

namespace Home.ArrayListApp
{
    public class Queue<T>
    {
        readonly ArrayList<T> _queue;
        int _counter;

        public Queue()
        {
            _queue = new ArrayList<T>( 5 );
            _counter = 0;
        }

        public int Count
        {
            get { return _queue.Count; }
        }

        public void Enqueue( T item )
        {
            _queue.Add( item );
            _counter++;
        }

        public T Dequeue()
        {
            T value = _queue[0];
            _queue.RemoveAt( 0 );
            return value;
        }

        public T Peek()
        {
            return _queue[0];
        }
    }
}
