using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl5 : MonoBehaviour
{
    public float x;
    public float y;
    public float x1;
    public float y1;
    public bool xbool;
    public bool ybool;
    public GameObject sheep1;
    public GameObject sheep2;
    public GameObject sheep3;
    public GameObject sheep4;
    public GameObject sheep;
    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(50, Screen.width - 50);
        y = Random.Range(50, Screen.height - 50);
        x1 = x;
        y1 = y;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(x - x1) < 10)
        {
            xbool = false;
        }
        if (Mathf.Abs(y - y1) < 10)
        {
            ybool = false;
        }
        if ((xbool == false) && (ybool == false))
        {
            randomSheep();
        }
        if (x1 > x)
        {
            x1 -= Time.deltaTime * 100;
        }
        else
        {
            x1 += Time.deltaTime * 100;
        }
        if (y1 > y)
        {
            y1 -= Time.deltaTime * 100;
        }
        else
        {
            y1 += Time.deltaTime * 100;
        }
        sheep.transform.position = new Vector3(x1, y1, sheep.transform.position.z);


        if ((x > x1) && (y > y1) && (xbool == true) && (ybool == true))
        {
            sheep1.SetActive(false);
            sheep2.SetActive(false);
            sheep3.SetActive(true);
            sheep4.SetActive(false);
        }
        if ((x < x1) && (y > y1) && (xbool == true) && (ybool == true))
        {
            sheep1.SetActive(false);
            sheep2.SetActive(false);
            sheep3.SetActive(false);
            sheep4.SetActive(true);
        }
        if ((x < x1) && (y < y1) && (xbool == true) && (ybool == true))
        {
            sheep1.SetActive(false);
            sheep2.SetActive(true);
            sheep3.SetActive(false);
            sheep4.SetActive(false);
        }
        if ((x > x1) && (y < y1) && (xbool == true) && (ybool == true))
        {
            sheep1.SetActive(true);
            sheep2.SetActive(false);
            sheep3.SetActive(false);
            sheep4.SetActive(false);
        }


    }
    public void randomSheep()
    {
        x = Random.Range(50, Screen.width - 50);
        y = Random.Range(50, Screen.height - 50);
        xbool = true;
        ybool = true;
    }
}
