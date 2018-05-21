using System;
using DiscussionWeek8;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HeapTests
{
    [TestClass]
    public class HeapTests
    {
        [TestMethod]
        public void EmptyHeap () {
            var heap = new BinaryHeap();
            Assert.IsTrue(heap.Empty);
        }

        [TestMethod]
        public void NonEmptyHeap () {
            var heap = new BinaryHeap();
            heap.AddElement(1);
            Assert.IsFalse(heap.Empty);
        }

        [TestMethod]
        public void EmptyHeapComplex () {
            var heap = new BinaryHeap(1024);
            for (int i = 1; i <= 1000; i++) { heap.AddElement(i); }
            for (int i = 1000; i >= 1; i--) { heap.ExtractMax(); }
            Assert.IsTrue(heap.Empty);
        }

        [TestMethod, ExpectedException(typeof(Exception))]
        public void ExceptionOnEmptyHeapExtract () {
            var heap = new BinaryHeap();
            heap.ExtractMax();
        }

        [TestMethod, ExpectedException(typeof(Exception))]
        public void ExceptionOnFullHeap () {
            var heap = new BinaryHeap(1);
            heap.AddElement(1);
            heap.AddElement(2);
        }

        [TestMethod]
        public void ExtractMaxSimple () {
            var heap = new BinaryHeap();
            heap.AddElement(5);
            Assert.AreEqual(5, heap.ExtractMax());
        }

        [TestMethod]
        public void ExtractMaxMany () {
            var heap = new BinaryHeap(1024);
            for (int i = 1; i <= 1000; i++) { heap.AddElement(i); }
            for (int i = 1000; i >= 1; i--) { Assert.AreEqual(i, heap.ExtractMax()); }
        }

        [TestMethod]
        public void ExtactMaxExtreme () {
            const int count = 1048576;
            var heap = new BinaryHeap(count);
            for (int i = 0; i < count; i++) { heap.AddElement(i); }
            for (int i = count - 1; i >= 0; i--) { Assert.AreEqual(i, heap.ExtractMax()); }
        }
    }
}
