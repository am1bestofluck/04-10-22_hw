using  static System.Console;
class task1 {
    private static void todo(){
        
        WriteLine("## _Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
    }
    private static void core (){
    // * событие старт
    bool correct_input=false;
    string input_i="";
    int input_m=0;
    Dictionary<string, int> borders =new Dictionary<string, int>();// КТО СКАЗАЛ НЕУДОБНО????
    borders.Add("lower",99);//ну тут классно кстати...
    borders.Add("upper",1000);// и тут XD
    // * пока нет адекватного ввода
    while (correct_input!=true){
        //     * принимаем ввод
        WriteLine("Дай число плз");
        input_i=ReadLine();
        correct_input=Int32.TryParse(input_i, out input_m);
    }
    //     * проверяем...
    //         * а это целое число? // вопрос немножко некорректный...
    //// TryParse вместе с true выдаст на верх int... а вместе с False-тоже int.
    //// Так что тут всё надёжно как зарядка для мака- суётся везде и разъём отзеркален.
    ////         * а оно трёхзначное?
    if (input_m < borders["lower"] || input_m > borders["upper"])
    {
        WriteLine("НЕ ТРЁХЗНАЧНОЕ");
        return;
    }
    // * матчасть
    //     * создаём сопроводительную переменную(сп), ну т.е. ввод но уже интовый
    ////вопрос решил себя сам
    //     * задаём печатное поле(пп)
    string output_str="Математический подход даёт нам ";
    //     * ложим в пп остаток от деления сп на 100
    input_m=input_m%100;
    //     * ложим в пп целочисленное деление пп на 10
    input_m=input_m/10;
    //     * печатаем пп
    output_str=output_str+input_m.ToString();
    WriteLine(output_str);
    // * строчная халтура 
    //     * задаём печатное поле (пп)
    output_str="Строковый подход даёт на выходе то же самое ";
    Write(output_str);
    //     * выводим второй знак...сложна.
    Write (input_i.Substring(1,1));
    //     * выводим ещё раз, но удаляем первый и третий знак...вот так норм! 
    Write(" разными способами: ");
    Write(input_i[1]);
    WriteLine(@".
Есть даже совсем замудрённые, типа обратного перевода в string char объектов которые
получаются из индексирования строки: "+input_i[1].ToString());
    WriteLine(@" 
Ps для многострочных строк можно можно ставить собачку @ перед открывающей кавычкой,
вплотную. При этом символ новой строки \n становится литералом, ну т.е. рядовыми буковками.");
    // * событие финиш
    }

    public static void Main(){
        todo();
        task1.core();
    }
} 