using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SelectBehaviours : Editor
{
    public static bool wonder;
    public static bool lookAround;
    public static bool chase;
    public static bool playerDetection;

    public static void SelectComponents()
    {
        wonder = EditorGUILayout.Toggle("Wonder", wonder);

        using (new EditorGUI.DisabledScope(!wonder))
        {
            lookAround = EditorGUILayout.Toggle("LookAround", lookAround);
        }

        playerDetection = EditorGUILayout.Toggle("Player Detection", playerDetection);

        using (new EditorGUI.DisabledScope(!playerDetection))
        {
            chase = EditorGUILayout.Toggle("LookAround", chase);
        }

    }

}
