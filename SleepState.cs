using System;
using System.Diagnostics;

public class SleepState : State
{
    private bool _asleep = true; 
    public override State findNextState()
    {
        if ( _asleep )
        {
            _asleep = false; 
            return this;
        }
        
        return state.findNextState(); 
    }

    public override Func<int> getBehavior()
    {
        Func<int> func = () => {
            Debug.WriteLine("i sleep");
            return 1; 
        };
        return func;
    }

   
}