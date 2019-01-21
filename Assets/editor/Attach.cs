using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Attach : Editor
{
    SimpleAI simpleAI;

    private void Start()
    {
        simpleAI = ((MonoBehaviour)target).gameObject.GetComponent<SimpleAI>();
    }

    public void AttachComponents()
    {
        if(SelectBehaviours.wonder == true && simpleAI.aiObject.GetComponent<Wonder>() == null)
        {
            simpleAI.aiObject.AddComponent<Wonder>();
            Debug.Log("attach");
        }
    }
}
