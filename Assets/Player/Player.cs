using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // move 
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");

        this.transform.position += new Vector3(h , v , 0).normalized * Time.deltaTime * _speed;

    }
}
