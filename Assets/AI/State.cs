using System;

public abstract class State 
{
    public abstract State FindNextState(); 
    public abstract void GetBehavior(); 
}