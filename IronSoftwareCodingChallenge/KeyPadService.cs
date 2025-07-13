using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronSoftwareCodingChallenge
{
    /// <summary>
    /// This class is for use to phone keypad functions
    /// </summary>
    public static class KeyPadService
    {
        /// <summary>
        /// letter map for old phone keypad and O is space
        /// </summary>
        private static readonly Dictionary<char, string> _keyMap = new Dictionary<char, string>
        {
            { '1', "&'(" },
            { '2', "ABC" },
            { '3', "DEF" },
            { '4', "GHI" },
            { '5', "JKL" },
            { '6', "MNO" },
            { '7', "PQRS" },
            { '8', "TUV" },
            { '9', "WXYZ" },
            { '0', " " }
        };

        /// <summary>
        /// Extract text from input
        /// </summary>
        /// <param name="input">get input text</param>
        /// <returns></returns>
        public static String OldPhonePad(string input)
        {
            var result = string.Empty;
            // Console.WriteLine(input);

            //check input is empty
            if (String.IsNullOrEmpty(input))
            {
                //Console.WriteLine("Input is empty");
                return "Input is empty";
            }

            //check input has end or not
            if (!input.EndsWith("#"))
            {
                //Console.WriteLine("Input not completed");
                return "Input not completed";
            }           
            

            var _sendingInput = input.Replace("#","");

            //Console.WriteLine(_sendingInput);

            var textNumber = string.Empty;
            if (_sendingInput.Contains("*"))
            {
                textNumber = Backspace(_sendingInput);
            }
            else
            {
                textNumber = _sendingInput;
            }
            var word = FindLetter(textNumber);
            result = word;

            return result;

        }

        /// <summary>
        /// Find letter from input string using keypad
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static string FindLetter(string input)
        {
            var result = new StringBuilder();
            var groups = GetConsecutiveNumberList(input);

            foreach (var group in groups)
            {
                if(group.Count > 0)
                {
                    var number = group.FirstOrDefault();
                    if (string.IsNullOrWhiteSpace(number))
                    {
                        continue;
                    }
                    var letters = _keyMap[number[0]];
                    int index = (group.Count - 1) % letters.Length;

                    result.Append(letters[index]);
                }
            }
            

            return result.ToString();
        }

        /// <summary>
        /// Get consecutive number list from input string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static List<List<string>> GetConsecutiveNumberList(string input)
        {
            var result = new List<List<string>>();
            var currentList = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (currentList.Count == 0 || input[i].ToString() == currentList.Last())
                {
                    currentList.Add(input[i].ToString());
                }
                else
                {
                    if (currentList.Count > 0)
                    {
                        result.Add(new List<string>(currentList));
                    }

                    currentList.Clear();
                    currentList.Add(input[i].ToString());
                }

                
            }

            result.Add(new List<string>(currentList));

            return result;
        }

        /// <summary>
        /// the * from input string and remove previes one
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static string Backspace(string input)
        {
            var result = new Stack<char>();

            foreach (char c in input)
            {
                if (c == '*')
                {
                    if (result.Count > 0)
                    {
                        result.Pop(); 
                    }
                }
                else
                {
                    result.Push(c);
                }
            }

            return new string(result.Reverse().ToArray());
        }
    }
}
