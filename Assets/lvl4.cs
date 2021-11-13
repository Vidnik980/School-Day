using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class lvl4 : MonoBehaviour
{
    public bool ready1;
    public Text button;
    public int[] a = new int[30];
    public int i = 0;
    public int ii;
    public int number;
    public float timer = 1f;
    public int k;
    public GameObject panel;
    public GameObject dead;
    public Text deadtext;
    public GameObject win;
    public GameObject start;
    public Text wintext;
    // Start is called before the first frame update
    void Start()
    {
      
    }
    public void ready()
    {
        if (i == ii)
        {
            panel.SetActive(true);
            k = 0;
            ii = 0;
            i++;

            do
            {
                a[i] = Random.Range(1, 10);
            }
            while (a[i] == a[i - 1]);

            ready1 = true;
            timer = 0;
        }
        
    }

    public void brain()
    {
        if (i >= k)
        {
                button.text = a[k].ToString();
        }
        else
        {
            ready1 = false;
            button.text = "_";
            panel.SetActive(false);
        }
            
        
      

        
    }

    // Update is called once per frame
    void Update()
    {
        if (ready1 == true)
        {
            timer -= Time.deltaTime;
        }
       
        if (timer < 0)
        {
            k++;
            brain();
            timer = 1f;
        }
    }
    public void button1()
    {
        ii++;
        number = 1;
        brain1();
    }
     public void button3()
    {
        ii++;
        number = 3;
        brain1();
    }
    public void button4()
    {
        ii++;
        number = 4;
        brain1();
    }
    public void button5()
    {
        ii++;
        number = 5;
        brain1();
    }
    public void button6()
    {
        ii++;
        number = 6;
        brain1();
    }
    public void button7()
    {
        ii++;
        number = 7;
        brain1();
    }
    public void button8()
    {
        ii++;
        number = 8;
        brain1();
    }
    public void button9()
    {
        ii++;
        number = 9;
        brain1();
    }
    public void button2()
    {
        ii++;
        number = 2;
        brain1();
    }

    public void brain1()
    {
        if(ii == i)
        {
            panel.SetActive(true);
        }
        if(number != a[ii])
        {
            if((i-1)>=5)
            {
                wintext.text = "Рома получил "+ (i - 1).ToString() + "!";
                win.SetActive(true);

            }
            else
            {
                deadtext.text = "Рома получил " + (i - 1).ToString() + "!";
                dead.SetActive(true);
            }

        }
    }
    public void restart()
    {
        SceneManager.LoadScene(4);
    }
    public void newlvl()
    {
        SceneManager.LoadScene(5);
    }
    public void start1()
    {
        start.SetActive(false);
    }
}
