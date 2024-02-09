using UnityEngine;
public class AngryState : AwakeState
{
    public override State FindNextState()
    {
        if ( IsTired())
        {
            return new SleepState();
        }

        if ( IsFar())
        {
            return this; 
        }   
        else
        {
            return new HappyState();
        }  
    }

    public override void GetBehavior()
    {
        Debug.Log("Angry");
    }
}