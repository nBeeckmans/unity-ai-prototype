using System;
using UnityEngine;

public class AwakeState : State
{
    protected GameObject player = GameObject.Find("Player");
    protected GameObject ai = GameObject.Find("AI");

    // Permet de retourner a SleepState; 
    private static float _timeWhenWokenUp; 
    private static float _cooldown = 10f; 

    public AwakeState ()
    {
        // ne met a jour "_timeWhenWokenUp" que si on a deja atteint le cooldown 
        // donc qu'on est deja repasser au moins une fois dans SleepState ! 
        if (HasToUpdateTime())
        {
            _timeWhenWokenUp = Time.time;
        }
    }
    public override State FindNextState()
    {
        if ( IsFar())
        {
            return new AngryState(); 
        }   
        else
        {
            return new HappyState();
        } 
    }

    protected bool IsFar()
    {
        return Vector2.Distance(player.transform.position, ai.transform.position) > 10f; 
    }

    protected bool IsTired()
    {
        return Time.time - _timeWhenWokenUp > _cooldown;
    }

    protected bool HasToUpdateTime()
    {
        return _timeWhenWokenUp + _cooldown < Time.time;
    }

    public override void GetBehavior()
    {
       Debug.Log("awake!"); 
    }
}