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
            throw new NotImplementedException();
        }

        public int ExtractMax () {
            throw new NotImplementedException();
        }

        public void AddElement (int key) {
            throw new NotImplementedException();
        }

        private void Heapify (int index) {
            throw new NotImplementedException();
        }

        private static int Parent (int child) { throw new NotImplementedException(); }
        private static int LeftChild (int parent) { throw new NotImplementedException(); }
        private static int RightChild (int parent) { throw new NotImplementedException(); }
    }
}
