using System;
using System.Diagnostics;

public class InitState : State
{
    private bool _firstTime = true; 
    
    public InitState()
    {
        isFinal = false; 
    }
    public override State findNextState()
    {
        if (_firstTime)
        {
            state = new SleepState(); 
            return state.findNextState(); 
        }
        return this;
    }

    public override Func<int> getBehavior()
    {
        Func<int> func = () => {
            Debug.WriteLine("this is init");
            return 0; 
        };
        return func; 
    }
}