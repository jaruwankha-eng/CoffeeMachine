นางสาวจารุวรรณ เค้าเหลือง 683450184-0

classDiagram
    class Program {
        - CoffeeMachine machine
        + Main(args)
    }

    class CoffeeMachine {
        - int water
        - int coffee
        - int milk
        - int chocolate
        + MakeCoffee()
        + MakeMocha()
        + MakeLatte()
        + MakeChocolate()
        + ShowStock()
    }

    Program --> CoffeeMachine : uses
