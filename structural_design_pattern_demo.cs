// structural design pattern
using System;
using System.Collections.Generic;


/////////////////////Adapter ////////////////////////////

interface IWorkAbroad
{
    string doWork();
}

class India
{
    private readonly IWorkAbroad _workAbroad;

    public India(IWorkAbroad work)
    {
        _workAbroad = work;
    }

    public string startWork()
    {
        return _workAbroad.doWork();
    }
}

class China
{
    public string workHere()
    {
        return "You are working in China";
    }
}

class WorkAbroad : IWorkAbroad
{
    readonly China _china = new China();
    public string doWork()
    {
        return _china.workHere();
    }
}


/////////////////////Bridge ////////////////////////////
///
abstract class InvoiceItemType
{
    protected string name;
    protected int qty;
    protected decimal rate;
    protected decimal price;

    public abstract decimal getPrice();
    public abstract string getName();
    public abstract int getQty();
    public abstract decimal getRate();

    public abstract void setValues(string name, int qty, decimal rate, decimal price);

}

class InvoiceItem : InvoiceItemType
{
    public override decimal getPrice() { return price; }
    public override string getName() { return name; }
    public override int getQty() { return qty; }
    public override decimal getRate() { return qty; }

    public override void setValues(string name, int qty, decimal rate, decimal price)
    {
        this.name = name; this.qty = qty; this.rate = rate; this.price = price;
    }
}

abstract class InvoiceType
{
    protected string id;
    protected string customer;
    protected List<InvoiceItemType> _items;

    public abstract void addItem(InvoiceItemType item);
    public abstract void setCustomer(string name);
    public abstract void setId(string id);
    public abstract List<InvoiceItemType> getItems();
    public abstract decimal getTotal();
}

class Invoice : InvoiceType
{
    public Invoice()
    {
        _items = new List<InvoiceItemType>();
    }
    public override void addItem(InvoiceItemType item)
    {
        _items.Add(item);
    }
    public override void setCustomer(string name)
    {
        this.customer = name;
    }
    public override void setId(string id)
    {
        this.id = id;
    }
    public override List<InvoiceItemType> getItems()
    {
        return _items;
    }
    public override decimal getTotal()
    {
        decimal total = 0.00M;

        foreach (InvoiceItemType i in _items)
        {
            total += i.getPrice();
        }

        return total;
    }
}



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Adapter Pattern====");
        India india = new India(new WorkAbroad());
        Console.WriteLine(india.startWork());


        Console.WriteLine("Bridge Pattern====");

        Invoice invoice = new Invoice();
        invoice.setCustomer("Dell Inc");
        invoice.setId("AUY77");

        InvoiceItem item1 = new InvoiceItem();
        item1.setValues("item 1", 1, 34.00M, 34.00M);
        invoice.addItem(item1);

        InvoiceItem item2 = new InvoiceItem();
        item2.setValues("item 2", 3, 54.00M, 54.00M * 2);
        invoice.addItem(item2);

        InvoiceItem item3 = new InvoiceItem();
        item3.setValues("item 3", 4, 50.00M, 50.00M * 5);
        invoice.addItem(item3);

        Console.WriteLine("Invoice total=" + invoice.getTotal());



        Console.ReadLine ();    
    }
}


