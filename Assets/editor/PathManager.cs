using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PathManager : Editor
{
    public static GameObject pathObject;

    public static bool switchColor;
    public static bool spawnPath;

    public static void PathGUISetup()
    {
        EditorGUILayout.LabelField("AI Path", EditorStyles.boldLabel);

        EditorGUILayout.Space();

        pathObject = (GameObject)EditorGUILayout.ObjectField("AI Path Object", pathObject, typeof(object), true);

        EditorGUILayout.Space();

        if(GUILayout.Button("Create Path Manually"))
        {
            pathObject.GetComponent<Collider>().enabled = true;
            pathObject.gameObject.tag = "Path";
            Instantiate(pathObject, new Vector3(0, 0, 0), Quaternion.identity);
        }

        EditorGUILayout.Space();

        GUIStyle on = new GUIStyle(GUI.skin.label);
        GUIStyle off = new GUIStyle(GUI.skin.label);

        if(GUILayout.Button("Create Path With Mouse"))
        {
            if(switchColor == true)
            {
                switchColor = false;
            }
            else if(switchColor == false)
            {
                switchColor = true;
            }
        }

        if (switchColor == true)
        {
            on.normal.textColor = Color.green;
            off.normal.textColor = Color.black;

            spawnPath = true;
        }
        else if (switchColor == false)
        {
            on.normal.textColor = Color.black;
            off.normal.textColor = Color.red;

            spawnPath = false;
        }

        GUILayout.BeginHorizontal();

        EditorGUILayout.Space();

        EditorGUILayout.LabelField("On", on);

        EditorGUILayout.Space();

        EditorGUILayout.LabelField("Off", off);

        GUILayout.EndHorizontal();
    }
}
