using UnityEngine;

public class SetColor : MonoBehaviour
{
    [SerializeField] private LayerMask _layerMask;
    [SerializeField] private float _maxDistance = 100f;
    [SerializeField] private ColorManager _cm;

    private MeshRenderer _mr;
    private Camera _mc;
    private Ray _ray;

    private float _hitPointRadius = 0.15f;

    private void Awake()
    {
        _mr = GetComponentInParent<MeshRenderer>();
        _cm = FindAnyObjectByType<ColorManager>();
        _mc = Camera.main;

        _layerMask = LayerMask.GetMask("QuadGrid");
    }

    void OnDrawGizmos()
    {
        if (_mc == null) return;

        Gizmos.color = Color.red;
        Gizmos.DrawRay(_ray.origin, _ray.direction * _maxDistance);

        if (Physics.Raycast(_ray, out RaycastHit hit, _maxDistance))
        {
            Gizmos.color = Color.green;
            Gizmos.DrawSphere(hit.point, _hitPointRadius);
        }
    }

    private void Update()
    {

        if (Input.GetMouseButton(0))
        {
            _ray = _mc.ScreenPointToRay(Input.mousePosition);

            Vector3 start = _ray.origin;
            Vector3 direction = _ray.direction;

            if (Physics.Raycast(start, direction, out RaycastHit hit, _maxDistance, _layerMask))
            {
                Renderer _hitRenderer = hit.collider.GetComponentInParent<Renderer>();
                _hitRenderer.material.color = _cm.currentColor;
            }
        }
        if (Input.GetMouseButton(1))
        {
            _ray = _mc.ScreenPointToRay(Input.mousePosition);

            Vector3 start = _ray.origin;
            Vector3 direction = _ray.direction;

            if (Physics.Raycast(start, direction, out RaycastHit hit, _maxDistance, _layerMask))
            {
                Renderer _hitRenderer = hit.collider.GetComponentInParent<Renderer>();
                _hitRenderer.material.SetColor("_BaseColor", Color.gray);
            }
        }
    }
}
