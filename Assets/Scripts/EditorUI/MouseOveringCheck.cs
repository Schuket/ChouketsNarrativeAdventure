using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// WIP : Could maybe be passed down to an object, not much used to be a MonoBehaviour right now
public class MouseOveringCheck : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private bool m_mouseOver = false;

    public bool isMouseOver { get { return m_mouseOver; } }

    public void OnPointerEnter(PointerEventData eventData)
    {
        m_mouseOver = true;
        //Debug.Log("Mouse enter " + gameObject.name);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        m_mouseOver = false;
        //Debug.Log("Mouse exit " + gameObject.name);
    }
}
