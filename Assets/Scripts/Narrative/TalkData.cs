using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkData
{
    //WIP : Could handle talker sprite. 
    //WIP : Could handle talker as a "character" global node.
    string m_talkerName;
    TextData m_text;

    public TalkData()
    {
        m_text = new TextData();
    }
}
