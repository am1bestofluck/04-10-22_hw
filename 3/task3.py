def todo()->None:
    print("## _Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным._")
    return
def describe_week_day()->None:
    '''принимаем день недели и сообщаем выходной ли он'''
    _input=""
    while _input not in ["1","2","3","4","5","6","7"]:
        _input=input("введи пож день недели")
    match _input:
        case "6"|"7":
            field="выходной"
        case _:
            field="будний"
    print(f"{_input}й день недели- {field}")
    return

def main():
    todo()
    describe_week_day()

if __name__=="__main__": main()