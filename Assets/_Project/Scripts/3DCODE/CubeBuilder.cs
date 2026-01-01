using UnityEngine;

public class CubeBuilder : MonoBehaviour
{
    [SerializeField] private GameObject CubePrefab;

    [SerializeField] private int _row, _col, _depth;
    [SerializeField] private float _spacing;

    [SerializeField] private Vector3 _startPosition;

    private void Start()
    {
        float startX = _startPosition.x - (_row / 2);
        float startY = _startPosition.y - (_col / 2);
        float startZ = _startPosition.z - (_depth / 2);

        for (int x = 0; x < _row; x++)
        {
            for (int y = 0; y < _col; y++)
            {
                for (int z = 0; z < _depth; z++)
                {
                    Vector3 position = new Vector3(startX + x * _spacing, startY + y * _spacing, startZ + z * _spacing);

                    if (x == 0 || y == 0 || z == 0 || x == _row - 1 || y == _col - 1 || z == _depth - 1)
                    {
                        GameObject cubematrix = Instantiate(CubePrefab, transform);
                        cubematrix.transform.position = position;
                    }
                }
            }
        }
    }
}
