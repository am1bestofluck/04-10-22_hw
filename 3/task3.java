    import java.util.Scanner;
    import java.util.HashMap;
// import java.util.Dictionary;
class task3{
    public static void todo(){
        System.out.println("## _Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным._");
    }
    private static void core(){
        // * событие старт
        Scanner pipe_i=new Scanner(System.in);
        // * задаём значение на ввод// опяяяяяяяять
        String input="";
        // * задаём выводную строку
        String output;
        // * задаём допустимые значения. _Ну потому что мы можем. За одно разберёмся как выглядит словарь_
        HashMap <String,String> correct_values= new HashMap <String,String>();
        correct_values.put("1","будний");
        correct_values.put("2","будний");
        correct_values.put("3","будний");
        correct_values.put("4","будний");
        correct_values.put("5","будний");
        correct_values.put("6","выходной");
        correct_values.put("7","выходной");
        System.out.println(correct_values.keySet());
        while (correct_values.keySet().contains(input)!=true){

        
            System.out.println("дай номер дня с 1 по 7");
            input=pipe_i.nextLine();
        }
            // * пока нет адекватного ввода
        //     * ввод подходит?
        // * выводим значение словаря по ключу "адекватного ввода"
        System.out.println(input+"й день- "+correct_values.get(input));
        pipe_i.close();
        // * событие финиш
    }
    public static void main (String[] args) {
        todo();
        core();
    } 
}