using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class MouseFollowingBehaviour : MonoBehaviour
{
    RectTransform m_rectTransform;
    private bool m_active = false;

    private Vector3 m_beforeFollowingPosition;
    private Vector3 m_beforeFollowingMousePosition;

    public bool IsActive { get { return m_active; } }

    void Start()
    {
        m_rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        if (m_active)
            m_rectTransform.localPosition = (Input.mousePosition - m_beforeFollowingMousePosition) + m_beforeFollowingPosition;
    }

    public void ActivateBehaviour()
    {
        m_active = true;
        m_beforeFollowingPosition = m_rectTransform.localPosition;
        m_beforeFollowingMousePosition = Input.mousePosition;
    }

    public void DeactivateBehaviour()
    {
        m_active = false;
    }
}
