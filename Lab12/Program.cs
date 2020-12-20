using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace OOP_lab12
{
    class Program
    {
        #region student

        public interface IsomeInterface1 { };
        public interface IsomeInterface2 { };

        public partial class Student : IsomeInterface1, IsomeInterface2
        {

            public static int totalCountOfStudents = 0;
            public readonly int id;
            private string fullName;
            private DateTime birthday;
            private string telephone;
            private string faculty;
            private int kours;
            private int group;
            public const string university = "BSTU";

            public string FullName
            {
                get { return this.fullName; }
                private set { this.fullName = value; }
            }
            public DateTime Birthday
            {
                get { return this.birthday; }
                private set { this.birthday = value; }
            }

            public string Telephone
            {
                get { return this.telephone; }
                set { this.telephone = value; }
            }

            public string Faculty
            {
                get { return this.faculty; }
                set { this.faculty = value; }
            }

            public int Kours
            {
                get { return this.kours; }
                set { this.kours = value; }
            }

            public int Group
            {
                get { return this.group; }
                set { this.group = value; }
            }
        }

        public partial class Student
        {
            public Student()
            {
                this.id = Student.totalCountOfStudents++;
                this.fullName = "";
                this.birthday = DateTime.MinValue;
                this.telephone = "";
                this.faculty = "";
                this.kours = 0;
                this.group = 0;
            }
            /*private*/
            public Student(string fullName, string faculty, int kours, int group, DateTime date, string telephone)
            {
                this.id = Student.totalCountOfStudents++;
                this.fullName = fullName;
                this.birthday = date;
                this.telephone = telephone;
                this.faculty = faculty;
                this.kours = kours;
                this.group = group;
            }
            static Student() { Console.WriteLine("Вызвался статический конструктор"); }
            ~Student()
            {
                Student.totalCountOfStudents--;
            }
            public int Sum(int a, int b) { return a + b; }
            public int getAge() { return (DateTime.Now.Year - this.birthday.Year); }
            public override bool Equals(object obj)
            {
                Student temp = obj as Student;
                if (temp == null)
                    return false;
                return (temp.birthday == this.birthday && temp.faculty == this.faculty && temp.fullName == this.fullName && temp.group == this.group && temp.kours == this.kours && temp.telephone == this.telephone);
            }
            public override int GetHashCode()
            {
                Console.WriteLine("Вызвался переопределенный метод GetHashCode");
                return base.GetHashCode();
            }
            public override string ToString()
            {
                return ($"Студент: {this.id}, Университет: {Student.university}, ФИО: {this.fullName}, Факультет: {this.faculty}, Курс: {this.kours}, Группа: {this.group}, Телефон: {this.telephone}");
            }

            public static void sortingByFaculty(Student[] arr, string facultyName)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Faculty.Equals(facultyName))
                    {
                        Console.WriteLine($"Студент: {arr[i].id}");
                        Console.WriteLine($"ФИО: {arr[i].FullName}");
                        Console.WriteLine($"Факультет: { arr[i].Faculty}");
                        Console.WriteLine($"Курс: { arr[i].Kours}");
                        Console.WriteLine($"Группа: { arr[i].Group}");
                    }
                }
            }

            public static void sortingByGroup(Student[] arr, string facultyName, int groupNum)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Group == groupNum && arr[i].Faculty.Equals(facultyName))
                    {
                        Console.WriteLine($"Студент: {arr[i].id}");
                        Console.WriteLine($"ФИО: {arr[i].FullName}");
                        Console.WriteLine($"Факультет: { arr[i].Faculty}");
                        Console.WriteLine($"Курс: { arr[i].Kours}");
                        Console.WriteLine($"Группа: { arr[i].Group}");
                    }
                }
            }

        }
        #endregion

        static void Main(string[] args)
        {
            Reflector.all_ClassComponents_toFile("OOP_lab12.Program+Student");
            Console.WriteLine("All components of the class 'OOP_lab12.Program+Student' were written to file.\n");

            Reflector.public_ClassComponents_toFile("OOP_lab12.Program+Student");
            Console.WriteLine("Public components of the class 'OOP_lab12.Program+Student' were written to file.\n");

            Reflector.fieldsANDproperties_ClassComponents_toFile("OOP_lab12.Program+Student");
            Console.WriteLine("Fields and properties of the class 'OOP_lab12.Program+Student' were written to file.\n");

            Reflector.interfeices_ClassComponents_toFile("OOP_lab12.Program+Student");
            Console.WriteLine("Interfeices of the class 'OOP_lab12.Program+Student' were written to file.\n");

            Reflector.methodsWITHparams_ClassComponents_toFile("OOP_lab12.Program+Student", "String");
            Console.WriteLine("Methods which includes param with type 'String' of the class 'OOP_lab12.Program+Student' were written to file.\n");

            Reflector.lateBinding("OOP_lab12.Program+Student");
        }

        public class Reflector
        {
            public static void all_ClassComponents_toFile(string className)
            {
                Type classType = Type.GetType(className, true, true);
                using (StreamWriter file = new StreamWriter(@"C:\Workplace\1University\second_cource\OOTP\Csharp_3sem\Lab12\files\all_classComponents.txt"))
                {
                    file.WriteLine($"Info about class {className}");
                    file.WriteLine($"Properties count: {classType.GetProperties().Length}");
                    file.WriteLine($"Methods count: {classType.GetMethods().Length}");
                    file.WriteLine($"Constructors count: {classType.GetConstructors().Length}");
                    file.WriteLine($"Fields count: {classType.GetFields().Length}");
                    file.WriteLine($"");
                    foreach (MemberInfo item in classType.GetMembers())
                        file.WriteLine($"Type: {item.MemberType}\t Name: {item.Name}");
                }
            }

            public static void public_ClassComponents_toFile(string className)
            {
                Type classType = Type.GetType(className, true, true);
                using (StreamWriter file = new StreamWriter(@"C:\Workplace\1University\second_cource\OOTP\Csharp_3sem\Lab12\files\public_classComponents.txt"))
                {
                    file.WriteLine($"Info about class {className}");
                    file.WriteLine($"Public properties count: {classType.GetProperties(BindingFlags.Public | BindingFlags.Instance).Length}");
                    file.WriteLine($"Public methods count: {classType.GetMethods(BindingFlags.Public | BindingFlags.Instance).Length}");
                    file.WriteLine($"Public constructors count: {classType.GetConstructors(BindingFlags.Public | BindingFlags.Instance).Length}");
                    file.WriteLine($"Public fields count: {classType.GetFields(BindingFlags.Public | BindingFlags.Instance).Length}");
                    file.WriteLine($"");
                    foreach (MemberInfo item in classType.GetMembers(BindingFlags.Public | BindingFlags.Instance))
                        file.WriteLine($"Type: {item.MemberType}\t Name: {item.Name}");
                }
            }

            public static void fieldsANDproperties_ClassComponents_toFile(string className)
            {
                Type classType = Type.GetType(className, true, true);
                using (StreamWriter file = new StreamWriter(@"C:\Workplace\1University\second_cource\OOTP\Csharp_3sem\Lab12\files\fieldsANDproperties_classComponents.txt"))
                {
                    file.WriteLine($"Info about class {className}");
                    file.WriteLine($"Properties count: {classType.GetProperties().Length}");
                    file.WriteLine($"Fields count: {classType.GetFields().Length}");
                    file.WriteLine("\nFields:");
                    foreach (MemberInfo item in classType.GetFields())
                        file.WriteLine($"Type: {item.MemberType}\t Name: {item.Name}");

                    file.WriteLine("\nProperties:");
                    foreach (MemberInfo item in classType.GetProperties())
                        file.WriteLine($"Type: {item.MemberType}\t Name: {item.Name}");

                }
            }

            public static void interfeices_ClassComponents_toFile(string className)
            {
                Type classType = Type.GetType(className, true, true);
                using (StreamWriter file = new StreamWriter(@"C:\Workplace\1University\second_cource\OOTP\Csharp_3sem\Lab12\files\interfeices_classComponents.txt"))
                {
                    file.WriteLine($"Info about class {className}");
                    file.WriteLine($"Interfeices count: {classType.GetInterfaces().Length}");
                    foreach (MemberInfo item in classType.GetInterfaces())
                        file.WriteLine($"Type: {item.MemberType}\t Name: {item.Name}");
                }
            }

            public static void methodsWITHparams_ClassComponents_toFile(string className, string paramType)
            {
                Type classType = Type.GetType(className, true, true);
                using (StreamWriter file = new StreamWriter(@"C:\Workplace\1University\second_cource\OOTP\Csharp_3sem\Lab12\files\methodsWITHparams_classComponents.txt"))
                {
                    file.WriteLine($"Info about class {className}");
                    int count = 0;
                    foreach (MethodInfo method in classType.GetMethods())
                        foreach (ParameterInfo p in method.GetParameters())
                            if (paramType.Equals(p.ParameterType.Name))
                                count++;

                    file.WriteLine($"Count of methods which includes param with type {paramType}: {count}");

                    if (count != 0)
                    {
                        file.WriteLine($"");
                        foreach (MethodInfo method in classType.GetMethods())
                        {
                            string modificator = "";
                            if (method.IsPrivate)
                                modificator += "private ";
                            if (method.IsAbstract)
                                modificator += "abstract ";
                            if (method.IsPublic)
                                modificator += "public ";
                            if (method.IsStatic)
                                modificator += "static ";
                            if (method.IsVirtual)
                                modificator += "virtual ";

                            bool isConsiste = false;
                            foreach (ParameterInfo param in method.GetParameters())
                            {
                                if (paramType.Equals(param.ParameterType.Name))
                                {
                                    isConsiste = true;
                                    break;
                                }
                            }

                            if (isConsiste)
                            {
                                file.Write($"{modificator} {method.ReturnType.Name} {method.Name} (");

                                ParameterInfo[] parameters = method.GetParameters();
                                for (int i = 0; i < parameters.Length; i++)
                                {
                                    file.Write($"{parameters[i].ParameterType.Name} {parameters[i].Name}");
                                    if (i + 1 < parameters.Length) file.Write(", ");
                                }
                                file.WriteLine(")");
                                isConsiste = false;
                            }
                        }
                    }
                }
            }

            public static void lateBinding(string className, string methodName = "Sum")
            {
                Type classType = Type.GetType(className, false, true);
                object obj = Activator.CreateInstance(classType);
                MethodInfo methodInfo = classType.GetMethod(methodName);
                StreamReader streamReader = new StreamReader(@"C:\Workplace\1University\second_cource\OOTP\Csharp_3sem\Lab12\files\paramsForSum.txt");

                object result = methodInfo.Invoke(obj, new object[] { Convert.ToInt32(streamReader.ReadLine()), Convert.ToInt32(streamReader.ReadLine()) });
                Console.WriteLine($"Result of invoked func: {result}");
            }
        }
    }
}
