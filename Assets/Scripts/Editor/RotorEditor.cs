using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEditorInternal;

namespace FallingSloth.Enigma
{
    [CustomEditor(typeof(Rotor))]
    public class RotorEditor : Editor
    {
        ReorderableList list;

        void OnEnable()
        {
            list = new ReorderableList(serializedObject,
                                       serializedObject.FindProperty("pairings"),
                                       true, true, true, true);
            list.drawHeaderCallback = (rect) =>
            {
                GUI.Label(rect, "Letter Pairings");
            };
            list.elementHeightCallback = (index) =>
            {
                return (EditorGUIUtility.singleLineHeight * 2f);
            };
            list.drawElementCallback = (rect, index, isActive, isFocused) =>
            {
                GUI.Label(new Rect(rect.x, rect.y, rect.width / 3, rect.height), string.Format("Pair {0}", index+1));
                EditorGUI.PropertyField(new Rect(rect.x + rect.width/3, rect.y, rect.width * 0.666f, rect.height / 2),
                                        serializedObject.FindProperty("pairings").GetArrayElementAtIndex(index).FindPropertyRelative("char1"));
                EditorGUI.PropertyField(new Rect(rect.x + rect.width/3, rect.y + rect.height / 2, rect.width * 0.666f, rect.height / 2),
                                        serializedObject.FindProperty("pairings").GetArrayElementAtIndex(index).FindPropertyRelative("char2"));
            };

        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            EditorGUILayout.PropertyField(serializedObject.FindProperty("turnoverPosition"));
            list.DoLayoutList();
            serializedObject.ApplyModifiedProperties();
        }
    }
}