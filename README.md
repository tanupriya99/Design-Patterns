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

--> Loose Coupling : Software parts that communicate with each other have little to no knowledge of each other's actual implementation. Software components that are loosly coupled are called Black Boxes.
Benefits:
1) Easier to work with large projects
2) Swap implementations
3) Testability
4) Components grow independently

--> Singleton vs Transient vs Scoped
1) Singleton: The service is instatiated once and used throughout the application
2) Transient: A new service is intantiated every time we request it
3) Scoped: A new instance created for every http request