//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace practice
//{
//    class palindrome
//    {
//        string _inputString = "";

//        Console.WriteLine("Please enter word");
//            _inputString = Console.ReadLine();

//            string reverseWord = "";
//        //for (int i = _inputString.Length - 1; i >= 0; i--)
//        //{
//        //    reverseWord += _inputString[i];
//        //}


//        //if (reverseWord == _inputString)
//        //{
//        //    Console.WriteLine("This is a palindrome");
//        //}
//        //else
//        //{
//        //    Console.WriteLine("This is not a palindrome");
//        //}
//        //Console.ReadLine();
//        string newString = "";
//        char[] _array = _inputString.ToCharArray();
//        _array = _array.Reverse().ToArray();

//            foreach (char x  in _array)
//            {
//                newString += x;
//            }
            

//            if (_inputString == newString)
//            {
//                Console.WriteLine("This is a palindrome");
//                Console.WriteLine(newString);
//                Console.WriteLine(_inputString);
//            }
//            else
//            {
//                Console.WriteLine("This is not a palindrome");
//                Console.WriteLine(newString);
//                Console.WriteLine(_inputString);
//            }
//            Console.ReadLine();
    
//    }
//}
