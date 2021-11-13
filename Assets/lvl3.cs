using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class lvl3 : MonoBehaviour
{
    public float timerwin;
    public GameObject dead;
    public GameObject win;

    public float spead;
    public GameObject location1;
    public GameObject location2;
    public float new1;
    public float x;
    public float x1;
    public float x2;
    public GameObject block;
    public GameObject Canvaspole;
    public GameObject bar;
    public int random;
    public float last;
    public float timer;


    public GameObject people;
    public float y;
    public float standart;
    public bool jumpok;
    public GameObject start;
    // Start is called before the first frame update
    void Start()
    {

        new1 = location2.transform.localPosition.x;
        Time.timeScale = 0;
        y = people.transform.localPosition.y;
        standart = y;
        x = location1.transform.localPosition.x;
        x1 = location2.transform.localPosition.x;
        x2 = bar.transform.localPosition.x;
    }

    // Update is called once per frame
    void Update()
    {
        timerwin += Time.deltaTime;
        spead += 0.1f;
        x -= Time.deltaTime * spead;
        x1 -= Time.deltaTime * spead;
        x2 -= Time.deltaTime * spead;
        location1.transform.localPosition = new Vector3(x, 0, 0);
        location2.transform.localPosition = new Vector3(x1, 0, 0);
        bar.transform.localPosition = new Vector3(x2, bar.transform.localPosition.y, 0);

        timer -= Time.deltaTime;
        if (timer < 0)
        {
            random = Random.Range(1, 500);
            last = random;

            GameObject MyGenObject = Instantiate(block, bar.transform.position, transform.rotation);
            MyGenObject.transform.localPosition = new Vector3(3000, 300, 0);
            MyGenObject.transform.parent = Canvaspole.transform;
            
            timer = Random.Range(4, 9);
        }

        





        if (x < -new1)
        {
            x = new1;
        }
        if (x1 < -new1)
        {
            x1 = new1;
        }
        if (jumpok == true)
        {
            if (y < 150)
            {
                y += Time.deltaTime * spead;
            }
            else
            {
                jumpok = false;
            }
           
            people.transform.localPosition = new Vector3(people.transform.localPosition.x, y, 0);
        }
        else
        {
            if (y > standart)
            {
                y -= Time.deltaTime * spead;
            }

            people.transform.localPosition = new Vector3(people.transform.localPosition.x, y, 0);
        }

    }
    public void jump()
    {
        if (y < 0)
        {
            jumpok = true;
            y = standart;
        }
        
    }

    public void end() 
    {
     
          if (timerwin > 30)
            {
                win.SetActive(true);
            }
            else
            {
                dead.SetActive(true);
            }
        

    }
    public void start1()
    {
        start.SetActive(false);
        Time.timeScale = 1;
    }
    public void restart()
    {
        SceneManager.LoadScene(3);
    }
    public void newlvl()
    {
        SceneManager.LoadScene(4);
    }
}
