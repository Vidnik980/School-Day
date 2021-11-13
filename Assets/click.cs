using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class click : MonoBehaviour
{
    public GameObject predmet;
    public float x;
    public float y;
    public float z;

    public GameObject music;
    public bool start;
    public float timer;
    public Text texttimer;
    public GameObject panel;
    public GameObject paneldead;
    public GameObject panelwin;

    public int kol;
    public GameObject game1;
    public Text text1;
    public GameObject game2;
    public Text text2;
    public GameObject game3;
    public Text text3;
    public GameObject game4;
    public Text text4;
    public GameObject game5;
    public Text text5;
    public GameObject game6;
    public Text text6;
    // Start is called before the first frame update

    public void click0()
    {
        panel.SetActive(false);
        start = true;
        music.SetActive(true);
    }
    void Start()
    {
        music.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("mus"); 
        panel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (start == true)
        timer -= Time.deltaTime;
        if (((Mathf.Round(timer)) % 60) >= 10)
            texttimer.text = Mathf.Floor((Mathf.Round(timer)) / 60).ToString() + ':'  + ((Mathf.Round(timer)) % 60).ToString();
        else
            texttimer.text = Mathf.Floor((Mathf.Round(timer)) / 60).ToString() + ':' + '0' + ((Mathf.Round(timer)) % 60).ToString();
    if (timer < 0)
        {
            paneldead.SetActive(true);
        }
        if (kol == 0)
            panelwin.SetActive(true);

        if (predmet != null)
        {
            x += Time.deltaTime * 0.6f;
            y += Time.deltaTime * 0.6f;
            z += Time.deltaTime * 0.6f;
            predmet.transform.localScale = new Vector3(x, y, z); ;
            if (x > 1.4f)
            {
                Destroy(predmet);
                x = 1;
                y = 1;
                z = 1;
            }
                
        }
            

    }
    public void click1()
    {
        if (predmet == null)
        {
            predmet = game1;
            kol--;
            text1.color = new Color(255, 255, 255);
        }
    }
    public void click2()
    {
        if (predmet == null)
        {
            kol--;
            predmet = game2;
            text2.color = new Color(255, 255, 255);
        }
    }
    public void click3()
    {
        if (predmet == null)
        {
            kol--;
            predmet = game3;
            text3.color = new Color(255, 255, 255);
        }
    }
    public void click4()
    {
        if (predmet == null)
        {
            kol--;
            predmet = game4;
            text4.color = new Color(255, 255, 255);
        }
    }
    public void click5()
    {
        if (predmet == null)
        {
            kol--;
            predmet = game5;
            text5.color = new Color(255, 255, 255);
        }
    }
    public void click6()
    {
        if (predmet == null)
        {
            kol--;
            predmet = game6;
            text6.color = new Color(255, 255, 255);
        }
    }

    public void restart()
    {
        SceneManager.LoadScene(1);
    }
    public void nextlvl()
    {
        SceneManager.LoadScene(2);
    }


}
