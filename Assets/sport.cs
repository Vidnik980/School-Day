using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sport : MonoBehaviour
{
    public lvl3 kod;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "dead")
        {
            kod.end();
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
