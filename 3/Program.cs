using static System.Console;
// using static day_cst;

class task3{
    public static void todo(){
        WriteLine("Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
    }
    public static void core(){
        // * событие старт
        // * задаём значение на ввод
        string weekday_i;
        // * задаём выводную строку
        string print_this=" день недели- ";
        // Dictionary<string,int>limits= new Dictionary<string,int>();
        // limits.Add("lower",1);
        // limits.Add("lower",7); 
        // * задаём допустимые значения. _Ну потому что мы можем. За одно разберёмся как выглядит словарь_
        Dictionary<int,List<string>> output_details = new Dictionary<int,List<string>>();
        output_details.Add(1, new List<string>(){"Этот","будний"});
        output_details.Add(2, new List<string>(){"Второй","будний"});
        output_details.Add(3, new List<string>(){"Третий","будний"});
        output_details.Add(4, new List<string>(){"Четвёртый","будний"});
        output_details.Add(5, new List<string>(){"Лучший","будний"});
        output_details.Add(6, new List<string>(){"Шестой","выходной"});
        output_details.Add(7, new List<string>(){"Седьмой","выходной"});
        // * пока нет адекватного ввода
        //     * ввод подходит?
        bool can_proceed=false;
        int weekday_m=-1;
        while (can_proceed!=true){
            WriteLine("Дай плз день недели, вс==7");
            weekday_i=ReadLine();
            can_proceed=Int32.TryParse(weekday_i,out weekday_m);
            if (output_details.ContainsKey(weekday_m)){

            }
            else{
                can_proceed=false;
            };
        }
        // * выводим значение словаря по ключу "адекватного ввода"
        WriteLine(output_details[weekday_m][0]+print_this+output_details[weekday_m][1]);
        // * событие финиш
    }
    public static void Main(){
        todo();
        core();
    }
}