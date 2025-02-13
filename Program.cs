namespace CPPPPAdvancedProgramming11;

class Program
{
    static void Main(string[] args)
    {
        //Events
        //Event is a feature that allows us to track
        //whether an action (like hitting a button, saving a file, connecting to a database, etc.) happened or not
        //and if so, to react.
        
        //It allows devs to record events users took in apps. E.g. name changes users made in their profiles.
        //An event is used with the delegates representing methods that can trigger this event.
        //To make this clear, you can consider the association of hitting a button (event) with what will happen after the click(Delegate)
        
        
        //Declaration
        //Check MyClass1 below
        /*MyClass1 obj1 = new MyClass1();
        obj1.MyEvent += Y; //Events' symbol is lightning.
        obj1.RaiseEvent();*/
        
        
        //IMPORTANT: Delegates are not accessable over instances of the class where they are declared although they have public keyword!!!
        //So how can we access them in different contexts?
        //-Via the class as if the declared delegate has static keyword. This answer is correct in deed.
        //But to access them over instances, we utilize from events
        
        
        //add and remove blocks
        //Although you do not define them, they automatically are defined in the background.
        //Check the defined version in MyEvent's body.
        /*void Y(){
            Console.WriteLine("Event message 1");
        }*/
    }
    
}

class MyClass1
{
    public delegate void xHandler();

    //public event xHandler MyEvent;
    /*public void RaiseEvent()
    {
        MyEvent();
    }*/
    
    //version with add and remove blocks.
    private xHandler xDelegate;
    public event xHandler MyEvent {
        add
        {
            Console.WriteLine("Event is subscribed."); 
            xDelegate += value;
        }
        remove
        {
            Console.WriteLine("Event is unsubscribed."); 
            xDelegate -= value;
        }
    }

    public void RaiseEvent()
    {
        xDelegate();
    }
}