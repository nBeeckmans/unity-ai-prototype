using System;
using UnityEngine;

public class SleepState : State
{
    private bool _IsAsleep = true; 
    public override State FindNextState()
    {
        if ( _IsAsleep )
        {
            _IsAsleep = false; 
            return this;
        }
        return new AwakeState().FindNextState(); 
    }

    public override void GetBehavior()
    {
       Debug.Log("i sleep");
    }
   
}