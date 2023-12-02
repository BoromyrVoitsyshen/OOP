using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //class Item
    //{

    //}
    //class Order
    //{
    //    private List<Item> itemList;
    //    public List<Item> ItemList { get { return itemList; } set { itemList = value; } }
    //    //замінили internal на public
    //    //використання internal буде порушенням принципу інкапсуляції даних
    //    public void CalculateTotalSum() {/*...*/}
    //    public void GetItems() {/*...*/}
    //    public void GetItemCount() {/*...*/}
    //    public void AddItem(Item item) {/*...*/}
    //    public void DeleteItem(Item item) {/*...*/}
    //    public void PrintOrder() {/*...*/}
    //    public void ShowOrder() {/*...*/}
    //    public void Load() {/*...*/}
    //    public void Save() {/*...*/}
    //    public void Update() {/*...*/}
    //    public void Delete() {/*...*/}
    //}

    //class Email
    //{
    //    public String Theme { get; set; }
    //    public String From { get; set; }
    //    public String To { get; set; }
    //}
    //class EmailSender//цей клас порушував принцип відповідальності бо виконував два обов'язки
    //{
    //    public void Send(Email email)
    //    {
    //        // ... sending...
    //    }
    //}

    //class EmailLogger//для запобігання помилки ми виділяємо ще один клас який буде відповідати за логи
    //{
    //    public void Log(Email email)
    //    {
    //        Console.WriteLine("Email from '" + email.From + "' to'" + email.To + "' was send");
    //    }
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Email e1 = new Email() { From = "Me", To = "Vasya", Theme = "Who are you?" };
    //        Email e2 = new Email() { From = "Vasya", To = "Me", Theme = "vacuum cleaners!" };
    //        Email e3 = new Email() { From = "Kolya", To = "Vasya", Theme = "No! Thanks!" };
    //        Email e4 = new Email() { From = "Vasya", To = "Me", Theme = "washing machines!" };
    //        Email e5 = new Email() { From = "Me", To = "Vasya", Theme = "Yes" };
    //        Email e6 = new Email() { From = "Vasya", To = "Petya", Theme = "+2" };
    //        EmailSender es = new EmailSender();
    //        EmailLogger el = new EmailLogger();

    //        es.Send(e1);
    //        el.Log(e1);

    //        es.Send(e2);
    //        el.Log(e2);

    //        es.Send(e3);
    //        el.Log(e3);

    //        es.Send(e4);
    //        el.Log(e4);

    //        es.Send(e5);
    //        el.Log(e5);

    //        es.Send(e6);
    //        el.Log(e6);

    //        Console.ReadKey();
    //    }
    //}
    //interface IShape
    //{
    //    int GetArea();
    //}

    //class Rectangle : IShape
    //{
    //    public virtual int Width { get; set; }
    //    public virtual int Height { get; set; }

    //    public int GetArea()//тут було порушено принцип Open/Closed тому ми створили інтерфейс
    //    {
    //        return Width * Height;
    //    }
    //}

    //class Square : Rectangle
    //{
    //    public override int Width { get { return base.Width; } set { base.Height = value; base.Width = value; } }
    //    public override int Height { get { return base.Height; } set { base.Height = value; base.Width = value; } }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Rectangle rect = new Square();
    //        rect.Width = 5;
    //        rect.Height = 10;
    //        Console.WriteLine(rect.GetArea());
    //        Console.ReadKey();
    //    }
    //}
    //interface IPriced
    //{
    //    double GetPrice();
    //    void SetPrice(double price);
    //}

    //interface IDiscountable
    //{
    //    void ApplyDiscount(String discount);
    //}

    //interface IPromocodeable
    //{
    //    void ApplyPromocode(String promocode);
    //}

    //interface IColorable
    //{
    //    byte GetColor();
    //    void SetColor(byte color);
    //}

    //interface ISizeable
    //{
    //    byte GetSize();
    //    void SetSize(byte size);
    //}
}
