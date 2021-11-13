using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class buttonchek1 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public lvl2 kod;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnPointerDown(PointerEventData eventData)
    {
        kod.k1 = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        kod.k1 = false;
    }
}
