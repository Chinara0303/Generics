
using Generics;
using Generics.Models;
//implicit explicit method

//Manat manat = new(340);
//Dollar dollar = manat;
//Console.WriteLine(dollar.Usd);


//list generic

StringList stringList= new StringList();
stringList.Add("Chinara");
stringList.Add("Konul");
stringList.Add("Roya");

//stringList.GetAll();

DataList<string> list1 = new DataList<string>();
list1.Add("Chinara");
list1.Add("Roya");
list1.Add("Konul");

//list1.GetAll();


IntList intList = new IntList();
intList.Add(1);
intList.Add(2);
intList.Add(3);

//intList.GetAll();

DataList<int> list2 = new DataList<int>();
list2.Add(1);
list2.Add(2);
list2.Add(3);

//list2.GetAll();


StudentList studentList = new StudentList();
studentList.Add(new Student { Surname = "Ibadova", Name = "Chinara" });
studentList.Add(new Student { Surname = "Ibadova", Name = "Nermin" });
studentList.Add(new Student { Surname = "Ibadova", Name = "Gullu" });

//studentList.GetAll();

DataList<Student> list3 = new DataList<Student>();
list3.Add(new Student { Surname = "Ibadova", Name = "Chinara" });
list3.Add(new Student { Surname = "Ibadova", Name = "Nermin" });
list3.Add(new Student { Surname = "Ibadova", Name = "Gullu" });

//list3.GetAll();



//List<int> ints= new List<int>();
//ints.Add(10);
//ints.Add(20);
//ints.Add(30);
//ints.Add(40);
//ints.Add(50);

//for (int i = 0; i < ints.Count; i++)
//{
//	for (int j = 1; j < ints.Count-1; j++)
//	{
//		if (ints[i] > ints[j])
//		{
//			Console.WriteLine($"Boyukdur {ints[i]} {ints[j]}");
//			break;
//		}
//	}
//}

//Repository<Student> repository = new Repository<Student>();
////Repository<int> repository1 = new Repository<int>();
//Repository<string> repository2 = new Repository<string>();
//Repository<Test1,Test2> repository = new Repository<Test1,Test2>();


