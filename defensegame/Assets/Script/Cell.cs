using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Cell : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Transform child;
    
    private void OnEnable()
    {
        child = transform.GetChild(0);
        Debug.Log("fuck you");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        child.GetComponent<Image>().color = Color.gray;
        Debug.Log("fuck you3");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        child.GetComponent<Image>().color = Color.white;
        Debug.Log("fuck you4");
    }
}
