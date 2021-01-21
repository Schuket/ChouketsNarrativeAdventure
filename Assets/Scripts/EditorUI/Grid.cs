using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MouseFollowingBehaviour), typeof(RectTransform))]
public class Grid : MonoBehaviour
{
    private RectTransform m_rectTransform; 
    private MouseFollowingBehaviour m_mouseFollowingBehaviour;

    [SerializeField] GameObject m_nodePrefab;

    private void Start()
    {
        m_rectTransform = GetComponent<RectTransform>();
        m_mouseFollowingBehaviour = GetComponent<MouseFollowingBehaviour>();
    }

    void Update() // WIP: INPUT => Could be using Command System
    {
        if (Input.GetKeyDown(KeyCode.Space)) // WIP: Need to change the input, otherwise will conflict when writing inside nodes
            GoToCenter();

        //if (Input.GetMouseButtonDown(1))
        //    CreateNode();

        if (Input.GetMouseButtonDown(2))
            m_mouseFollowingBehaviour.ActivateBehaviour();

        if (m_mouseFollowingBehaviour.IsActive && Input.GetMouseButtonUp(2))
            m_mouseFollowingBehaviour.DeactivateBehaviour();
    }

    private void GoToCenter()
    {
        m_rectTransform.localPosition = Vector2.zero;
    }

    public void CreateNode()
    {
        GameObject newNode = Instantiate<GameObject>(m_nodePrefab);
        newNode.transform.SetParent(transform);
        newNode.transform.position = Input.mousePosition;// new Vector3(0f, 0f, 0f);
    }
}
