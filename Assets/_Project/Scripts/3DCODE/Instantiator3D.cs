using UnityEngine;

public class Instantiator : MonoBehaviour
{
    [SerializeField] private GameObject CubePrefab;

    [SerializeField] private int _row, _col, _depth;
    [SerializeField] private float _offsetX, _offsetY, _offsetZ;

    [SerializeField] private Vector3 _startPosition;

    private void Start()
    {
        for (int x = 0; x < _row; x++)
        {
            for (int y = 0; y < _col; y++)
            {
                for (int z = 0; z < _depth; z++)
                {
                    Vector3 position = _startPosition + new Vector3(x * _offsetX, y * _offsetY, z * _offsetZ);

                    if (x == 0)
                    {
                        GameObject cubematrix = Instantiate(CubePrefab, transform);
                        cubematrix.transform.position = position;
                    }
                    if (y == 0)
                    {
                        GameObject cubematrix = Instantiate(CubePrefab, transform);
                        cubematrix.transform.position = position;
                    }
                    if (z == 0)
                    {
                        GameObject cubematrix = Instantiate(CubePrefab, transform);
                        cubematrix.transform.position = position;
                    }
                    if (x == _row-1)
                    {
                        GameObject cubematrix = Instantiate(CubePrefab, transform);
                        cubematrix.transform.position = position;
                    }
                    if (y == _col-1)
                    {
                        GameObject cubematrix = Instantiate(CubePrefab, transform);
                        cubematrix.transform.position = position;
                    }
                    if (z == _depth-1)
                    {
                        GameObject cubematrix = Instantiate(CubePrefab, transform);
                        cubematrix.transform.position = position;
                    }
                }
            }
        }
    }

}