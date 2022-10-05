using static System.Console;
class task2{
    public static void todo(){
        WriteLine("Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
    }
    public static void core(){
        // * событие старт
        // * задаём вводную переменную
        int number_i;
        // * рандомим случайное число от 0 до 10**6
        int I_WISH_IT_DIDNT_HAVE_TO_BE_THIS_WAY;// отсылка к Стивен Кинг The stand. СовеtoYou ;)
        I_WISH_IT_DIDNT_HAVE_TO_BE_THIS_WAY=System.Convert.ToInt32(Math.Pow(10,6));
        Dictionary<string,int> limits= new Dictionary<string,int>();
        limits.Add("lower", 0 );
        limits.Add("upper", I_WISH_IT_DIDNT_HAVE_TO_BE_THIS_WAY);
        number_i= new Random().Next(limits["lower"],limits["upper"]);
        // * задаём сопроводительную строку
        string number_m=number_i.ToString();
        // * длина строки в символах больше трёх?
        if (number_m.Length<4){
        //     * нет: диагноз
        WriteLine(@"Знаешь, нарандомить число меньше ста из одного миллиона(+1) вариантов это тоже джекпот, своего рода :).
Поздравляю!");
        }
        //     * да: выводим на экран третий знак
        else {
            string shortcut=number_m[2].ToString();
            WriteLine("Выпало число "+number_m.Substring(0,2)+"["+shortcut+"]"+number_m.Substring(3,number_m.Length-3)+@".
Искомый знак: "+shortcut+"!");
        }
        // * событие финиш
    }
    public static void Main(){
        todo();
        core();
    }
}