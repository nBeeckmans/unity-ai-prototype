using System;
using UnityEngine;

public class AwakeState : State
{
    private float _timeWhenWokenUp; 

    public AwakeState ()
    {
        _timeWhenWokenUp = Time.time;
    }
    public override State findNextState()
    {
        throw new NotImplementedException();
    }

    public override Func<int> getBehavior()
    {
        throw new NotImplementedException();
    }
}