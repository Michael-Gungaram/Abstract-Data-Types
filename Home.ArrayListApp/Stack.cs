using System;

namespace Home.ArrayListApp
{
    public class Stack<T>
    {
        // Fields
        readonly ArrayList<T> _stack;
        int _counter;

        public Stack()
        {
            _stack = new ArrayList<T>( 5 );
            _counter = 0;
        }

        public int Count
        {
            get { return _stack.Count; }
        }

        public void Push( T item )
        {
            _stack.Add( item );
            _counter++;
        }

        public T Pop()
        {
            T value = _stack[_counter-1];
            _stack.RemoveAt( _counter-1 );
            _counter--;

            return value;
        }

        public T Peek()
        {
            return _stack.GetItem( _counter-1 );
        }
    }
}