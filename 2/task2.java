import java.util.Scanner;
import java.util.function.IntUnaryOperator;
class task2{
    public static void todo(){
        System.out.println("Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет");
    }
    public static String get_input(){
        boolean decimal=false;
        String output="";
        int later;
        Scanner pipe_i= new Scanner(System.in);
        while (decimal!=true){
            try {
                System.out.println("дай число плиз");
                output=pipe_i.nextLine();
                later=Integer.parseInt(output);
                decimal=true;
                
            } catch (NumberFormatException nfe) {
                System.out.println("не число или вне границ int32("+Integer.MIN_VALUE +".."+Integer.MAX_VALUE+")");
            }
        }
        System.out.println("Приняли число "+output);
        return output;

    }
    private static boolean check_number(String input){
        if (Integer.valueOf(input)>-100 && Integer.valueOf(input)<100){
            return false;
        } 
        return true;
    }
    private static void math_solution(String input){
        double _out=-1;
        int pow_base=10;
        //переносим решение из c#
        //well_it_wasnt_too_easy=Math.Abs(((some_number%System.Convert.ToInt32(Math.Pow(10,devisor)))%System.Convert.ToInt32(Math.Pow(10,devisor-1)))/System.Convert.ToInt32(Math.Pow(10,devisor-2)));
        //находим наибольший десятичный делитель числа
        int devisor=1;
        double format= Double.parseDouble(input);
        while (format%Math.pow(pow_base, devisor)!=format){//math pow принимает дабл...
            devisor++;

        }
        //, делим число на делитель^-1 с остатком,
        format=format%Math.pow(pow_base, devisor-1);
        // потом на делитель^-2 с остатком,
        format=format%Math.pow(pow_base, devisor-2);
        // потом на цело на делитель^-3
        _out=format/Math.pow(pow_base, devisor-3);//round даёт лонг
        _out=Math.abs(_out);
        int intpart= (int) _out;
        // /Math.pow(pow_base,devisor-3);
        System.out.println("Математическое решение: "+String.valueOf(intpart));
    }
    private static void string_solution(String input){
        String strip_zero=String.valueOf(Math.abs(Integer.valueOf(input)));
        System.out.println("Строковое решение: "+strip_zero.substring(2,3));
    }
    public static void main(String[] args){
        String prepared_number=get_input();
        boolean should_proceed=check_number(prepared_number);
        if (should_proceed==true){
        math_solution(prepared_number);
        string_solution(prepared_number);
        }
        else System.out.println("В числе "+prepared_number+" третьей цифры нет");
    }
    
}
  
// * событие старт
// * задаём вводную переменную
// * рандомим случайное число от 0 до 10**6
// * задаём сопроводительную строку
// * длинна строки в символах больше трёх?
//     * нет: диагноз
//     * да: выводим на экран третий знак
// * событие финиш