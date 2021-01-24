using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Button), typeof(MouseFollowingBehaviour), typeof(MouseOveringCheck))]
public class Node : MonoBehaviour
{
    // WIP: Same Behaviour than GridMovement, should have a base for object Following mouse? 
    [SerializeField] Text m_nameText;

    Button m_button;
    MouseFollowingBehaviour m_mouseFollowingBehaviour;
    MouseOveringCheck m_mouseOveringCheck;

    NodeData m_nodeData;
    public NodeData data { get { return m_nodeData; } }

    // Start is called before the first frame update
    void Start()
    {
        m_button = GetComponent<Button>();
        m_mouseFollowingBehaviour = GetComponent<MouseFollowingBehaviour>();
        m_mouseOveringCheck = GetComponent<MouseOveringCheck>();
        m_nodeData = new NodeData();
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && m_mouseOveringCheck.isMouseOver)
            m_mouseFollowingBehaviour.ActivateBehaviour();

        if (m_mouseFollowingBehaviour.IsActive && Input.GetMouseButtonUp(0))
            m_mouseFollowingBehaviour.DeactivateBehaviour();
    }

    public void SetName(string newName)
    {
        if (newName == "")
            newName = "Node";
        m_nameText.text = newName;
    }

    public void OnClick()
    {
        NodeSelector.instance.UpdateSelectedNode(this);
    }

    public void Select()
    {
        m_button.interactable = false;
    }

    public void UnSelect()
    {
        m_button.interactable = true;
    }
}
