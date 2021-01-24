using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NodeInspector : MonoBehaviour
{
    #region
    static NodeInspector m_instance;
    static public NodeInspector instance { get { return m_instance; } }

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

    Node m_currentNode = null;

    [SerializeField] InputField m_nameField;
    [SerializeField] Text m_typeText;

    [SerializeField] Button[] m_textSelectorButtons;
    [SerializeField] InputField[] m_textFields;

    // Start is called before the first frame update
    void Start()
    {
        if (m_textSelectorButtons.Length <= 0 || m_textFields.Length <= 0)
            Debug.LogError("No Button or Input field set in NodeInspector");

        if (m_textSelectorButtons.Length != m_textFields.Length)
            Debug.LogError("Amount of button and Input field doesn't match in NodeInspector");
    }

    public void ActivateInpuField(int ID)
    {
        HideAll();
        m_textFields[ID].gameObject.SetActive(true);
    }

    void HideAll()
    {
        //foreach(Button textSelector in m_textSelectorButtons)
        //    textSelector.sele

        for(int i = 0; i < m_textFields.Length; i++)
        {
            m_textFields[i].gameObject.SetActive(false);
        }
    }

    public void ManageNode(Node node)
    {
        Debug.Log("inspector manage node named " + node.data);
        m_currentNode = node;
        m_nameField.text = node.data.name;
        m_typeText.text = "Talk";  //node.data.type; WIP => Convert Enum to String;
    }

    public void Save()
    {
        if (!m_currentNode)
            return;

        m_currentNode.data.name = m_nameField.text;
        m_currentNode.SetName(m_nameField.text);
    }
}
