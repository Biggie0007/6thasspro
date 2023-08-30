using System.Globalization;
using System.Net.Security;

internal class Program
{


    public class student
    {
      
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int schoolfees { get; set; }
        public int level { get; set; }

        private static void Main(string[] args)
        {
            List<student> studentmode = new List<student>();
            studentmode.Add(new student() { id = 20001, name = "VICTOR", age = 28, schoolfees = 70000, level = 300 });
            studentmode.Add(new student() { id = 20002, name = "VICTORIA", age = 30, schoolfees = 90000, level = 400 });
            studentmode.Add(new student() { id = 20003, name = "JAMES", age = 27, schoolfees = 80000, level = 100 });
            studentmode.Add(new student() { id = 20004, name = "FAVOUR", age = 22, schoolfees = 40000, level = 600 });
            studentmode.Add(new student() { id = 20005, name = "FAITH", age = 25, schoolfees = 60000, level = 500 });
            studentmode.Add(new student() { id = 20006, name = "TAIWO", age = 26, schoolfees = 30000, level = 400 });
            studentmode.Add(new student() { id = 20007, name = "KEHINDE", age = 21, schoolfees = 10000, level = 300 });
            studentmode.Add(new student() { id = 20008, name = "DEBORAH", age = 19, schoolfees = 100000, level = 200 });
            studentmode.Add(new student() { id = 20009, name = "VICTORY", age = 23, schoolfees = 9800, level = 700 });
            studentmode.Add(new student() { id = 200010, name = "JAIME", age = 22, schoolfees = 3500, level = 400 });


           

            var youngeststudent = from young in studentmode where young.age < 27 select young;
            var lowschfee = studentmode.Where(lowschfee => lowschfee.schoolfees < 10000);
            
            foreach ( var Student in youngeststudent.ToList())
            {
                Console.WriteLine("Name:" + Student.name + "\tYoung student Age:" + Student.age);
            }

            Console.WriteLine("-------------------------------------------------------------------------");
            
            foreach (var lowfee in lowschfee.ToList())
            {
                Console.WriteLine("Name:" + lowfee.name + "\tlow school fees:"+ lowfee.schoolfees);
            }











          //  var result = studentmode.Select(A => new { id = A.id, name = A.name, age = A.age, schoolfees = A.schoolfees, level = A.level }).ToList();
          //  foreach (var value in result)
          //  {
          //      Console.WriteLine(value.name);
               
          //  }
          //   Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxx");
          //  var o = studentmode.Sum(x => x.schoolfees);
          //  Console.WriteLine(o);

          //  Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxx");

          //foreach(student value in studentmode.SkipWhile(d => d.level > 200))
          //{ 
          //      Console.WriteLine( value.name+ "-------------"  + value.level);
          //}

          //  Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxx");
          //  foreach (student schoolfee in studentmode)
          //  {
                
          //      {
          //          Console.WriteLine(schoolfee.name+ "-------------" + schoolfee.schoolfees); 
          //      }
          //  }


          //  Console.ReadKey();
        }
    }

   



} 
  