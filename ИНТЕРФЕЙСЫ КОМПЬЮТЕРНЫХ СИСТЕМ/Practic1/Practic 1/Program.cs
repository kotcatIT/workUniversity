
using System.Text.RegularExpressions;

//Флаг решение
bool flagSolution = false;


//Очистка консоли
void Clear()
{ Console.Clear(); }

//Начальное представление 
void WelcomeMessage()
{
    Console.WriteLine("Для выхода из программы введите 'exit'.\n");
    Console.WriteLine("Эта программа предназначена для вычисления корней квадратного уравнения.");
    Console.WriteLine("Для получения списка команд введите 'help'.");
}

//help меню
void helpMenu()
{
    Clear();
    Console.WriteLine("Эта программа предназначена для вычисления корней квадратного уравнения.\n");
    Console.WriteLine("Список команд:");
    Console.WriteLine("-exit: Выход из программы.");
    Console.WriteLine("-help: Показать список доступных команд программы.");
    Console.WriteLine("-example: Показать пример использования команды input.");
    Console.WriteLine("-input (x1 x2 x3): Быстрый ввод коэффициентов уравнения (аналогично 'input').");
    Console.WriteLine("-solution 0|1: 0-отключает решение в ответах. 1-включает решение в ответах(изначально стоит 0)\n");

}

//Решение корней
void resenie (float num1, float num2, float num3)

{
    float disc = num2 * num2 - 4 * num1 * num3;

    if (disc < 0) Console.WriteLine("т.к D<0 , то корней нету");
    else if (disc > 0)
    {
        double x1 = (-num2 + Math.Sqrt(disc)) / 2 * num1;
        double x2 = (-num2 - Math.Sqrt(disc)) / 2 * num1;
        Console.WriteLine($"т.к D>0, то корней будет 2\" \n 1) {x1}\n 2) {x2}");
    }
    else Console.WriteLine($"т.к D=0, то корень будет 1один \n 1) {-num2 / 2 * num1}");
}
//Решение корней с решением
void resenieSolution(double num1, float num2, float num3)
{
    double discr = num2 * num2 - 4 * num1 * num3 ;
    Console.Write($"\n\nD=b^2-4ac   D={num2}^2 -4*{num1}*{num3}\t={discr}");
    if (discr > 0)
    {
        double x1 = Math.Round((-8.4 + Math.Sqrt(discr)) / 2 * 3, 3);
        double x2 = Math.Round((-8.4 - Math.Sqrt(discr)) / 2 * 3, 3);
        Console.Write("\n\n'т.к D>0, то корней будет 2" +
            $"\n\nx1 =-b+√D    \t -{num2}+√{discr}" +
            $"\n    ------  =\t------------ = {x1}" +
            $"\n      2a            2*{num1} ");


        Console.Write("\n" +
            $"\n\nx2 =-b-√D    \t -8.4-√{discr}" +
            $"\n    ------  =\t------------ = {x2}" +
            "\n      2a            2*3 ");

        Console.WriteLine($"\n\nОтвет: x1={x1} x2={x2}\n");
    }
    else if (discr == 0)
    {
        double x1 = Math.Round(-num2 / 2 * num1, 3);

        Console.Write("\n\n'т.к D=0, то корень будет 1" +

            $"\n\nx1 =  -b    \t  -{num2}" +
            $"\n    -----  =\t----- = {x1}" +
            $"\n      2a         2*{num1} \n");

        Console.WriteLine($"\n\nОтвет: x1={x1}\n");
    }

    else Console.WriteLine("т.к D<0 , то корней нету"); }

    //Быстрый ввод чисел
void fastInput(string comand)
{
    float num1=0, num2=0, num3=0;

    string[] text = comand.Split(' ');
    if (text.Length == 4 && text[0] == "input")
    {
        Clear();
        try
        {
            num1 = float.Parse(text[1]);
            num2 = float.Parse(text[2]);
            num3 = float.Parse(text[3]);
            Console.WriteLine($"Вы ввели {num1}  {num2}  {num3}");

        }
        catch
        {
            Console.WriteLine("Вы неправльные ввели данные в команду 'finput'. \nПример ввода : 'finput 1,23 3 42,6'");
            return;
        }

    }

    else 
    { Console.WriteLine("Вы неправльные ввели количество чичел, 'input' ПРИМАЕТ ТОЛЬКО 3 ЦИФРЫ \nПример ввода: 'finput 213 3 32'");
        return;
    }

    if (flagSolution) resenieSolution(num1, num2, num3);
    else resenie(num1, num2, num3);



}

// Пример ввода
void example()
{
    Clear();
    Console.Write("\n-input 3 8,4 2");

    double discr = 8.4 * 8.4 - 4 * 3 * 2;
    Console.Write($"\n\nD=b^2-4ac   D=8.4^2 -4*3*2\t={discr}");


    double x1 = Math.Round((-8.4 + Math.Sqrt(discr)) / 2 * 3, 3);
    double x2 = Math.Round((-8.4 - Math.Sqrt(discr)) / 2 * 3, 3);
    Console.Write("\n\n'т.к D>0, то корней будет 2" +
        $"\n\nx1 =-b+√D    \t -8.4+√{discr}" +
        $"\n    ------  =\t------------ = {x1}" +
        "\n      2a            2*3 ");


    Console.Write("\n" +
        $"\n\nx2 =-b-√D    \t -8.4-√{discr}" +
        $"\n    ------  =\t------------ = {x2}" +
        "\n      2a            2*3 ");

    Console.WriteLine($"Ответ: x1={x1} x2={x2}\n");
}

void solution(string flag)
{
    string[] flags = flag.Split(" ");
    if (flags.Length == 2) {
        if (flags[1] == "1")
        {
            flagSolution = true;
            Console.WriteLine("Теперь решение будет показываться");
        }
        else if (flags[1] == "0") 
        { 
            flagSolution = false;
            Console.WriteLine("Теперь решение не будет показываться");

        }
        else Console.WriteLine("'solution', может принимать только 0 или 1");

        
    }
    else Console.WriteLine("Вы неправильно ввели коммнду 'solution', пример 'solution 1'");


}



// START PROGRAMM

Clear();
WelcomeMessage();
while (true)
{
    Console.Write("\nВведите команду -");
    var comand = Console.ReadLine();

    //Ввод пользователя
    if (Regex.IsMatch(comand, "input")) fastInput(comand);

    else if (Regex.IsMatch(comand, "solution")) solution(comand);
    //Меню помощи
    else if (comand == "help") helpMenu();
    //Выхрд из программы
    else if (comand == "exit") break;
    //Меню пример 
    else if (comand == "example") example();


    else Console.WriteLine("Такой команды не существуют (Введите '-help')\n");
}

Clear();
Console.WriteLine("Спасибо за ваше внимание\n" +
    "\t\tУдачи!");

Thread.Sleep(5000);
Environment.Exit(0);