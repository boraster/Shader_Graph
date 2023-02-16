using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightObject : MonoBehaviour
{
    private MeshRenderer rend;
    private Material mat;
    


    private void OnMouseOver()
    {
        mat.SetFloat("_Enable_Highlight", 1.0f);
    }

    private void OnMouseExit()
    {
        mat.SetFloat("_Enable_Highlight", 0.0f);
    }

    private void Awake()
    {
        rend = GetComponentInChildren<MeshRenderer>();
        mat = rend.material;
    }

    

    
}
