using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class RemoveComponents : Editor
{
     public static void RemoveScripts()
    {
        if (SimpleAI.aiObject.GetComponent<Wonder>() != null)
        {
            DestroyImmediate(SimpleAI.aiObject.GetComponent<Wonder>(), true);
        }

        if (SimpleAI.aiObject.GetComponent<LookAround>() != null)
        {
            DestroyImmediate(SimpleAI.aiObject.GetComponent<LookAround>(), true);
        }

        if (SimpleAI.aiObject.GetComponent<PlayerDetection>() != null)
        {
            DestroyImmediate(SimpleAI.aiObject.GetComponent<PlayerDetection>(), true);
        }

        if (SimpleAI.aiObject.GetComponent<Chase>() != null)
        {
            DestroyImmediate(SimpleAI.aiObject.GetComponent<Chase>(), true);
        }
    }

    public static void RemoveAutoComponents()
    {
        if (SimpleAI.aiObject.GetComponent<UnityEngine.AI.NavMeshAgent>() != null)
        {
            DestroyImmediate(SimpleAI.aiObject.GetComponent<UnityEngine.AI.NavMeshAgent>(), true);
        }

        if (SimpleAI.aiObject.GetComponent<Rigidbody>() != null)
        {
            DestroyImmediate(SimpleAI.aiObject.GetComponent<Rigidbody>(), true);
        }

        if (SimpleAI.aiObject.GetComponent<NavMeshHandler>() != null)
        {
            DestroyImmediate(SimpleAI.aiObject.GetComponent<NavMeshHandler>(), true);
        }
    }
}
