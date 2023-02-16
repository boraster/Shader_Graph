using UnityEngine;

public class HoverColor : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    [SerializeField]
    private Material originalMaterial;

    [SerializeField]
    private Material highlightedMaterial;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = originalMaterial;
    }

    public void ToggleHover(bool onOff)
    {
        if (meshRenderer != null && originalMaterial != null && highlightedMaterial != null)
        { 
            meshRenderer.material = onOff ? highlightedMaterial : originalMaterial;
        }
    }

    private void OnMouseOver()
    {
        ToggleHover(true);
    }

    private void OnMouseExit()
    {
        ToggleHover(false);
    }

}