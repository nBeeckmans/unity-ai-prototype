using UnityEngine;
public class HappyState : AwakeState 
{
    public override State FindNextState()
    {
        if ( IsTired())
        {
            return new SleepState();
        }
        if ( IsFar())
        {
            return new AngryState(); 
        }   
        else
        {
            return this;
        } 
    }

    public override void GetBehavior()
    {
        Debug.Log("Happy");
    }
}