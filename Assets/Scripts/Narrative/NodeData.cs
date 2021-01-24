using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NodeType
{
    NONE = 0,
    TALK,
    ANSWER,

}

public class NodeData
{
    
    public string name;
    public NodeType type;

    public List<TalkData> talkDatas;

    // Start is called before the first frame update
    public NodeData()
    {
        Debug.Log("node data created");
        name = "";
        talkDatas = new List<TalkData>();
        talkDatas.Add(new TalkData());
    }


}
