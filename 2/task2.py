
def get_input()->dict:
    while True:
        out=input("дай число плз")
        match out.count("-"):
            case 1:
                if out.startswith("-"):
                    out=out[1:]
                    if out.isdecimal():
                        return {"num":out,"positive":False}
            case 0:
                if out.isdecimal():
                    return {"num":out,"positive":True}

def get_digit(position:int,incoming_data:dict)->None:
    assert isinstance(position,int)#вот Я ещё это не крыжил
    position=abs(position)
    shortcut=f"{incoming_data['num']}" if incoming_data["positive"] else f"-{incoming_data['num']}"
    shortcut_int=int(incoming_data['num'])
    if len(incoming_data["num"])<=position:
        print(f"Число {shortcut} не содержит в себе {str(position+1)} знаков.")
        return
    # cтрока
    _char=incoming_data['num'][position]#женюсь.
    # матчасть
    #как найти первый знак? нужно число поделить на нижний разряд
    sc_len=len(incoming_data['num'])
    max_pow=len(incoming_data['num'])-1
    match position:
        case 0:
            shortcut_int=shortcut_int//10**(max_pow)
        case _:
            stop_here=10**(sc_len-position)
            while shortcut_int>stop_here:
                shortcut_int=shortcut_int%10**max_pow
                max_pow-=1
                # print(shortcut_int)
            shortcut_int=int(shortcut_int//(stop_here/10))

            



    if shortcut_int!=int(_char):
        print(f'\n\n\nerror!!!\tsc={str(shortcut_int)}\tchar={_char}')
    print(f"Знак № {str(position+1)}:\tмат:{str(shortcut_int)}\tстр:{_char}")

def main():
    todo="""Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет."""
    note="""Прим: По три раза писать одно и то же- довольно скучно. Пусть будет любой цифры.
Прим2: Я настаиваю что решать эту задачу через разрядность это потеря времени.
По крайней мере в десятичной системе счисления, другие не тестировал."""
    print(todo)
    print(note)
    number=get_input()
    print(f'\nпринял число {str(number["num"]) if number["positive"] else str("-"+number["num"])}')
    for walk in range(0,len(number["num"])+1):
        get_digit(position=walk,incoming_data=number)

if __name__=="__main__":
    main()