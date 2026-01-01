using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    [SerializeField] private ColorManager _cm;
    private MeshRenderer _mr;

    private void Awake()
    {
        _mr = GetComponentInParent<MeshRenderer>();
        _cm = FindAnyObjectByType<ColorManager>();
    }

    void OnMouseDown()
    {
        _cm.SetCurrentColor(_mr.material.color);
    }
}
