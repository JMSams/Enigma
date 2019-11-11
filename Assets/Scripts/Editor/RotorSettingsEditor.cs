using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEditorInternal;

namespace FallingSloth.Enigma
{
    [CustomEditor(typeof(RotorSettings))]
    public class RotorEditor : Editor
    {
        void OnEnable()
        {
            RotorSettings t = (RotorSettings)target;
            while (t.pairings.Count < 26)
                t.pairings.Add(Chars._);
            EditorUtility.SetDirty(t);
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            EditorGUILayout.PropertyField(serializedObject.FindProperty("turnoverPosition"));
            for (int i = 0; i < 26; i++)
            {
                EditorGUILayout.PropertyField(serializedObject.FindProperty("pairings").GetArrayElementAtIndex(i),
                                              new GUIContent(string.Format("{0} maps to:", (Chars)(i+1))));
            }
            serializedObject.ApplyModifiedProperties();
        }
    }
}