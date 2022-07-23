 using System;
 class DecisionMaking {
   String name, grade;
   float marks;
    
    //If-else
   public string computeGrade() {
     Console.WriteLine("Enter the marks");
     marks = Single.Parse(Console.ReadLine());
     if (Math.Round(marks, 0) >= 95) {
       grade = "A+";
     } else if (Math.Round(marks, 0) >= 90 && Math.Round(marks, 0) <= 94) {
       grade = "A";
     } else {
       grade = "Not A";
     }
     return grade;
   }
   //Switch
   public string displayTitle() {

     switch (employee_level) {
     case 100:
       title = "Sales Associate";
       break;
     case 200:
       title = "Sales Manager";
       break;
     default:
       title = "Not Applicable";
       break;
     }
     return title;
   }
   // switch fall through
   public string displayrank() {
     switch (rank) {
        case 1:
        case 2:
        case 3: Console.WriteLine("Good");
          break;
        case 4: Console.WriteLine("Not good");
          break;
     }
     return title;
   }

    // Goto statement
    float assignment_1;
    Console.WriteLine("Enter the marks for Assignment 1 out of 100:");
        statement1: float assign_1 = Convert.ToInt32(Console.ReadLine());
        if (assign_1 <= 100)
            assignment_1 = assign_1;
        else
        {
            Console.WriteLine("Enter the marks again:");
            goto statement1;
        }

// Ternary Operator ? : 
grade = examScore > 89 ? 'A' : 'C';
    
    // While loop
    int sum = 0;                                                
    int number = 1;                                          
    while (number < 11)                                  
        {                                                                
        sum = sum + number;                             
        number++;                                              
        }                                                                 
    Console.WriteLine("Sum of values " + "1 through 10" + " is " + sum);
    
    // Do ... while
    int counter = 10;
    do                
    {
        WriteLine(counter + "\t" + Math.Pow(counter, 2));
        counter--;
    }
    while (counter > 6);
    
    // For loop
    int n = 100;
    for(int i=0;i<n;i++)
        {
            if (i == 5)
            {
                continue;
            }
            else if (i % 2 == 0) {
                break;
            }
            else {
                Console.WriteLine(i);
            }
        }
    
    // Foreach loop
    int[] a_array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
    foreach(int items in a_array)
        {
            Console.WriteLine(items);
        }
    
   class Item {
     // Default constructor
     public Item() // Compile-time initialization for Name and wholesale price
     {
       name = "Open Collar Running Shirt";
       wholesale_price = 41.00 m;

     }
     // Define getter and setter
     public string getName() {
       return name;
     }
     public void setName(string value) {
       name = value;
     }
     // Auto Implemented Properties
     public string Name {
       get;
       set;
     }

     // Overload default constructor
     public Item(string name) {
       this.name = name;
     }

    // Properties 
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public decimal calculateSaving() {
       decimal markdown_value = wholesale_price - retail_price;
       return markdown_value;
     }
     static void printInfo(Item item) {
       Console.WriteLine("Information for " + item.Name + ":");
     }
     value2 = (double) anotherNumber;
     examAverage = (exam1 + exam2) / (double) count;

    // Named Parameter 
    public static void DoSomething(string name, int age = 21, bool is_student = true) {
       Console.WriteLine(name, age, is_student);
     }

    // Params parameter: the number of arguments to the method may vary
    DisplayItems(params int[] item)
    {
        for (int i = 0; i < item.Length; i++)
        {
            Console.WriteLine(item[i] + "\t");
        }
    }

    public class CSIS1175 {
       private int studentNumber;
       private string studentFirstName;

       public static void Main(string[] args) {

         DoSomething(name: "Robert Wiser", age: 20);

         // Declare new object of a class
         Item newItem = new Item("Razorback T-Shirt");

         float val = Convert.ToSingle("123.45567");
         Convert.ToDouble()
         Convert.ToDecimal()
         Convert.ToInt32()
         Convert.ToBoolean()
         Convert.ToChar()
         Console.Write("Input a: ");
         int a = Int32.Parse(Console.ReadLine());

         // TryParse()
         bool Result; // Biến chứa giá trị kết quả khi ép kiểu thành công
         bool isSuccess; // Biến kiểm tra việc ép kiểu có thành công hay không
         string Data1 = "10";

         isSuccess = int.TryParse(Data1, out Result); // Thử ép kiểu Data1 về int nếu thành công thì Result sẽ chứa giá trị kết quả ép kiểu và isSuccess sẽ mang giá trị true. Ngược lại Result sẽ mang giá trị mặc định của type và isSuccess mang giá trị false
        Console.Write(isSuccess == true ? " Success !" : " Failed !"); // Sử dụng toán tử 3 ngôi để in ra màn hình việc ép kiểu đã thành công hay thất bại.
        
        // REF OUT demo
        static void AreaPerimeter(out double result)
        {
            result = 5;
        }
        static void Renewal(ref int discountPercentage)
            {
                discountPercentage= 7;
            }
        
        public static void Main(string[] args)
        {
            double result;
            int discount=0;
            AreaPerimeter(out result);
            Console.WriteLine($"Result: {result}");
            Renewal(ref discount);
            Console.WriteLine($"Result: {discount}");
        }
            
         Math.Abs(int)
         Math.Ceiling(double) // Round-up to a whole number
         Math.Floor(double) // Round down to a whole number
         Math.Cos(double)
         Math.Sin(double)
         Math.Tan(double)
         Math.Exp(double)
         Math.Log(double, double)
         Math.Max(double, double)
         Min(int, int)
         Math.Pow(double, double)
         Math.Round(double, int)
         Math.Sign(double)
         Math.Sqrt(double)
         Math.PI
         /*
         byte - System.Byte
         abyte - System.SByte
         char - System.Char
         decimal - System.Decimal
         double - System.Double
         float - System.Single
         int - System.Int32
         uint - System.UInt32
         long - System.Int64
         ulong - System.UInt64
         short - System.Int16
         ushort - System.UInt16
         bool
         */

        // Formating
         Console.WriteLine("Value of a is: {0}", a);
         Console.WriteLine(a.GetType());
         Console.WriteLine($"The value of a is: {a}");
         Console.Write("Print money {0:c2} ", a);
         Console.WriteLine("Print percentage {0:P0}", a);
         Console.WriteLine("Print floating number {0:f2}", a);
         string aSaying, fileLocation;
         aSaying = "First day of the rest of your life!\n";
         fileLocation = @ "C:\CSharpProjects\Chapter2";
         const double TAX_RATE = 0.0675;
         decimal amountOwed,
         amountOwed = 3000.50 m;

       }
     }


    // 1-step Array Declaration 
    const int size = 15;
    double[] temperature = new double[size];
    // 2-step Array Declaration 
    int[] score;
    score = new int[size + 15];
    // Array Initializers 
    int[] anArray = { 100, 200, 400, 600 };
    char[] grade = new char[] { 'A', 'B', 'C', 'D', 'F' };
    double[] depth = new double[2] { 2.5, 3 };

    // Array class

    // Searches a one-dimensional sorted array for a value. Returns index location or negative value if not found.
    double[] waterDepth = { 2.4, 3.5, 6.8 };
    double x = 6.8;
    int myIndex = Array.BinarySearch(waterDepth, x);  

    Array.Clear(waterDepth, 0, 2); /* Beginning at index 0, for length of 2. Sets waterDepth[0] and waterDepth[1] to zero. */

    // Clone an array
    double[] w = new double[3];
    object o = waterDepth.Clone();
    w = (double[]) o;

    /* Copies 3 elements from waterDepth to w; Begins copy at index 0 in waterDepth; Begins placement at index 0 in w. */
    double[] w = new double[3];
    Array.Copy(waterDepth, 0, w, 0, 3); 

    /* Copy started at w[2]; w[0] = 0, w[1] = 0, w[2] = 2.4, w[3] = 3.5, w[4] = 6.8 */
    double[] w = new double[5];
    waterDepth.CopyTo(w, 2);
    WriteLine(w[3]); 

    // Get value by index
    double[] waterDepth = { 2.4, 3.5, 6.8 };
    WriteLine(waterDepth.GetValue (2)); //Displays 6.8
    
    int i = Array.IndexOf(waterDepth, 3.5); // Returns the index of the first occurrence of a value. Return -1 if not found
    int i = Array.LastIndexOf(waterDepth, 2.4); // Returns the index of the last occurrence of a value

    Array.Reverse(waterDepth); //Reverses the order of the elements

    Array.Sort(waterDepth); // Sorts Array waterDepth in ascending order

    waterDepth.SetValue(55, 0); // set value of 55 to element at index 0

    void DisplayArrayContents(double[] anArray) // Arrays as Method Parameters

/* Array methods */

class Array_demo
    {
        internal protected String[] sortNames(String[] names)
        {
            Array.Sort(names);
            return names;
        }

        static void Main(string[] args)
        {
            Array_demo demo = new Array_demo();
            // Declare a new object of Array
            String[] names = new String[3];
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Enter the name: ");
                names[i] = Console.ReadLine();
            }
            demo.sortNames(names);
            Console.WriteLine("The sorted list of names is: ");
            foreach (String name in names)
            {

                Console.WriteLine(name);
            }

            int x;
            x = Array.BinarySearch(names, "Khanh");
            Console.WriteLine(x);
            if (x >= 0)
            {
                Console.WriteLine($"Hello, {names[x]} is a student of the class");
            }

        }
    }


     
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Make a class and create a set of 
instances of that class instead. The class should store
first and last names. Use those properties when
printing out the message on the console.*/
namespace ConsoleApp1
{
    class DemoList
    {

        String firstname, lastname;


        DemoList(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public string Firstname { get { return firstname; } set { firstname = value; } }
        public string Lastname { get { return lastname; } set { lastname = value; } }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int n=Int32.Parse(Console.ReadLine());
            DemoList[] list = new DemoList[n];
            for(int i=0;i< list.Length; i++)
            {
                Console.WriteLine("Enter the First Name");
                String firstname = Console.ReadLine();
                Console.WriteLine("Enter the Last Name");
                String lastname = Console.ReadLine();
                // Declare a new object of Array
                list[i] = new DemoList(firstname, lastname);
            }
            

            foreach(DemoList item in list)
            {
                if (item.Firstname == "Jenifer" && item.Lastname == "Lopez")
                {
                    item.Lastname = "Lynn Lopez";
                    Console.WriteLine($"Hello my name is {item.Firstname} {item.Lastname} ");
                    
                } else {
                    Console.WriteLine($"Hello my name is {item.Firstname} {item.Lastname} ");
                }
                
            }
        }
    }
}

/* Array as an input */
class FriendsDemo
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private string gender;
    public string Gender
    {
        get { return gender; }
        set { gender = value; }
    }
    private string location;
    public string Location
    {
        get { return location; }
        set { location = value; }
    }

    public void display(FriendsDemo[] f)
    {
        foreach (FriendsDemo item in f)
        {
            string pronoun = item.Gender.ToLower().Equals("male") ? "him" : "her";
            Console.WriteLine($"{item.Name} is one of my best friends. I met {pronoun} in my {item.Location} ");
        }

    }
    public FriendsDemo()
    {
        name = "Bob";
        gender = "male";
        location = "kindergarten";
    }
    public FriendsDemo(string name, string gender, string location)
    {
        this.name = name;
        this.gender = gender;
        this.location = location;
    }

    static void Main(string[] args)
    {
        FriendsDemo[] f = { new FriendsDemo("Khanh", "male", "Vietnam"), new FriendsDemo() };
        new FriendsDemo().display(f);


    }
}




