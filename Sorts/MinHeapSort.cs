﻿using System;
using System.Collections.Generic;

namespace Sorting_algorithm_benchmark_grapher.Sorts
{
    internal class MinHeapSort : ISorter
    {
        public string Title => "Min heap sort";

        public string Message => "";

        public string Category => "Selection sorts";

        public Complexity Time => Complexity.GOOD;

        public void RunSort<T>(T[] array, int sortLength, int parameter, IComparer<T> cmp)
        {
            HeapSorting.HeapSort(array, 0, sortLength, false, cmp);
            Array.Reverse(array);
        }
    }
}
