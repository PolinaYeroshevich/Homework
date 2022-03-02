using NUnit.Framework;
using System;
namespace Task_DEV_7
{
    public class Tests
    {
        [Test]
        public void PushTest()
        {
            CustomStack customStack = new CustomStack();
            customStack.Push(7);
            int count = customStack.Count();
            Assert.AreEqual(count, 1);
        }

        [Test]
        public void PushResizeTest()
        {
            CustomStack custom = new CustomStack();
            custom.Push(3);
            custom.Push(7);
            custom.Push(9);
            custom.Push(7);
            custom.Push(3);
            custom.Push(4);
            custom.Push(3);
            custom.Push(7);
            custom.Push(8);
            custom.Push(3);
            custom.Push(1);
            custom.Push(7);
            int capasity = custom.Capacity();
            Assert.AreEqual(capasity, 20);
        }

        [Test]
        public void PopTest()
        {
            CustomStack custom = new CustomStack();
            custom.Push(3);
            custom.Push(7);            
            int element = custom.Pop();
            int count = custom.Count();
            Assert.AreEqual(count, 1);
        }

        [Test]
        public void PopResizeTest()
        {
            CustomStack custom = new CustomStack();
            custom.Push(3);
            custom.Push(9);
            custom.Push(7);
            custom.Push(3);
            custom.Push(4);
            custom.Push(3);
            custom.Push(7);
            custom.Push(8);
            custom.Push(3);
            custom.Push(1);            
            int pop = custom.Pop();
            int capasity = custom.Capacity();
            Assert.AreEqual(capasity, 10);
        }

        [Test]
        public void PopExeptionTest()
        {
            CustomStack custom = new CustomStack();
            Assert.Throws<IndexOutOfRangeException>(() => custom.Pop());
        }

        [Test]
        public void IsEmptyTest()
        {
            CustomStack custom = new CustomStack();
            bool isEmpty = custom.IsEmpty();
            Assert.True(isEmpty);
        }

        [Test]
        public void CapacityTest()
        {
            CustomStack custom = new CustomStack();
            int capacity = custom.Capacity();
            Assert.AreEqual(capacity, 10);
        }
    }
}
