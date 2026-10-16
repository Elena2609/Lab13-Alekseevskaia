// //Шаг 1. Метод без параметров
// using System.Runtime.Serialization;

// PrintHeader();
// PrintHeader();
// Console.WriteLine("Основная часть программа");
// PrintFooter();

// void PrintHeader(){
//     Console.WriteLine("^_^");
//     Console.WriteLine("Лабораторная работа №13");
//     Console.WriteLine("Дата формирования отчёта: 16.10.2026");
//     Console.WriteLine("0_0");
// }

// void PrintFooter(){
//     Console.WriteLine(">_<");
//     Console.WriteLine("   Конец программы");
//     Console.WriteLine("X_X");
// }

// //Шаг 2. Метод с параметрами
// void PrintStudentCard(string name, int age, string group)
// {
//     Console.WriteLine($"Студент: {name}, возраст: {age}, номер группы: {group}");
// }

// PrintStudentCard("Егор", 18, "ИСП-251");
// PrintStudentCard("Валерия", 17, "ИСП-252");

//Шаг 3. Метод, возвращающий значение
double CalculateScholarchip(double baseAmount, double bonusPersent){
    return baseAmount + baseAmount * bonusPersent / 100;
}
bool IsEligibleForBonus(double averageGrade){
    return averageGrade >= 4.5;
}
double a = 2000;
double studentaverageGrade = 4.7;
double result = 0;
if (IsEligibleForBonus(studentaverageGrade)){
    result = CalculateScholarchip(a, 15);
    Console.WriteLine($"Стипендия с надбавкой: {result}");
}
else{
    result = CalculateScholarchip(a, 0);
    Console.WriteLine($"Надбавки нет: {result}");
}

//Шаг 4. Массив как параметр
Console.WriteLine();
double CalculateAverageGrade(int[] grades)
{
    int sum = 0;
    foreach (int grade in grades)
    {
        sum += grade;
    }
    return (double)sum / grades.Length;
}

int CountFives(int[] grades){
    int count = 0;
    foreach (int grade in grades)
    {
        if (grade == 5)
        {
            count++;
        }
    }
    return count;
}

int[] grades = { 4, 5, 3, 5, 4 };
double average = CalculateAverageGrade(grades);
int counts = CountFives(grades);
Console.WriteLine(average);
Console.WriteLine(counts);

//Шаг 5. Знакомство с перегрузкой методов
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine(Add(2, 3)); // вызовет первый вариант: int Add(int, int) → 5
//         Console.WriteLine(Add(2.5, 3.5)); // вызовет второй вариант: double Add(double, double) → 6.0
//         Console.WriteLine(Add(2, 3, 4)); // вызовет третий вариант: int Add(int, int, int) → 9
//     }
//     static int Add(int a, int b)
//     {
//         return a + b;
//     }
//     static double Add(double a, double b)
//     {
//         return a + b;
//     }
//     static int Add(int a, int b, int c)
//     {
//         return a + b + c;
//     }
// } 

//Самостоятельные задания ★
// Console.WriteLine("Задача А");
// void PrintDivider()
// {
//     Console.WriteLine("------------------------------");
// }
// Console.WriteLine("11");
// PrintDivider();
// Console.WriteLine("12");


// Console.WriteLine("Задача Б");
// void PrintPerson(string name, int age){
//     Console.WriteLine($"Имя: {name}, Возраст: {age} лет");
// }
// PrintPerson("Егор", 18);
// PrintPerson("Валерия", 17);
// PrintPerson("Алена", 17);

//Индивидуальный вариант ★★
// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// Console.WriteLine("Вариант 2");
// double CalculateArea(double width, double height){
//     return width * height;
// } 

// double result = CalculateArea(5.5, 7.5);
// Console.WriteLine($"Площадь прямоугольника: {result}");

// Console.WriteLine();
// Console.WriteLine("Вариант 9");
// bool ContainsValue(int[] numbers, int target){
//     foreach (int i in numbers){
//         if (i == target){
//             return true;
//         } 
//     } return false;
// } 
// int[] numbers = {1, 3, 5, 8, 67, 12};
// int target = 8;
// bool res = ContainsValue(numbers, target);
// Console.WriteLine($"Содержится ли {target} в массиве: {res}");