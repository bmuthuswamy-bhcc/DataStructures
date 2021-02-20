using System;
using System.Collections.Generic;

/* This is a demo of main ideas from Chapter 7 (Collections)
 * SHOW ME YOUR DATA, AND I WILL SHOW YOU THE PROGRAM!
 * That is, in programming, there is *no* distinction between data and a program.
 * Programs manipulate "stuff".  For manipulation, we can use data structures (Abstract data types or ADTs).  
 * The principal ADTs are:
 * Lists, Stacks, Queues, LinkedLists, Hash tables, Dictionary, Tuples (chapter 8)
 */

namespace DataStructures {
    class Program {
        static void Main(string[] args) {
            // Example 1: LIST - a list is a collection of objects that are accessed by their index
            var integers = new List<int>() { -2, -1, 0, 1, 2, 3 };
            // Add an element to integers
            integers.Add(4);

            // Problem statement:  Extend C# to accommodate integer (mathematical definition of integers) arithmetic
            Console.WriteLine(sizeof(int) + " bytes"); // sizeof is an operator
            /* What is the range of integer values that can be represented by a 4 byte int?
             
             * Followup "interview" question:  
             * What is the range of integer values that can be represented by a 1 byte int?
             * A byte has 8 bits => Total number of values I can represent using 1 byte (8 bits): 2^8 = 256.
             * IF my int is UNSIGNED: then the range of integer values for a 1 byte int:  0 to 255.
             * IF my int is SIGNED: then the range of integer values for a 1 byte int (2's complement):  -128 to 127.
             
             * Sign magnitude:  where the most significant bit indicates if the number is positive (0) or negative (1)
             * 1's complement:  bit wise complement is defined as the "negative"
             * 2's complement : 1's complement + 1 

             * Example:  {000,001,010,011,100,101,110,111}.  
             * Range of integers:
             * Unsigned:  0 to 7
             * Sign magnitue:  000: 0, 001: 1, 010: 2, 011: 3
             *                 101: -1, 110: -2, 111: -3, 100: -0
             * So, sign magnitude has TWO definitions of 0!  Sign magnitude is however still used in 
             * the IEEE floating point standard             
             * 
             * 1's complement:  000: 0,  001: 1, 010: 2, 011: 3
             *                  111: -0, 110: -1, 101: -2, 100: -3
             *                  
             * 2's complement:  000: 0,  
             *                  001: 1  
             *        110 + 1 = 111: -1,    
             *                  010: 2
             *        101 + 1 = 110: -2,
             *                  011: 3   
             *        100 + 1 = 101: -3,   
             *                 
             *        100 define in 3-bit 2's complement = -4
             *        Note: the +ve equivalent of 100 in 2's complement: 011 + 1 = 100.  The smallest
             *        negative number in 2's complement representation does not have an equivalent positive number!
             *        
             *        In N-bit 2's complement, the RANGE of integers that can be represented:
             *        -2^(N-1) to 2^(N-1)-1.
             *        
             *        For example: if N = 3 bits,
             *        range: -2^(3-1) to 2^(3-1)-1 = -(2^2) to (2^2)-1 = -4 to 3
             *        
             *        For example, if N = 8 bits,
             *        range: -2^(8-1) to 2^(8-1)-1 = -2^7 to (2^7)-1 = -128 to 127
             *        
             *        What is the range of integer values that can be represented by a 4 byte int?
             *        Range: -2^31 to (2^31)-1 (because C# int uses 2's complement)
             */

            Console.WriteLine("sizeof(long int) " + sizeof(long) + " bytes");




        }
    }
}
