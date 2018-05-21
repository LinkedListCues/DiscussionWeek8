using System;

namespace DiscussionWeek8
{
    /// <summary>
    /// Max binary heap. Stores a bunch of postive Integers.
    /// </summary>
    public class BinaryHeap
    {
        public bool Empty => _size == 0;

        private int MaxSize => _nodes.Length;

        private int _size;
        private readonly int[] _nodes;

        public BinaryHeap (int size = 256) { _nodes = new int[size]; }

        public int Peek () {
            if (Empty) { throw new Exception("Peeking at empty heap!"); }
            return _nodes[0];
        }

        public int ExtractMax () {
            if (Empty) { throw new Exception("Extracting from empty heap!"); }

            int max = _nodes[0];
            _nodes[0] = _nodes[_size - 1];
            _size--;
            Heapify(0);
            return max;
        }

        public void AddElement (int key) {
            if (_size == MaxSize) { throw new Exception("Heap full!"); }

            int i = _size++;

            while (i > 0 && _nodes[Parent(i)] < key) {
                _nodes[i] = _nodes[Parent(i)];
                i = Parent(i);
            }
            _nodes[i] = key;
        }

        private void Heapify (int index) {
            while (true) {
                if (_size == 0) { return; }

                int left = LeftChild(index), right = RightChild(index);
                int largest = left < _size && _nodes[left] > _nodes[index] ? left : index;
                if (right < _size && _nodes[right] > _nodes[largest]) { largest = right; }

                if (largest == index) { return; }

                int temp = _nodes[index];
                _nodes[index] = _nodes[largest];
                _nodes[largest] = temp;
                index = largest;
            }
        }

        private static int Parent (int child) { return (child - 1) / 2; }
        private static int LeftChild (int parent) { return 2 * parent + 1; }
        private static int RightChild (int parent) { return 2 * parent + 2; }
    }
}
