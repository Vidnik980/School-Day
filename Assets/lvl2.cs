using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class lvl2 : MonoBehaviour
{
    public bool bikego =false;
    public int spead;
    public bool k;
    public bool k1;
    public GameObject location;
    public bool step;
    public float y;
    public float x;
    public float timer;
    public GameObject chel;
    public GameObject chel1;
    public GameObject chel2;
    public GameObject bike;
    public GameObject dog;
    public GameObject start;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        y = location.transform.position.y;
        x = bike.transform.position.x;
    }

    public void restart()
    {
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0)
        {
            if (step == true)
            {
                chel1.SetActive(false);
                chel2.SetActive(true);
                dog.SetActive(true);
            }
            if (step == false)
            {
                chel1.SetActive(true);
                chel2.SetActive(false);
                dog.SetActive(false);
            }
            step = !step;
            timer = 0.5f;

        }
        y -= Time.deltaTime * spead;
        
        location.transform.position = new Vector3(location.transform.position.x, y, 0);


        if (bikego == true)
        {
                 x += Time.deltaTime * spead*3;
                bike.transform.position = new Vector3(x,bike.transform.position.y, 0);
        }
      

        if (k == true && chel.transform.localPosition.x < 1050)
        {
            chel.transform.position = chel.transform.position + new Vector3(Screen.width/500, 0, 0);
        }
        if (k1 == true && chel.transform.localPosition.x > -1100)
        {
            chel.transform.position = chel.transform.position + new Vector3(-Screen.width / 500, 0, 0);
        }
    }

    public void start1()
    {
        start.SetActive(false);
        Time.timeScale = 1;
    }
}