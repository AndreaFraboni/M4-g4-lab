using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Istantiator2D : MonoBehaviour
{
    [SerializeField] private GameObject quadPrefab;
    [SerializeField] private int _row, _col;
    [SerializeField] private float _rowOffset, _colOffset;
    [SerializeField] private Vector3 startPosition;

    private void Start()
    {
        for (int x = 0; x < _row; x++)
        {
            for (int y = 0; y < _col; y++)
            {
                Vector3 position = startPosition + new Vector3(x * _rowOffset, y * _colOffset, 0);
                GameObject griglia = Instantiate(quadPrefab, transform);
                griglia.transform.position = position;
            }
        }
    }

}
