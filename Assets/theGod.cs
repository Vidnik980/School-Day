using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class theGod : MonoBehaviour
{
    public GameObject dead;
    public GameObject win;
    public int i;
    public float timer;
    public Text texttimer;
    public GameObject [] sheep;
    public GameObject start;
    public GameObject go;
    public Text go1;
    // Start is called before the first frame update
    void Start()
    {
        i = Random.Range(0,9);
        for (int a = 0; a < i; a++)
        {
            sheep[a].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        texttimer.text = Mathf.Round(timer).ToString();
        if (timer < 0)
        {
            go.SetActive(true);
        }
    }
    public void restart()
    {
        SceneManager.LoadScene(5);
    }
    public void newlvl()
    {
        SceneManager.LoadScene(6);
    }
    public void start1()
    {
        start.SetActive(false);
    }
    public void go2()
    {
       if (int.Parse(go1.text) == (i + 10))
        {
            win.SetActive(true);
        }
        else
        {
            dead.SetActive(true);
        }
    }
}