/* Two dimensional array */
class TwoDimensionalArrayDemo
{

    static void Main(string[] args)
    {
        int[,] rentinMyBuiding = {
                { 900, 950, 1000},
                { 950, 1000, 1050},
                { 1000, 1050, 1100},
                { 1050, 1100, 1150}
            };
        Console.WriteLine($"The building has {rentinMyBuiding.GetLength(0)} floors" +
            $" and the maximum number of bedrooms is {rentinMyBuiding.GetLength(1)}"
            );
        Console.WriteLine("Enter the floor: ");
        int floor = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of bedrooms: ");
        int bedroom = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"The rent is {rentinMyBuiding[floor, bedroom]}");

        int[,,] rentinMultipleBulding = {
                { {900, 950, 1000}, {950, 1000, 1050}, {1000, 1050, 1100}, { 1050, 1100, 1150} }
               ,{ {901, 951, 1000}, {850, 1000, 1050}, {1004, 1430, 1143}, { 1430, 1400, 1130} }
               ,{ {943, 952, 1040}, {950, 1300, 1043}, {1003, 1030, 1132}, { 1030, 1130, 1350} }
            };

        // Get size of array
        // For 2 - dimensional array
    
        rentinMultipleBulding.Rank // returns number of dimensions, for 2-dimensional array, it returns 2
        rentinMultipleBulding.GetLength(0) //  returns number of rows
        rentinMultipleBulding.GetLength(1) //  returns number of columns
        rentinMultipleBulding.GetUpperBound(0) //  returns max row index

