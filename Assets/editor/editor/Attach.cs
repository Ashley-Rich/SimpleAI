using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Attach : Editor
{
    public SimpleAI simpleAI;

    public void AttachScripts()
    {
       //foreach(MonoScript mono in simpleAI.behaviourScripts)
       // {
       //     simpleAI.aiObject.AddComponent(mono);
       // }
    }
}
