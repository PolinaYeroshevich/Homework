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
        public void PopTest<T>(T element)
        {
            CustomStack<T> stack = new CustomStack<T>();
            stack.Push(element);
            int startCount = stack.Count;
            T pop = stack.Pop();
            int lastCount = stack.Count;
            Assert.AreEqual(pop, element);
            Assert.AreEqual(lastCount, 0);
            Assert.AreEqual(startCount, 1);
            Assert.AreNotEqual(startCount, lastCount);
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
            int startCapacity = stack.Capacity;
            int number = stack.Pop();
            number = stack.Pop();
            number = stack.Pop();
            int endCapasity = stack.Capacity;
            Assert.AreEqual(endCapasity, 10);
            Assert.AreEqual(startCapacity, 20);
            Assert.AreNotEqual(startCapacity, endCapasity);
        }

        [TestCase(5)]
        [TestCase("abc")]
        [TestCase(5.2)]
        [TestCase('o')]
        public void PushTest<T>(T element)
        {
            CustomStack<T> stack = new CustomStack<T>(15);
            int startCapacity = stack.Capacity;
            int startCount = stack.Count;
            stack.Push(element);
            int endCount = stack.Count;
            int endCapasity = stack.Capacity;
            Assert.AreEqual(startCount, 0);
            Assert.AreEqual(endCount, 1);
            Assert.AreNotEqual(startCount, endCount);
            Assert.AreEqual(startCapacity, 15);
            Assert.AreEqual(endCapasity, 15);
            Assert.AreEqual(startCapacity, endCapasity);
        }

        [Test]
        public void PushResizeTest()
        {
            CustomStack<int> stack = new CustomStack<int>();
            int startCapacity = stack.Capacity;
            for (int i = 0; i < 12; i++)
            {
                stack.Push(i);
            }
            int endCapasity = stack.Capacity;
            Assert.AreEqual(startCapacity, 10);
            Assert.AreEqual(endCapasity, 20);
            Assert.AreNotEqual(startCapacity, endCapasity);
        }
    }
}
