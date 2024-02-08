using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    [SerializeField] private float _cooldown = 5.0f;

    State state; 
    // Start is called before the first frame update
    void Start()
    {
        IEnumerator corroutine = findNext(); 
        StartCoroutine(corroutine);
    }

    // Update is called once per frame
    void Update()
    {
       state.getBehavior().Invoke();  
    }

    private IEnumerator findNext()
    {
        while (true)
        {
            state = StateFinder.Find();
            yield return new WaitForSeconds(_cooldown);
        }
    }
}
