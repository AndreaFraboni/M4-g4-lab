using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class ColorManager : MonoBehaviour
{
    public Color currentColor;
    private MeshRenderer _mr;

    private void Awake()
    {
        _mr = GetComponentInParent<MeshRenderer>();
    }

    // Setter
    public void SetCurrentColor(Color value)
    {
        currentColor = value;
        _mr.material.color = value;
    }

    private void Update()
    {
        _mr.material.color = currentColor;
    }

}
