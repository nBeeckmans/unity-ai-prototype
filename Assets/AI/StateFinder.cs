
using Unity.VisualScripting;
using UnityEngine;


public static class StateFinder 
{
    private static State _lastState = new InitState(); 

    public static State Find()
    {
        // clairement pas tres clair, permet chercher a partir du dernier etat ! 
        _lastState = _lastState.FindNextState();
        return _lastState; 
    }
}