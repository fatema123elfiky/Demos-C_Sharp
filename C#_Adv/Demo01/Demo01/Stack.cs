using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class Stack<T>
    {
        private T []  _items;
        private int _top;

        public int Count => _top;

        public Stack (int capacity)
        {
            _items = new T[capacity];
            _top = 0;
        }

        public void Push(T item)
        {
            if (_top < _items.Length)
                _items[_top++] = item;    
            else
                throw new InvalidOperationException("Stack is full");


        }

        public T Peek () { 
            return _items[_top]; 
        }

        public T Pop()
        {
            if (_top > 0)
                return _items[--_top];
            else
                throw new InvalidOperationException("Stack is empty");
        }
    }
}
