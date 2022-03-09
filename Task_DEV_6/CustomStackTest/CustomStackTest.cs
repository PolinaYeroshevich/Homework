using NUnit.Framework;
using System;
using CustomStack;

namespace CustomStackTest
{
    public class Tests
    {
        [Test]
        public void PushIntTest()
        {
            CustomStack<int> custom = new CustomStack<int>();
            int count = custom.Count();
            custom.Push(7);
            count = custom.Count();
            Assert.AreEqual(count, 1);
        }

        [Test]
        public void PushStringTest()
        {
            CustomStack<string> custom = new CustomStack<string>();
            int count = custom.Count();
            custom.Push("abc");
            count = custom.Count();
            Assert.AreEqual(count, 1);
        }

        [Test]
        public void PushResizeTest()
        {
            CustomStack<int> custom = new CustomStack<int>();
            int capasity = custom.Capacity();
            for (int i = 0; i < 12; i++)
            {
                custom.Push(i);
            }
            capasity = custom.Capacity();
            Assert.AreEqual(capasity, 20);
        }

        [Test]
        public void PopResizeTest()
        {
            CustomStack<int> custom = new CustomStack<int>();
            int capasity = custom.Capacity();
            for (int i = 0; i < 12; i++)
            {
                custom.Push(i);
            }
            int number = custom.Pop();
            number = custom.Pop();
            number = custom.Pop();
            capasity = custom.Capacity();
            Assert.AreEqual(capasity, 10);
        }

        [Test]
        public void PopIntTest()
        {
            CustomStack<int> custom = new CustomStack<int>();
            custom.Push(3);
            custom.Push(7);
            int element = custom.Pop();
            int count = custom.Count();
            Assert.AreEqual(element, 7);
            Assert.AreEqual(count, 1);
        }

        [Test]
        public void PopStringTest()
        {
            CustomStack<string> custom = new CustomStack<string>();
            custom.Push("abc");
            custom.Push("cba");
            string element = custom.Pop();
            int count = custom.Count();
            Assert.AreEqual(element, "cba");
            Assert.AreEqual(count, 1);
        }

        [Test]
        public void PopExeptionTest()
        {
            CustomStack<int> custom = new CustomStack<int>();
            var exeption = Assert.Throws<IndexOutOfRangeException>(() => custom.Pop());
            Assert.AreEqual(exeption.Message, "There are no elements on the stack.");
        }

        [Test]
        public void IsEmptyTrueTest()
        {
            CustomStack<int> custom = new CustomStack<int>();
            Assert.True(custom.IsEmpty());
        }

        [Test]
        public void IsEmptyFalseTest()
        {
            CustomStack<int> custom = new CustomStack<int>();
            custom.Push(7);
            Assert.False(custom.IsEmpty());
        }

        [Test]
        public void CapacityTest()
        {
            CustomStack<int> custom = new CustomStack<int>();
            int capacity = custom.Capacity();
            Assert.AreEqual(capacity, 10);
        }
    }
}
