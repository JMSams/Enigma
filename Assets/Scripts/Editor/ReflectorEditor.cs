using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace FallingSloth.Enigma
{
    [CustomEditor(typeof(Reflector))]
    public class ReflectorEditor : Editor
    {
        void OnEnable()
        {
            Reflector t = (Reflector)target;
            while (t.pairings.Count < 13)
                t.pairings.Add(new CharacterPairing((Chars)(t.pairings.Count+1), Chars._));
            EditorUtility.SetDirty(t);
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            for (int i = 0; i < 13; i++)
            {
                GUILayout.BeginHorizontal();
                GUILayout.Label(string.Format("Character pairing {0:d2}:", i));
                GUILayout.BeginVertical();
                EditorGUILayout.PropertyField(serializedObject.FindProperty("pairings").GetArrayElementAtIndex(i).FindPropertyRelative("char1"),
                                              new GUIContent("char 1:"));
                EditorGUILayout.PropertyField(serializedObject.FindProperty("pairings").GetArrayElementAtIndex(i).FindPropertyRelative("char2"),
                                              new GUIContent("char 2:"));
                GUILayout.EndVertical();
                GUILayout.EndHorizontal();
                EditorGUILayout.Separator();
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}
