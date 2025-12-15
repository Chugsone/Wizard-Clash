using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

#if UNITY_EDITOR
[CustomEditor(typeof(DeckManager))]
public class DeckManagerEditor : Editor
{
    // allow user to pick a HandManager in the scene from the inspector
    private HandManager selectedHandManager;

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        DeckManager deckManager = (DeckManager)target;
        if (GUILayout.Button("Draw Next Card"))
        {
            HandManager handManager = FindAnyObjectByType<HandManager>();
            if (handManager != null)
            {
                deckManager.DrawCard(handManager);
            }
        }
    }
}
#endif