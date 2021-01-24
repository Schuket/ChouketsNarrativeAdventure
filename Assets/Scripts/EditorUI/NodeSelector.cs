using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeSelector : MonoBehaviour
{
    #region
    static NodeSelector m_instance;
    static public NodeSelector instance { get { return m_instance; } }

    private void Awake()
    {
        if (m_instance)
            Destroy(gameObject);
        else
        {
            m_instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    #endregion

    Node m_selectedNode;

    //Node[] m_selectedNodes; => WIP : enable multi selection 

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            UnselectCurrentNode();
    }


    public void UpdateSelectedNode(Node newNode)
    {
        UnselectCurrentNode();

        SelectNode(newNode);        
    }

    void SelectNode(Node node)
    {
        m_selectedNode = node;
        m_selectedNode.Select();

        Debug.Log("selected node is " + m_selectedNode.gameObject.name);
        Debug.Log("new node data name is = " + m_selectedNode.data.name);
        NodeInspector.instance.gameObject.SetActive(true);
        NodeInspector.instance.ManageNode(m_selectedNode);
    }

    void UnselectCurrentNode()
    {
        if (!m_selectedNode)
            return;

        m_selectedNode.UnSelect();
        m_selectedNode = null;

        //HideInspector
    }
}
