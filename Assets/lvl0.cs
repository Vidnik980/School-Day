using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class lvl0 : MonoBehaviour
{
    public GameObject panel;
    public GameObject option;
    public Slider music;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void start()
    {
        SceneManager.LoadScene(1);
    }
    public void creator()
    {
        panel.SetActive(true);
    }
    public void Option()
    {
        option.SetActive(true);
    }
    public void exit()
    {
        Application.Quit();
    }
    public void close()
    {
        panel.SetActive(false);
        option.SetActive(false);
        PlayerPrefs.SetFloat("mus", music.value);
        PlayerPrefs.Save();
    }

}
