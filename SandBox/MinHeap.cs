using System;

namespace SandBox
{
    public class MinHeap
    {
        public const int FRONT = 1;
        private int[] _heap;
        private int _size;
        private int _capacity;

        public MinHeap(int maxCapacity)
        {
            _size = 0;
            _heap = new int[maxCapacity + 1];
            _capacity = maxCapacity;
        }

        private int Parent(int pos)
        {
            return pos / 2;
        }

        private int LeftChild(int pos)
        {
            return pos * 2;
        }

        private int RightChild(int pos)
        {
            return pos * 2 + 1;
        }

        private void Swap(int pos1, int pos2)
        {
            var temp = _heap[pos1];
            _heap[pos1] = _heap[pos2];
            _heap[pos2] = temp;
        }

        public void Insert(int item)
        {
            _size++;
            _heap[_size] = item;

            var parentPos = Parent(_size);
            var insertedItemPos = _size;
            while (parentPos > 0 && _heap[parentPos] > _heap[insertedItemPos])
            {
                Swap(parentPos, insertedItemPos);
                insertedItemPos = parentPos;
                parentPos = Parent(insertedItemPos);
            }
        }

        public int Remove()
        {
            if (_size < 1)
            {
                throw new ArgumentOutOfRangeException("Heap is empty.");
            }

            var min = _heap[FRONT];
            _heap[FRONT] = _heap[_size];
            _size--;

            BubbleDown(FRONT);

            return min;
        }

        private void BubbleDown(int startingPos)
        {
            var curPos = startingPos;
            var smallestPos = curPos;
            bool correctPos = false;

            while (curPos < _size && !correctPos)
            {
                var leftChildPos = LeftChild(curPos);
                var rightChildPos = RightChild(curPos);
                if (leftChildPos <= _size)
                {
                    var leftVal = _heap[leftChildPos];
                    if (leftVal < _heap[smallestPos])
                    {
                        smallestPos = leftChildPos;
                    }
                }
                if (rightChildPos <= _size)
                {
                    var rightVal = _heap[rightChildPos];
                    if (rightVal < _heap[smallestPos])
                    {
                        smallestPos = rightChildPos;
                    }
                }


                if (curPos != smallestPos)
                {
                    Swap(curPos, smallestPos);
                    curPos = smallestPos;
                }
                else
                {
                    correctPos = true;
                }
            }
        }
    }
}