        // For 3 - dimensional array
        rentinMultipleBulding.Rank // returns number of dimensions, for 3-dimensional array, it returns 3
        rentinMultipleBulding.GetLength(0) //  returns depth
        rentinMultipleBulding.GetLength(1) //  returns number of rows
        rentinMultipleBulding.GetLength(2) //  returns number of columns

        Console.WriteLine($"There are {rentinMultipleBulding.GetLength(0)} buildings, each has {rentinMultipleBulding.GetLength(1)} floors" +
            $" and the maximum number of bedrooms is {rentinMultipleBulding.GetLength(2)}");
        Console.WriteLine("Enter the building");
        int building = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the floor: ");
        int floor_1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of bedrooms: ");
        int bedroom_1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"The rent at {building} on {floor_1} and for {bedroom_1} is {rentinMultipleBulding[building, floor_1, bedroom_1]}");

    }
}
}

/*
 * Write a program using multi-dimensioanl array for calculating the steps taken per day during 
 * morning, afternoon, and evening and write a method to display the average steps per day.
 * Record the data for a week. 
 * Modify your program to include a method that calculate the average steps for morning,
 * afternoon and evening. 
 */

namespace CSIS1175Projects
{

    class MultiDimensionalArrayPractice
    {
        int[,] stepCounter = new int[7, 3];
        double[] averageStepbyDay = new double[7];
        double[] averageStepByTimeofDay = new double[3];

