using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ThemeNexus))]
public class ThemeNexusEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        ThemeNexus themeNexus = (ThemeNexus)target;

        if (GUI.changed)
        {
            GameItem[] gameItems = FindObjectsOfType<GameItem>();
            foreach (GameItem gameItem in gameItems)
            {
                if (gameItem.themeNexus == themeNexus)
                {
                    gameItem.ApplyReskin();
                    EditorUtility.SetDirty(gameItem);
                }
            }
        }
    }
}