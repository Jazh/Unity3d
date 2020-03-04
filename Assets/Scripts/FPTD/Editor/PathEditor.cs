using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEditor;
namespace FPTD
{
    [UnityEditor.CustomEditor(typeof(Path))]
    public class PathEditor : Editor
{
        Path myPath;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            myPath = (Path)target;

            if (GUILayout.Button("Click")) {
                myPath.GenerateNodes();
            }
        }
    }
}