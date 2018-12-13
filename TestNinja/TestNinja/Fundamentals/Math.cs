﻿using System.Collections.Generic;

namespace TestNinja.Fundamentals
{
    public class Math
    {
        public int Add(int a, int b)
        { 
            return a + b; // Only one exceution path
        }
        
        public int Max(int a, int b)
        {
            return (a > b) ? a : b; // Two execution paths
        }

        // Testing arrays and collections
        public IEnumerable<int> GetOddNumbers(int limit)
        {
            for (var i = 0; i <= limit; i++)
                if (i % 2 != 0)
                    yield return i; 
        }
    }
}