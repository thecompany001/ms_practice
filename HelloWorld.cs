using System;

// ALL C# apps include a NAMESPACE, CLASS, and exactly one MAIN METHOD
namespace HelloWorld
{
    class Program
    {
        /*
        // This is a single line comment
        ///This comment is for XML elements and attributes, describing the code block that follows.
        */
        static void Main(string[] args)
        {
            string firstName = "Stef";
            int score = 150;
            double you = 10.0;
            char userOption;
            decimal perMillion = 1;
            bool isPositive;

            Console.WriteLine($"Hello {firstName}!");
            Console.ReadKey();
            Console.WriteLine(firstName);
            Console.WriteLine(score);
            Console.WriteLine(you);
            Console.WriteLine(userOption);
            Console.WriteLine(perMillion);
            Console.WriteLine(isPositive);

            // Min Max values
            int maxInt = int.MaxValue;
            int maxIntPlus = maxInt + 1;
            Console.WriteLine(maxIntPlus);

            // Operators - Assignment and increment/decrement
            int x = 1, y = 2;
            int z1 = x++;
            int z2 = ++y;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z1);
            Console.WriteLine(z2);

            // Math
            int x = 20, y = 40, z = 80;
            int a = x * 2;
            int b = y % 40;
            int c = z + 20;

            xx = x % 2;
            if (xx == 0)
            {
                Console.WriteLine("x is even");
                bool xxx = xxx;
            }
            else
            {
                Console.WriteLine("x is odd");
            }

            yy = y % 3;

            if (yy == 0) ;
            {
                Console.WriteLine("yy is divisible by 3");
                bool yyy = yy;
            }
            else
            {
                Console.WriteLine("yy is not divisible by 3");
            }

            // Type Conversion
            int x = 100, y = 200, z = 300;
            double xx = (double)x;
            double yy = (double)y;
            double zz = (double)z;

            double a = 1.0, b = 2.0, c = 3.0;
            int aa = (int)a;
            int bb = (int)b;
            int cc = (int)c;

            // Strings

            // Escapes and Literals
            string lastName = "Daniels";

            Console.WriteLine($"Mr. {lastName} is one the best\\worst there ever was.\n He does not like to \'go\' back\\forth unless it is \n\t...\t completely \"necessary\".");
            var filePath = @"www.viewthissite.com/no/time/for/that";
            Console.WriteLine(filePath);

            // Concatenation
            string s1 = "This";
            string s2 = "and";
            string s3 = "That";
            string s4 = s1 + " " + s2 " " + s3;

            Console.WriteLine($"{s1} + " " {s2} + " " + {s3}\n\t {s3} + " " + {s2} + " " + {s1});

            // Length
            int length = s4.Length;
            Console.WriteLine(length);

            // Indexing
            string str = "Hello World";
            char c0 = str[0];
            char cMid = str[6];
            char cEnd = str[11];
            char cTogether = str[0] + str[6] + str[-1];
            Console.WriteLine(cTogether);


            // Changing case
            string upperStr = str.ToUpper();
            string lowerStr = str.ToLower();
            Console.WriteLine(upperStr);
            Console.WriteLine(lowerStr);


            // Getting parts of strings
            string sub1 = str.Substring(1);
            string sub2 = str.Substring(11);
            string sub3 = str.Substring(1);
            string remo1 = str.Remove(1);
            string remo2 = str.Remove(11);

            Console.WriteLine(remo1);
            Console.WriteLine(remo2);


            // Searching
            string ab = "Abra";
            char cb = "cadabra";

            int index1 = cb.IndexOf(ab);
            int index2 = ab.IndexOf(cb);

            bool b1 = ab.Contains(cb);
            bool b2 = cb.Contains(ab);

            string litString = @"c:\foo\bar\.txt"
            //STILL NEED 4 from Searching


            // Splitting
            string x = "Don't make me think";
            string[] splitStr1 = x.Split();
            string[] splitStr2 = x.Split('m');

            // Formatting
            

            // Printing and parsing

            // Enums

            // Structs

            // Console i/o

            // Command line arguments

            // VS studio arguments

            // Command line arguments



        }
    }
}