using System.Linq.Expressions;

namespace Aftekenopdracht_Emmer;

public class Container
{
    public delegate void OverflowEventHandler(object source, EventArgs args);
    public event OverflowEventHandler OverflowingEvent;

    public delegate void AtCapacityEventHandler(object source, EventArgs args);
    public event AtCapacityEventHandler AtCapacityEvent;

    public Container(int Capacity)
    {
        this.Capacity = Capacity;
        
    }

    public int Capacity { get; protected set; }
    public int Content { get;  set; }

    protected virtual void OnOverFlowingEvent(object sender, EventArgs e)
    {
        if (OverflowingEvent != null)
        {
            OverflowingEvent.Invoke(sender, e);
        }
    }

    protected virtual void OnAtCapacityEvent()
    {
        if (AtCapacityEvent != null)
        {
            AtCapacityEvent(this, EventArgs.Empty);
        }
    }

    public void Fill(int amount)
    {
        try
        {
            if (amount < 0)
            {
                throw new ContentUnderFlowException();
            }

            if (Content + amount > Capacity)
            {
                OnOverFlowingEvent(this, EventArgs.Empty);
                throw new ContentOverFlowException(Capacity, amount);
            }

            if (Content + amount == Capacity)
            {
                OnAtCapacityEvent();
            }
            Content += amount;
        }
        catch (ContentOverFlowException cofe)
        { }
        
    }
    

    public int Empty()
    {
        return Content = 0;
    }
}







        
   
