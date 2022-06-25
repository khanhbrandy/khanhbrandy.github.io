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
     public string Name {
       get {
         return name;
       }
       set {
         name = value;
       }
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

     public static void DoSomething(string name, int age = 21, bool is_student = true) {
       Console.WriteLine(name, age, is_student);
     }
    
    // 1-step Array Declaration 
    const int size = 15;
    double [ ] temperature = new double [size];
    // 2-step Array Declaration 
    int [ ] score;
    score = new int [size + 15];
    // Array Initializers 
    int [ ] anArray = {100, 200, 400, 600};
    char [ ] grade = new char[ ] {'A', 'B', 'C', 'D', 'F'}; 
    double [ ] depth = new double [2] {2.5, 3}; 

    // Array class
    double [ ] waterDepth = {2.4, 3.5, 6.8};
    double x = 6.8;
    int myIndex = Array.BinarySearch(waterDepth, x);
    
    Array.Clear(waterDepth, 0, 2);
    
    double [ ] w = new double [3];
    object o = waterDepth.Clone( );
    w = (double [ ]) o; /* Beginning at index 0, for length of 2. Sets waterDepth[0] and waterDepth[1] to zero. */
    
    double [ ] w = new double [3];
    Array.Copy(waterDepth, 0, w, 0, 3); /* Copies 3 elements from waterDepth to w; Begins copy at index 0 in waterDepth; Begins placement at index 0 in w. */

    double [ ] w = new double [5];
    waterDepth.CopyTo(w, 2);
    WriteLine(w[3]); /* Copy started at w[2]; w[0] = 0, w[1] = 0, w[2] = 2.4, w[3] = 3.5, w[4] = 6.8 */
    
    double [ ] waterDepth = {2.4, 3.5, 6.8};
    WriteLine(waterDepth.GetValue (2)); //Displays 6.8
    
    int i = Array.IndexOf(waterDepth, 3.5); // Returns the index of the first occurrence of a value. Return -1 if not found
    int i = Array.LastIndexOf(waterDepth, 2.4); // Returns the index of the last occurrence of a value
    
    Array.Reverse(waterDepth);
    
    Array.Sort(waterDepth);

    waterDepth.SetValue(55, 0); // set value of 55 to element at index 0

    void DisplayArrayContents (double [ ] anArray) // Arrays as Method Parameters








    
     public class CSIS1175 {
       private int studentNumber;
       private string studentFirstName;

       public static void Main(string[] args) {

         DoSomething(name: "Robert Wiser", age: 20);

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

         isSuccess = int.TryParse(Data1, out Result); // Thử ép kiểu Data1 về int nếu thành công thì Result sẽ chứa giá trị kết quả ép kiểu và isSuccess sẽ mang giá trị true. Ngược lại Result sẽ mang giá trị mặc định của type và isSuccess mang giá trị fals
        Console.Write(isSuccess == true ? " Success !" : " Failed !"); // Sử dụng toán tử 3 ngôi để in ra màn hình việc ép kiểu đã thành công hay thất bại.
        
        // REF OUT demo
        double AreaPerimeter(out double result)
        {
            result = 0;
        }
        static void Renewal(ref int discountPercentage)
        {
            discountPercentage= 0.1m;
        }
        double result;
        int discount=0;
        Console.WriteLine(new OUTREFDEMO().AreaPerimeter(out result));
        Renewal(ref discount);
            
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
     
     
     using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* make a class and create a set of 
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
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter the First Name");
                String firstname = Console.ReadLine();
                Console.WriteLine("Enter the Last Name");
                String lastname = Console.ReadLine();
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

