using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RectTransform),typeof(MouseOveringCheck))]
public class RightClickMenu : MonoBehaviour
{
    RectTransform m_rectTransform;
    MouseOveringCheck m_mouseOveringCheck;
    [SerializeField] GameObject m_popUp;

    // Start is called before the first frame update
    void Start()
    {
        m_rectTransform = GetComponent<RectTransform>();
        m_mouseOveringCheck = GetComponent<MouseOveringCheck>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            m_popUp.SetActive(true);
            m_rectTransform.position = Input.mousePosition;
        }

        if (!m_mouseOveringCheck.isMouseOver && Input.GetMouseButtonDown(0))
            m_popUp.SetActive(false);

    }

}
