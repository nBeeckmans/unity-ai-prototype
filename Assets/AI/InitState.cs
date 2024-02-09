using Unity;
using System;
using UnityEngine;

public class InitState : State
{
    public override State FindNextState()
    {
        // ici inutile mais pourrait servir pour reutiliser le meme graph sur differents 
        // niveaux avec des points d'entree differents
        // ex : 
        // if scene 1 : 
        if (IsScene1())
        {
            return new SleepState().FindNextState(); 
        }
        
        // if scene 2 :
        // state = new AwakeState();  
        // return state.findNextState(); 

        //n'arrive jamais ! 
        return null;
    }

    public override void GetBehavior()
    {
       // point d'entrer du graph, ne doit pas apparaitre
       Debug.Log("this is init");
    }

    private bool IsScene1()
    {
        return true; 
    }
}