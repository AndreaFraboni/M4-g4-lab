using UnityEngine;

public class CubeBuilder : MonoBehaviour
{
    [SerializeField] private GameObject CubePrefab;

    [SerializeField] private int _cubesize;
    [SerializeField] private float _spacing;

    [SerializeField] private Vector3 _startPosition;

    private void Start()
    {
        float startX = _startPosition.x - (_cubesize / 2);
        float startY = _startPosition.y - (_cubesize / 2);
        float startZ = _startPosition.z - (_cubesize / 2);

        for (int x = 0; x < _cubesize; x++)
        {
            for (int y = 0; y < _cubesize; y++)
            {
                for (int z = 0; z < _cubesize; z++)
                {
                    Vector3 position = new Vector3(startX + x * _spacing, startY + y * _spacing, startZ + z * _spacing);

                    if (x == 0 || y == 0 || z == 0 || x == _cubesize - 1 || y == _cubesize - 1 || z == _cubesize - 1)
                    {
                        GameObject cubematrix = Instantiate(CubePrefab, transform);
                        cubematrix.transform.position = position;
                    }
                }
            }
        }
    }
}
