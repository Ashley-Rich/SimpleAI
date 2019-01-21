using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SimpleAI : EditorWindow
{
    Attach attach;

    public GameObject aiObject;


    private bool switchColor;

    [MenuItem("Tools/SimpleAI")]
    public static void ShowWindow()
    {
        GetWindow<SimpleAI>("SimpleAI");
    }

    public void OnGUI()
    {
        aiObject = (GameObject)EditorGUILayout.ObjectField("AI Object", aiObject, typeof(object), true);

        EditorGUILayout.LabelField("AI Behaviour Scripts", EditorStyles.boldLabel);

        EditorGUILayout.Space();

        SelectBehaviours.SelectComponents();

        if(GUILayout.Button("Attach Behaviour Scripts"))
        {
            attach.AttachComponents(); 
        }

        EditorGUILayout.Space();

        if(GUILayout.Button("Create AI"))
        {
            Instantiate(aiObject, new Vector3(0, 0, 0), Quaternion.identity);
            aiObject.name = "AI";
        }
    }
}