        static string getTime(int n)
        {
            string time;
            if (n == 0)
            {
                time = "morning";
            }
            else if (n == 1)
            {
                time = "afternoon";
            }
            else
            {
                time = "everning";
            }
            return time;
        }

        public void getData()
        {
            for (int i = 0; i < stepCounter.GetLength(0); i++)
            {
                for (int j = 0; j < stepCounter.GetLength(1); j++)
                {
                    string time = getTime(j);

                    Console.WriteLine($"Enter the number of {time} steps for day {i}: ");
                    stepCounter[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
        }

        public void displayData()
        {
            Console.WriteLine("The statistics of steps: ");
            for (int i = 0; i < stepCounter.GetLength(0); i++)
            {
                for (int j = 0; j < stepCounter.GetLength(1); j++)
                {
                    Console.Write($"{stepCounter[i, j]} ");
                    if (j == stepCounter.GetLength(1) - 1)
                    {
                        Console.WriteLine("\n");
                    }
                }
            }
        }

        public double[] calculateAvgDay()
        {
            for (int i = 0; i < stepCounter.GetLength(0); i++)
            {
                double sum_steps = 0;
                for (int j = 0; j < stepCounter.GetLength(1); j++)
                {
                    sum_steps += stepCounter[i, j];
                }
                double avg_steps = sum_steps / stepCounter.GetLength(1);
                averageStepbyDay[i] = avg_steps;
                sum_steps = 0;
            }
            return averageStepbyDay;
        }

        public double[] calculateAvgTime()
        {
            for (int j = 0; j < stepCounter.GetLength(1); j++)
            {
                double sum_steps = 0;
                for (int i = 0; i < stepCounter.GetLength(0); i++)
                {
                    sum_steps += stepCounter[i, j];
                }
                double avg_steps = sum_steps / stepCounter.GetLength(0);
                averageStepByTimeofDay[j] = avg_steps;
                sum_steps = 0;
            }
            return averageStepByTimeofDay;
        }

        static void Main(string[] args)
        {
            MultiDimensionalArrayPractice sc = new MultiDimensionalArrayPractice();
            sc.getData();
            sc.displayData();
            double[] averageStepbyDay = sc.calculateAvgDay();
            double[] averageStepByTimeofDay = sc.calculateAvgTime();
            for (int i = 0; i < averageStepbyDay.Length; i++)
            {
                Console.WriteLine($"The average step of day {i + 1} is: {averageStepbyDay[i]} ");
            }

            for (int j = 0; j < averageStepByTimeofDay.Length; j++)
            {
                Console.WriteLine($"The average step of {getTime(j)} is: {averageStepByTimeofDay[j]} ");
            }

        }
    }
}

/* Write a program to calculate the average marks of m students in n subjects. */
using System;
namespace Test
{
    public class StudentMark
    {
        private int n_student;
        public int N_student
        {
            get { return n_student; }
            set { n_student = value; }
        }

        private int n_subject;
        public int N_subject
        {
            get { return n_subject; }
            set { n_subject = value; }
        }
        private double[,] arrayMarks;
        private double[] arrayAvgMarkStudent;
        private double[] arrayAvgMarkSubject;

        public StudentMark(int n_student, int n_subject)
        {
            arrayMarks = new double[n_student, n_subject];
            arrayAvgMarkStudent = new double[n_student];
            arrayAvgMarkSubject = new double[n_subject];
        }

        public void getData()
        {
            for (int i = 0; i < arrayMarks.GetLength(0); i++)
            {
                for (int j = 0; j < arrayMarks.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter the mark of student {i + 1} in subject {j + 1}: ");
                    arrayMarks[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
        }

        public void displayData()
        {
            Console.WriteLine("The marks are as follows: ");
            for (int i = 0; i < arrayMarks.GetLength(0); i++)
            {
                for (int j = 0; j < arrayMarks.GetLength(1); j++)
                {
                    Console.Write($"{arrayMarks[i, j]} ");
                    if (j == arrayMarks.GetLength(1) - 1)
                    {
                        Console.Write("\n");
                    }
                }
            }
        }

        public void calculateAvgStudent()
        {
            for (int i = 0; i < arrayMarks.GetLength(0); i++)
            {
                double sum = 0;
                for (int j = 0; j < arrayMarks.GetLength(1); j++)
                {
                    sum += arrayMarks[i, j];
                }
                arrayAvgMarkStudent[i] = (double)sum / arrayMarks.GetLength(1);
                sum = 0;
            }
        }

        public void calculateAvgSubject()
        {
            for (int j = 0; j < arrayMarks.GetLength(1); j++)
            {
                double sum = 0;
                for (int i = 0; i < arrayMarks.GetLength(0); i++)
                {
                    sum += arrayMarks[i, j];
                }
                arrayAvgMarkSubject[j] = (double)sum / arrayMarks.GetLength(0);
                sum = 0;
            }
        }

        public void displayAvgMark()
        {
            for (int i = 0; i < arrayAvgMarkStudent.Length; i++)
            {
                Console.WriteLine("The average mark of student {0} is {1:f2}", i + 1, arrayAvgMarkStudent[i]);
            }
            for (int j = 0; j < arrayAvgMarkSubject.Length; j++)
            {
                Console.WriteLine("The average mark of subject {0} is {1:f2}", j + 1, arrayAvgMarkSubject[j]);
            }
        }

        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of students: ");
            int n_student = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of subjects: ");
            int n_subject = Int32.Parse(Console.ReadLine());
            StudentMark sm = new StudentMark(n_student, n_subject);
            sm.getData();
            sm.displayData();
            sm.calculateAvgStudent();
            sm.calculateAvgSubject();
            sm.displayAvgMark();

        }
    }
}


/* ArrayList and methods */
using System.Collections;
class ArrayListDemo
{

    void addNames()
    {
        String[] previousEntries = { "Harry", "Larry" };
        ArrayList names = new ArrayList();
        Console.WriteLine("Tentative list of the invitees");
        names.Add("Jasmeet Singh"); // Adds a value onto the end
        names.AddRange(previousEntries);
        names.BinarySearch("Mr Douglas"); // find the index of an element in a SORTED array
        names.Capacity // gets or sets number of elements that the ArrayList can contain
        names.Clear() // Removes all elements
        names.Contains("Mr Douglas") // Determines whether elemernt is in the ArrayList
        names.Count // gets or sets the number of elements that the ArrayList actually contains
        names.GetRange(1, 3) // Returns an ArrayList that is a subset of another ArrayList, from index 1 and length 3
        names.IndexOf("Larry"); // returns the index of the first occurrence of a value
        names.Insert(1, "David"); // Inserts an element at a specified index
        names.InsertRange(2, s); // Inserts the elements of arrayList s into another names at index 2
        names.LastIndexOf("Larry") // returns the index of the last occurrence of a value
        names.Remove("Larry") // Removes the first occurrence of a specified object
        names.RemoveAt(5) // Removes the element at index 5
        names.RemoveRange(4,3) // Removes three elements starting at index 4.
        myAL = ArrayList.Repeat("abc", 7); // Creates a new ArrayList with 7 elements and initialize each element with the string "abc".
        names.Reverse() // reverses the order of the elements
        names.Sort() // sorts the elements or a portion of them (.Sort(0, 4, null) to sort the value of ArrayList from 0 to 4)
        /* Copy the elements of an arrayList to a new array */
        string[] arr = names.ToArray(typeof(string)) as string[]; // OR below
        string[] str = (string[])names.ToArray(typeof(string)); // OR below
        String[] strings = new string[names.Count];
        for (int i = 0; i < strings.Length; i++)
        {
            strings[i] = names[i].ToString();
            Console.WriteLine(strings[i]);
        }

        names.TrimToSize() // Sets the capacity to the actual number of elements

        if (names.Contains("Mr Douglas"))
        {
            Console.WriteLine("Mr Douglas is already invited");
        }

        for (int i = 0; i < names.Count; i++)
        {
            Console.WriteLine(names[i]);
        }

        
    }
    public static void Main()
    {
        ArrayListDemo arrayListDemo = new ArrayListDemo();
        arrayListDemo.addNames();

    }
}

/* Jagged Array */
class JaggedArray
{
    public int[][] fares = new int[5][];

    public void CreateArrays()
    {
        fares[0] = new int[5];
        fares[1] = new int[10];
        fares[2] = new int[3];
        fares[3] = new int[4];
        fares[4] = new int[5];
    }
    public void GetData()
    {
        int i, j;
        for (i = 0; i < 5; i++)
        {
            for (j = 0; j < fares[i].Length; j++)
            {
                Console.WriteLine($"Enter the fare for {i}:{j}");
                fares[i][j] = Int32.Parse(Console.ReadLine());
            }
        }
    }

}