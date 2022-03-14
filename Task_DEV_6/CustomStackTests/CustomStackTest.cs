using NUnit.Framework;
using System;
using CustomStack;

namespace CustomStackTest
{
    [TestFixture]
    public class CustomStackTest
    {
        [Test]
        public void IsEmptyTrueTest()
        {
            CustomStack<int> stack = new CustomStack<int>();
            Assert.True(stack.IsEmpty());
        }

        [Test]
        public void IsEmptyFalseTest()
        {
            CustomStack<int> stack = new CustomStack<int>();
            stack.Push(7);
            Assert.False(stack.IsEmpty());
        }

        [TestCase(5)]
        [TestCase("abc")]
        [TestCase(5.2)]
        [TestCase('o')]
        public void PopTest<T>(T item)
        {
            CustomStack<T> stack = new CustomStack<T>();
            stack.Push(item);
            int firstCount = stack.Count;
            T element = stack.Pop();
            int lastCount = stack.Count;
            Assert.AreEqual(element, item);
            Assert.AreEqual(lastCount, 0);
            Assert.AreEqual(firstCount, 1);
            Assert.AreNotEqual(firstCount, lastCount);
        }

        [Test]
        public void PopExeptionTest()
        {
            CustomStack<int> stack = new CustomStack<int>();
            var exeption = Assert.Throws<IndexOutOfRangeException>(() => stack.Pop());
            Assert.AreEqual(exeption.Message, "There are no elements on the stack.");
        }

        [Test]
        public void PopResizeTest()
        {
            CustomStack<int> stack = new CustomStack<int>();

            for (int i = 0; i < 12; i++)
            {
                stack.Push(i);
            }
            int firstCapacity = stack.Capacity;
            int number = stack.Pop();
            number = stack.Pop();
            number = stack.Pop();
            int lastCapacity = stack.Capacity;
            Assert.AreEqual(lastCapacity, 10);
            Assert.AreEqual(firstCapacity, 20);
            Assert.AreNotEqual(firstCapacity, lastCapacity);
        }

        [TestCase(5)]
        [TestCase("abc")]
        [TestCase(5.2)]
        [TestCase('o')]
        public void PushTest<T>(T element)
        {
            CustomStack<T> stack = new CustomStack<T>();
            int firstCapacity = stack.Capacity;
            int firstCount = stack.Count;
            stack.Push(element);
            int lastCount = stack.Count;
            int lastCapacity = stack.Capacity;
            Assert.AreEqual(firstCount, 0);
            Assert.AreEqual(lastCount, 1);
            Assert.AreNotEqual(firstCount, lastCount);
            Assert.AreEqual(firstCapacity, 10);
            Assert.AreEqual(lastCapacity, 10);
            Assert.AreEqual(lastCapacity, firstCapacity);
        }

        [Test]
        public void PushResizeTest()
        {
            CustomStack<int> stack = new CustomStack<int>();
            int firstCapasity = stack.Capacity;
            for (int i = 0; i < 12; i++)
            {
                stack.Push(i);
            }
            int lastCapasity = stack.Capacity;
            Assert.AreEqual(firstCapasity, 10);
            Assert.AreEqual(lastCapasity, 20);
            Assert.AreNotEqual(firstCapasity, lastCapasity);
        }
    }
}
