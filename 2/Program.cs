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
    public static void math_solution(){
        WriteLine(@"
Итти в айти Мы будем по своему путю. И ладно что путь не оптимальный, главное что свой.
Добро пожаловать в ~~избыточно сложное, никому особо не нужное~~ математическое решение.
НЮАНС! В этом втором решении рандомится другое число... это конечно неок, и дублирование кода
но и решать двумя способами вроде как тоже никто не говорил.");
    // рандомим число, в лимитах инта.
    int some_number = new Random().Next(int.MinValue,int.MaxValue);
    List <int> inadequate_values= new List<int>();//Отсекаем не трёхзначные числа
    inadequate_values.Add(-99);
    inadequate_values.Add(99);
    // Определяемся с величинами
    Dictionary <string,int> supval= new Dictionary<string, int>();//буфер для расчётов
    supval.Add("min",0);
    supval.Add("max",0);
    Dictionary <int,List<int>> level = new Dictionary<int, List<int>>();//тут 
    List<int> pows= new List<int>(){1,2,3,4,5,6,7,8,9};
    foreach (int step in pows)  
    {
        supval["min"]=-System.Convert.ToInt32(Math.Pow(10,step));
        supval["max"]=System.Convert.ToInt32(Math.Pow(10,step));
        level.Add(step,new List<int>(){supval["min"],supval["max"]});
    }
    level.Add(10,new List<int>(){int.MinValue,int.MaxValue});
    int devisor=0;
    int well_it_wasnt_too_easy=-1;
    if (some_number>inadequate_values[0] && some_number<inadequate_values[1]){//диааагноз :)
        WriteLine(@"Знаешь, нарандомить одно-двух-значное число ~4.3 млрд вариантов это тоже джекпот, своего рода :).
Поздравляю!");
        return;
    }
    foreach (int pow_level in level.Keys)//шарим по словарю, находим наш случай
    {
        if (some_number>level[pow_level][0] && some_number<level[pow_level][1])
        {
            devisor=pow_level;
            break;
        }
    }
    int fix_some_weird_stuff=Math.Abs(some_number);
    devisor--;//фиксим overflow exception, и вообще число при делении на большую разрядность с остатком даёт просто себя. На вышмате говорили что это тавтология.
    well_it_wasnt_too_easy=Math.Abs(((some_number%System.Convert.ToInt32(Math.Pow(10,devisor)))%System.Convert.ToInt32(Math.Pow(10,devisor-1)))/System.Convert.ToInt32(Math.Pow(10,devisor-2)));
    // выводим строку ответа
    WriteLine("Третий знак числа "+some_number.ToString()+": "+well_it_wasnt_too_easy.ToString());
    }
    public static void Main(){
        todo();
        core();
        math_solution();
    }
}