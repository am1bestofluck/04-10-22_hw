import java.util.Scanner;
class task1{
    public static void todo(){
        System.out.println("Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
    }
    public static void core(){
        Scanner pipe_i=new Scanner(System.in);
        int limit_lower=99;//трёхзначные...
        int limit_upper=1000;//...числа. Синтаксис Словарей это нечто.
        String number_i="";//буфер для принятия ввода
        int number_m=-1;//буфер для оцифровки строки
        int number_o;//для матчасти
        System.out.println("...4zh");
        boolean check_input=false;
        while (check_input!=true){
            try {
                System.out.println("дай число плиз, между"+String.valueOf(limit_lower)+" и "+String.valueOf(limit_upper));
                number_i=pipe_i.nextLine();
                number_m=Integer.valueOf(number_i);
                if (number_m>limit_lower && number_m<limit_upper){
                check_input=true;
                }
                else {
                    System.out.println("продолжай, Мне нравится :)");
                }
            } catch (NumberFormatException q) {
                System.out.println("не число...");
            }
        }
        pipe_i.close();
        System.out.println("Принято число "+String.valueOf(number_m)+"!");
        //матчасть
        System.out.println("Математическое решение: "+String.valueOf(number_m/10%10));
        //строки
        System.out.println("строковое решение: "+number_i.substring(1,2));
        
    }
    public static void main(String[] args){
        todo();
        core();
    }
}