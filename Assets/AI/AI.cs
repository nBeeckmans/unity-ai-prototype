
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    [SerializeField] private float _cooldown = 5.0f;

    private State _state; 
    // Start is called before the first frame update
    void Start()
    {
        IEnumerator corroutine = FindNext(); 
        StartCoroutine(corroutine);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(_state.GetType().Name);
       _state.GetBehavior();  
    }

    private IEnumerator FindNext()
    {
        while (true)
        {
            _state = StateFinder.Find();
            yield return new WaitForSeconds(_cooldown);
        }
    }
}
