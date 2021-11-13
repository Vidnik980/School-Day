using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class people : MonoBehaviour
{
    public GameObject panel;
    public GameObject bike;
    public lvl2  kod;
    public GameObject kop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "dead")
        {
            panel.SetActive(true);
        }

        if (other.gameObject.tag == "bike")
        {
            kod.bikego = true;
        }

        if (other.gameObject.tag == "school")
        {
            SceneManager.LoadScene(4);
        }
        if (other.gameObject.tag == "road")
        {
            panel.SetActive(true);
            kop.SetActive(true);
         }


    }
}
