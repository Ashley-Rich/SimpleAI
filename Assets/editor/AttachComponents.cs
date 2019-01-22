using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEditor;

public class AttachComponents : Editor
{
    //SimpleAI simpleAI;

    //private void Start()
    //{
    //    simpleAI = ((MonoBehaviour)target).gameObject.GetComponent<SimpleAI>();
    //}

    public static void AttachScripts()
    {
        if(SelectBehaviours.wonder == true && SimpleAI.aiObject.GetComponent<Wonder>() == null)
        {
            SimpleAI.aiObject.AddComponent<Wonder>();
        }

        if (SelectBehaviours.lookAround == true && SimpleAI.aiObject.GetComponent<LookAround>() == null)
        {
            SimpleAI.aiObject.AddComponent<LookAround>();
        }

        if (SelectBehaviours.playerDetection == true && SimpleAI.aiObject.GetComponent<PlayerDetection>() == null)
        {
            SimpleAI.aiObject.AddComponent<PlayerDetection>();
        }

        if (SelectBehaviours.chase == true && SimpleAI.aiObject.GetComponent<Chase>() == null)
        {
            SimpleAI.aiObject.AddComponent<Chase>();
        }
    }

    public static void AutoAttachComponents()
    {
        if (SimpleAI.aiObject.GetComponent<UnityEngine.AI.NavMeshAgent>() == null)
        {
            SimpleAI.aiObject.AddComponent<UnityEngine.AI.NavMeshAgent>();
        }

        if (SimpleAI.aiObject.GetComponent<Rigidbody>() == null)
        {
            SimpleAI.aiObject.AddComponent<Rigidbody>();
        }

        if (SimpleAI.aiObject.GetComponent<NavMeshHandler>() == null)
        {
            SimpleAI.aiObject.AddComponent<NavMeshHandler>();
        }
    }
}
