# Design-Patterns
Singleton Pattern 
1) We can have only a single instance of a class throughout the entire application
2) Benefits: 
    Shared state
    Avoid long initializations
    Cross-class communication
    perfectly represents unique items 
3) Key implementation Points
    Private Construtor
    Read only instance
    Static instance 
    Static accessor
    The class should be sealed 
    Instance initalized in a static construtor 
4) Lazy Loading, Thread Safety, Immutable Instances

--> Factory Pattern : A combination of the Single Responsibility and Open/Closed Principles
GameBoard class shouldn't have to know how to instantitate the enemies or what enemies to create (Single Responsibility).