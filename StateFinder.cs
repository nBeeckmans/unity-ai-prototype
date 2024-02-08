
using UnityEngine;

public static class StateFinder 
{
    private static State _lastState = new InitState(); 

    // pas d'implementation
    public static State _lastFinalState = null; 
    public static State Find()
    {
        // clairement pas tres clair 
        _lastState = _lastState.findNextState();
        return _lastState; 
    }
}