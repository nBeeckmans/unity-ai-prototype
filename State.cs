using System;

public abstract class State 
{
    protected State state; 
    protected bool isFinal {get; set;} 
    public abstract State findNextState(); 
    public abstract Func<int> getBehavior(); 
}