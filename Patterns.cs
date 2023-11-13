using HA6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace HA6
{
    internal class Program
    {
        //1
        //abstract class Car
        //{
        //    public abstract void Info();
        //}
        //class Ford : Car
        //{
        //    public override void Info()
        //    {
        //        Console.WriteLine("Ford");
        //    }
        //}
        //class Toyota : Car
        //{
        //    public override void Info()
        //    {
        //        Console.WriteLine("Toyota");
        //    }
        //}
        //class Mersedes : Car
        //{
        //    public override void Info()
        //    {
        //        Console.WriteLine("Mersedes");
        //    }
        //}
        //abstract class Engine
        //{
        //    public virtual void GetPower()
        //    {
        //    }
        //}
        //class FordEngine : Engine
        //{
        //    public override void GetPower()
        //    {
        //        Console.WriteLine("Ford Engine 4.4");
        //    }
        //}
        //class ToyotaEngine : Engine
        //{
        //    public override void GetPower()
        //    {
        //        Console.WriteLine("Toyota Engine 3.2");
        //    }
        //}
        //class MersedesEngine : Engine
        //{
        //    public override void GetPower()
        //    {
        //        Console.WriteLine("Mersedes Engine 5.2");
        //    }
        //}
        //interface ICarFactory
        //{
        //    Car CreateCar();
        //    Engine CreateEngine();
        //}
        //class FordFactory : ICarFactory
        //{
        //    Car ICarFactory.CreateCar()
        //    {
        //        return new Ford();
        //    }
        //    Engine ICarFactory.CreateEngine()
        //    {
        //        return new FordEngine();
        //    }
        //}
        //class ToyotaFactory : ICarFactory
        //{
        //    Car ICarFactory.CreateCar()
        //    {
        //        return new Toyota();
        //    }
        //    Engine ICarFactory.CreateEngine()
        //    {
        //        return new ToyotaEngine();
        //    }
        //}
        //class MersedesFactory : ICarFactory
        //{
        //    Car ICarFactory.CreateCar()
        //    {
        //        return new Mersedes();
        //    }
        //    Engine ICarFactory.CreateEngine()
        //    {
        //        return new MersedesEngine();
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    ICarFactory carFactory = new ToyotaFactory();
        //    Car myCar = carFactory.CreateCar();
        //    myCar.Info();
        //    Engine myEngine = carFactory.CreateEngine();
        //    myEngine.GetPower();
        //    carFactory = new FordFactory();
        //    myCar = carFactory.CreateCar();
        //    myCar.Info();
        //    myEngine = carFactory.CreateEngine();
        //    myEngine.GetPower();
        //    carFactory = new MersedesFactory();
        //    myCar = carFactory.CreateCar();
        //    myCar.Info();
        //    myEngine = carFactory.CreateEngine();
        //    myEngine.GetPower();
        //    Console.ReadKey();
        //}
        //
        //
        //2
        //class Pizza
        //{
        //    string dough;
        //    string sauce;
        //    string topping;
        //    public Pizza() { }
        //    public void SetDough(string d) { dough = d; }
        //    public void SetSauce(string s) { sauce = s; }
        //    public void SetTopping(string t) { topping = t; }
        //    public void Info()
        //    {
        //        Console.WriteLine("Dough: {0}\nSause: {1}\nTopping: {2}",
        //        dough, sauce, topping);
        //    }
        //}
        //abstract class PizzaBuilder
        //{
        //    protected Pizza pizza;
        //    public PizzaBuilder() { }
        //    public Pizza GetPizza() { return pizza; }
        //    public void CreateNewPizza() { pizza = new Pizza(); }
        //    public abstract void BuildDough();
        //    public abstract void BuildSauce();
        //    public abstract void BuildTopping();
        //}
        //class HawaiianPizzaBuilder : PizzaBuilder
        //{
        //    public override void BuildDough() { pizza.SetDough("cross"); }
        //    public override void BuildSauce() { pizza.SetSauce("mild"); }
        //    public override void BuildTopping() { pizza.SetTopping("ham+pineapple"); }
        //}
        //class SpicyPizzaBuilder : PizzaBuilder
        //{
        //    public override void BuildDough() { pizza.SetDough("panbaked"); }
        //    public override void BuildSauce() { pizza.SetSauce("hot"); }
        //    public override void BuildTopping() { pizza.SetTopping("pepparoni+salami"); }
        //}
        //class MargaritaPizzaBuilder : PizzaBuilder
        //{
        //    public override void BuildDough() { pizza.SetDough("good"); }
        //    public override void BuildSauce() { pizza.SetSauce("also good"); }
        //    public override void BuildTopping() { pizza.SetTopping("very good"); }
        //}

        //class Waiter
        //{
        //    private PizzaBuilder pizzaBuilder;
        //    public void SetPizzaBuilder(PizzaBuilder pb)
        //    {
        //        pizzaBuilder =
        //    pb;
        //    }
        //    public Pizza GetPizza() { return pizzaBuilder.GetPizza(); }
        //    public void ConstructPizza()
        //    {
        //        pizzaBuilder.CreateNewPizza();
        //        pizzaBuilder.BuildDough();
        //        pizzaBuilder.BuildSauce();
        //        pizzaBuilder.BuildTopping();
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    Waiter waiter = new Waiter();
        //    PizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
        //    PizzaBuilder spicyPizzaBuilder = new SpicyPizzaBuilder();
        //    PizzaBuilder margarittaPizzaBuilder = new MargaritaPizzaBuilder();
        //    waiter.SetPizzaBuilder(hawaiianPizzaBuilder);
        //    waiter.ConstructPizza();
        //    Pizza pizza1 = waiter.GetPizza();
        //    pizza1.Info();
        //    waiter.SetPizzaBuilder(spicyPizzaBuilder);
        //    waiter.ConstructPizza();
        //    Pizza pizza2 = waiter.GetPizza();
        //    pizza2.Info();
        //    waiter.SetPizzaBuilder(margarittaPizzaBuilder);
        //    waiter.ConstructPizza();
        //    Pizza pizza3 = waiter.GetPizza();
        //    pizza3.Info();
        //    Console.ReadKey();
        //}
        //
        //
        //3
        //abstract class Mediator
        //{
        //    public abstract void Send(string message,
        //    Colleague colleague);
        //}
        //class ConcreteMediator : Mediator
        //{
        //    private ConcreteColleague1 colleague1;
        //    private ConcreteColleague2 colleague2;
        //    private ConcreteColleague3 colleague3;
        //    public ConcreteColleague1 Colleague1
        //    {
        //        set { colleague1 = value; }
        //    }
        //    public ConcreteColleague2 Colleague2
        //    {
        //        set { colleague2 = value; }
        //    }
        //    public ConcreteColleague3 Colleague3
        //    {
        //        set { colleague3 = value; }
        //    }
        //    public override void Send(string message,
        //    Colleague colleague)
        //    {
        //        if (colleague == colleague1)
        //        {
        //            colleague2.Notify(message);
        //            colleague3.Notify(message);
        //        }
        //        else if (colleague == colleague2)
        //        {
        //            colleague1.Notify(message);
        //            colleague3.Notify(message);
        //        }
        //        else
        //        {
        //            colleague1.Notify(message);
        //            colleague2.Notify(message);
        //        }
        //    }
        //}
        //abstract class Colleague
        //{
        //    protected Mediator mediator;
        //    public Colleague(Mediator mediator)
        //    {
        //        this.mediator = mediator;
        //    }
        //}
        //class ConcreteColleague1 : Colleague
        //{
        //    public ConcreteColleague1(Mediator mediator)
        //    : base(mediator)
        //    {
        //    }
        //    public void Send(string message)
        //    {
        //        mediator.Send(message, this);
        //    }
        //    public void Notify(string message)
        //    {
        //        Console.WriteLine("Colleague1 gets message: "
        //        + message);
        //    }
        //}
        //class ConcreteColleague2 : Colleague
        //{
        //    public ConcreteColleague2(Mediator mediator)
        //    : base(mediator)
        //    {
        //    }
        //    public void Send(string message)
        //    {
        //        mediator.Send(message, this);
        //    }
        //    public void Notify(string message)
        //    {
        //        Console.WriteLine("Colleague2 gets message: " + message);
        //    }
        //}
        //class ConcreteColleague3 : Colleague
        //{
        //    public ConcreteColleague3(Mediator mediator)
        //    : base(mediator)
        //    {
        //    }
        //    public void Send(string message)
        //    {
        //        mediator.Send(message, this);
        //    }
        //    public void Notify(string message)
        //    {
        //        Console.WriteLine("Colleague3 gets message: " + message);
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    ConcreteMediator m = new ConcreteMediator();
        //    ConcreteColleague1 c1 = new ConcreteColleague1(m);
        //    ConcreteColleague2 c2 = new ConcreteColleague2(m);
        //    ConcreteColleague3 c3 = new ConcreteColleague3(m);
        //    m.Colleague1 = c1;
        //    m.Colleague2 = c2;
        //    m.Colleague3 = c3;
        //    m.Send("How are you?", c1);
        //    m.Send("Fine, thanks", c2);
        //    m.Send("Hello", c3);
        //    Console.Read();
        //}
        //
        //
        //4
        //interface IChristmasTree
        //{
        //    void Display();
        //}
        //class ChristmasTree : IChristmasTree
        //{
        //    public void Display()
        //    {
        //        Console.WriteLine("Звичайна ялинка");
        //    }
        //}
        //abstract class TreeDecorator : IChristmasTree
        //{
        //    protected IChristmasTree tree;
        //    public TreeDecorator(IChristmasTree tree)
        //    {
        //        this.tree = tree;
        //    }
        //    public virtual void Display()
        //    {
        //        tree.Display();
        //    }
        //}
        //class OrnamentDecorator : TreeDecorator
        //{
        //    public OrnamentDecorator(IChristmasTree tree) : base(tree)
        //    {
        //    }
        //    public override void Display()
        //    {
        //        base.Display();
        //        AddOrnaments();
        //    }
        //    private void AddOrnaments()
        //    {
        //        Console.WriteLine("З прикрасами");
        //    }
        //}
        //class GarlandDecorator : TreeDecorator
        //{
        //    public GarlandDecorator(IChristmasTree tree) : base(tree)
        //    {
        //    }
        //    public override void Display()
        //    {
        //        base.Display();
        //        AddGarland();
        //    }
        //    private void AddGarland()
        //    {
        //        Console.WriteLine("З гірляндами і світиться");
        //    }
        //}
        //static void Main()
        //{
        //    IChristmasTree christmasTree = new ChristmasTree();
        //    christmasTree = new OrnamentDecorator(christmasTree);
        //    christmasTree = new GarlandDecorator(christmasTree);
        //    christmasTree.Display();
        //    Console.ReadKey();
        //}
        //
        //
        //5
        //interface IFigure
        //{
        //    IFigure Clone();
        //    void GetInfo();
        //}
        //class Rectangle : IFigure
        //{
        //    int width;
        //    int height;
        //    public Rectangle(int w, int h)
        //    {
        //        width = w;
        //        height = h;
        //    }
        //    public IFigure Clone()
        //    {
        //        return new Rectangle(this.width, this.height);
        //    }
        //    public void GetInfo()
        //    {
        //        Console.WriteLine("Прямокутник довжиною {0} и шириною {1}", height, width);
        //    }
        //}
        //class Circle : IFigure
        //{
        //    int radius;
        //    public Circle(int r)
        //    {
        //        radius = r;
        //    }
        //    public IFigure Clone()
        //    {
        //        return new Circle(this.radius);
        //    }
        //    public void GetInfo()
        //    {
        //        Console.WriteLine("Круг радіусом {0}", radius);
        //    }
        //}
        //class Triangle : IFigure
        //{
        //    int side1;
        //    int side2;
        //    int side3;
        //    public Triangle(int side1, int side2, int side3)
        //    {
        //        this.side1 = side1;
        //        this.side2 = side2;
        //        this.side3 = side3;
        //    }
        //    public IFigure Clone()
        //    {
        //        return new Triangle(this.side1, this.side2, this.side3);
        //    }
        //    public void GetInfo()
        //    {
        //        Console.WriteLine("Трикутник зі сторонами {0}, {1}, {2}", side1, side2, side3);
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    Console.OutputEncoding = Encoding.UTF8;
        //    IFigure figure = new Rectangle(10, 20);
        //    IFigure clonedFigure = figure.Clone();
        //    figure.GetInfo();
        //    clonedFigure.GetInfo();
        //    figure = new Circle(15);
        //    clonedFigure = figure.Clone();
        //    figure.GetInfo();
        //    clonedFigure.GetInfo();
        //    figure = new Triangle(15, 15, 15);
        //    clonedFigure = figure.Clone();
        //    figure.GetInfo();
        //    clonedFigure.GetInfo();
        //    Console.Read();
        //}
        //
        //
        //6.1
        //interface IProduct
        //{
        //    void Display();
        //}
        //class ConcreteProduct : IProduct
        //{
        //    public void Display()
        //    {
        //        Console.WriteLine("Це конкретний продукт");
        //    }
        //}
        //abstract class Creator
        //{
        //    public abstract IProduct FactoryMethod();
        //}
        //class ConcreteCreator : Creator
        //{
        //    public override IProduct FactoryMethod()
        //    {
        //        return new ConcreteProduct();
        //    }
        //}
        //static void Main()
        //{
        //    Creator creator = new ConcreteCreator();
        //    IProduct product = creator.FactoryMethod();
        //    product.Display();
        //    Console.ReadKey();
        //}
        //
        //
        //6.2
        class Subsystem1
        {
            public void Operation1()
            {
                Console.WriteLine("Виконано операцію 1 у підсистемі #1");
            }
        }
        class Subsystem2
        {
            public void Operation2()
            {
                Console.WriteLine("Виконано операцію 2 у підсистемі #2");
            }
        }
        class Facade
        {
            private Subsystem1 subsystem1;
            private Subsystem2 subsystem2;

            public Facade()
            {
                subsystem1 = new Subsystem1();
                subsystem2 = new Subsystem2();
            }

            public void Operation()
            {
                Console.WriteLine("Виконано фасадну операцію:");
                subsystem1.Operation1();
                subsystem2.Operation2();
            }
        }
        static void Main()
        {
            Facade facade = new Facade();
            facade.Operation();
            Console.ReadKey();
        }
    }
}
