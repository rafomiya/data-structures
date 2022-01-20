using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class LinkedList<T>
    {
        private Node<T> _head;
        private int _length;

        /// <summary>
        /// Initiates the LinkedList. If wanted, the
        /// first elements can be defined on the parameters.
        /// </summary>
        public LinkedList(params T[] values)
        {
            foreach (T item in values)
                this.Push(item);
        }

        /// <summary>
        /// Pushes the <c>data</c> from the parameter
        /// to the end of the LinkedList.
        ///</summary>
        public Node<T> Push(T data)
        {
            Node<T> toBeInserted = new Node<T>(data);
            Node<T> currentNode = this._head;

            if (currentNode == null)
            {
                this._head = toBeInserted;
                ++this._length;

                return this._head;
            }

            while (currentNode.Next != null)
                currentNode = currentNode.Next;

            currentNode.Next = toBeInserted;
            ++this._length;

            return toBeInserted;
        }

        /// <summary>
        /// Determines whether the LinkedList
        /// is empty or not.
        /// </summary>
        public bool IsEmpty()
        {
            return this._length == 0;
        }

        /// <summary>
        /// Determines whether the LinkedList
        /// is full or not. Returns <c>false</c>
        /// every time.
        /// </summary>
        public bool IsFull()
        {
            // LinkedLists doens't have a maximum size.
            return false;
        }

        /// <summary>
        /// Returns the amount of itens on
        /// the LinkedList.
        /// </summary>
        public int Count()
        {
            return this._length;
        }

        /// <summary>
        /// Inserts an item on the LinkedList at a
        /// given index. Returns the inserted
        /// node.
        /// </summary>
        public Node<T> Insert(T value, int index)
        {
            if (index < 0)
                throw new ArgumentException("Index must be at least 0.");

            if (index == 0)
            {
                Node<T> elem = new Node<T>(value);
                elem.Next = this._head;
                this._head = elem;
                ++this._length;
                return elem;
            }

            Node<T> current = this._head;

            int count = 0;
            while (current != null && count != index - 1)
            {
                current = current.Next;
                ++count;
            }

            if (current == null)
                throw new IndexOutOfRangeException("Invalid index.");

            Node<T> element = new Node<T>(value);
            element.Next = current.Next;
            current.Next = element;

            ++this._length;

            return element;
        }

        /// <summary>
        /// Prints all the elements of
        /// the LinkedList, one per line.
        /// </summary>
        public void Display()
        {
            Node<T> current = this._head;
            int count = 0;
            while (current != null)
            {
                Console.WriteLine($"{count} - {current.Data}");
                current = current.Next;
                ++count;
            }

            Console.WriteLine($"\nA lista possui {this.Count()} itens.");
        }

        /// <summary>
        /// Deletes the first item with the value
        /// of the parameter. Returns its index.
        /// </summary>
        public int Delete(T item)
        {
            Node<T> previous = default;
            Node<T> current = this._head;

            int count = 0;

            while (current != null && !EqualityComparer<T>.Default.Equals(current.Data, item))
            {
                previous = current;
                current = current.Next;
                ++count;
            }

            if (current == null)
                throw new ArgumentException("The item isn't on the list.");

            if (count == 0)
                this._head = current.Next;
            else
                previous.Next = current.Next;

            this._length--;

            return count;
        }

        /// <summary>
        /// Deletes an item based on its index,
        /// and returns the deleted data.
        /// </summary>
        public T Delete(int index)
        {
            Node<T> previous = default;
            Node<T> current = this._head;

            T value = default;
            int count = 0;

            while (current != null && count != index)
            {
                previous = current;
                current = current.Next;
                value = current.Data;
                ++count;
            }

            if (current == null)
                throw new ArgumentException("The item isn't on the list.");

            if (count == 0)
                this._head = current.Next;

            else
                previous.Next = current.Next;

            this._length--;

            return value;
        }

        /// <summary>
        /// Returns the index of the first item
        /// with the value equals to the given parameter.
        /// </summary>
        public int Search(T item)
        {
            Node<T> current = this._head;
            int index = 0;
            while (!EqualityComparer<T>.Default.Equals(current.Data, item) && current != null)
            {
                current = current.Next;
                ++index;
            }

            if (current == null)
                throw new ArgumentException("The item isn't on the list.");

            return index;
        }

        /// <summary>
        /// Returns the value of an item,
        /// based on its index.
        /// </summary>
        public T Search(int index)
        {
            Node<T> current = this._head;
            int currentIndex = 0;

            while (currentIndex != index && current != null)
            {
                current = current.Next;
                ++currentIndex;
            }

            if (current == null)
                throw new IndexOutOfRangeException("Invalid index.");

            return current.Data;
        }

        /// <summary>
        /// Changes the current instance to its
        /// reverse version. Has no return.
        /// </summary>
        public void Reverse()
        {
            if (this.IsEmpty())
                return;

            Node<T> previous = null;
            Node<T> current = this._head;
            Node<T> nextNode = this._head.Next;

            while (current.Next != null)
            {
                current.Next = previous;
                previous = current;
                current = nextNode;
                nextNode = nextNode.Next;
            }

            this._head = current;
            this._head.Next = previous;
        }

        /// <summary>
        /// Returns a reversed copy of the current
        /// instance of LinkedList.
        /// </summary>
        public LinkedList<T> Reversed()
        {
            LinkedList<T> reversed = new LinkedList<T>();
            Node<T> current = this._head;
            while (current != null)
            {
                reversed.Push(current.Data);
                current = current.Next;
            }

            return reversed;
        }
    }
}
