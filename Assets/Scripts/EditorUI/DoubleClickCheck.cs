using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class DoubleClickCheck : MonoBehaviour
{
    [SerializeField] float delayMaxBetweenClick = 0.5f;
    //WIP : Event when node is created

    bool m_clickedOnce = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            

        }
    }
}
