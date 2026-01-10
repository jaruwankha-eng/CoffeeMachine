นางสาวจารุวรรณ เค้าเหลือง 683450184-0

classDiagram
    Program --> CoffeeMachine : uses

    class Program {
        +Main()
    }

    class CoffeeMachine {
        -int water
        -int coffee
        -int milk
        -int chocolate
        +MakeCoffee()
        +MakeMocha()
        +MakeLatte()
        +MakeChocolate()
        +ShowStock()
    }
