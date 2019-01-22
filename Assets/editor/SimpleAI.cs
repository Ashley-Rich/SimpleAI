using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SimpleAI : EditorWindow
{
    public static GameObject aiObject;

    private bool switchColor;

    [MenuItem("Tools/SimpleAI")]
    public static void ShowWindow()
    {
        GetWindow<SimpleAI>("SimpleAI");
    }

    public void update()
    {
        Handles.BeginGUI();
        Handles.color = Color.black;
        Handles.DrawLine(new Vector3(0, 0), new Vector3(300, 300));
        Handles.EndGUI();

    }

    public void OnGUI()
    {
        EditorGUILayout.Space();

        aiObject = (GameObject)EditorGUILayout.ObjectField("AI Object", aiObject, typeof(object), true);

        EditorGUILayout.LabelField("AI Behaviour Scripts", EditorStyles.boldLabel);

        EditorGUILayout.Space();

        SelectBehaviours.SelectComponents();

        EditorGUILayout.Space();

        if(GUILayout.Button("Attach Behaviour Scripts"))
        {
            AttachComponents.AttachScripts();
            AttachComponents.AutoAttachComponents();
        }

        EditorGUILayout.Space();

        if(GUILayout.Button("Remove All Components"))
        {
            RemoveComponents.RemoveScripts();
            RemoveComponents.RemoveAutoComponents();
        }

        EditorGUILayout.Space();

        if(GUILayout.Button("Create AI"))
        {
            Instantiate(aiObject, new Vector3(0, 0, 0), Quaternion.identity);
            aiObject.name = "AI";
        }

        EditorGUILayout.Space();

        DrawLine();

        EditorGUILayout.Space();

        PathManager.PathGUISetup();
    }

    public void DrawLine(int height = 2)
    {
        Rect rect = EditorGUILayout.GetControlRect(false, height);

        rect.height = height;

        EditorGUI.DrawRect(rect, new Color(0.5f, 0.5f, 0.5f, 1));
    }
}
