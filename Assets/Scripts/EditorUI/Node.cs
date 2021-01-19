using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(MouseFollowingBehaviour), typeof(MouseOveringCheck))] 
public class Node : MonoBehaviour
{
    // WIP: Same Behaviour than GridMovement, should have a base for object Following mouse? 

    MouseFollowingBehaviour m_mouseFollowingBehaviour;
    MouseOveringCheck m_mouseOveringCheck;

    // Start is called before the first frame update
    void Start()
    {
        m_mouseFollowingBehaviour = GetComponent<MouseFollowingBehaviour>();
        m_mouseOveringCheck = GetComponent<MouseOveringCheck>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && m_mouseOveringCheck.isMouseOver)
            m_mouseFollowingBehaviour.ActivateBehaviour();

        if (m_mouseFollowingBehaviour.IsActive && Input.GetMouseButtonUp(0))
            m_mouseFollowingBehaviour.DeactivateBehaviour();
    }
}
