using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[ExecuteAlways]
public class GameItem : MonoBehaviour
{
    public ThemeNexus themeNexus;
    public int itemIndex;
    public SpriteRenderer spriteRenderer;
    private void OnValidate()
    {
        ApplyReskin();
    }

    public void ApplyReskin()
    {
        if (themeNexus != null && itemIndex >= 0 && itemIndex < 7)
        {
            if (spriteRenderer != null && themeNexus!=null && themeNexus.itemReskinData != null)
            {
                spriteRenderer.sprite = themeNexus.itemReskinData.itemTextures[itemIndex];
            }
        }
    }
}
