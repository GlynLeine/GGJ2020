using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(RepairableFactory))]
public class RepairableFactoryEditor : Editor
{
    RepairableFactory factory;

    string keyToAdd;

    public override void OnInspectorGUI()
    {
        if (factory == null)
            factory = target as RepairableFactory;
        DrawDefaultInspector();

        for (int i = 0; i < factory.keys.Count; i++)
        {
            EditorGUILayout.LabelField("item " + i.ToString());
            EditorGUI.indentLevel++;
            factory.keys[i] = EditorGUILayout.TextField("Key", factory.keys[i]);
            if (i >= factory.repairables.Count)
                factory.repairables.Add(null);
            factory.repairables[i] = EditorGUILayout.ObjectField("Value", factory.repairables[i], typeof(Repairable), false) as Repairable;
            EditorGUI.indentLevel--;

        }

        EditorGUILayout.LabelField("");

        keyToAdd = EditorGUILayout.TextField("Operation key", keyToAdd);

        if (GUILayout.Button("Add Item"))
        {
            factory.keys.Add(keyToAdd);
            keyToAdd = "";
            factory.repairables.Add(null);
        }
        if(GUILayout.Button("RemoveItem"))
        {
            int index = factory.keys.IndexOf(keyToAdd);
            if(index >= 0)
            {
                factory.keys.RemoveAt(index);
                factory.repairables.RemoveAt(index);
                keyToAdd = "";
            }
        }
    }

}
