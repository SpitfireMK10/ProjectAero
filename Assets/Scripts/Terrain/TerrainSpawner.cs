using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _terrainObjects;
    [SerializeField] private float _terrainZ;
    [SerializeField] private float _incrementValue;
    [SerializeField] private float _spawnLimit;

    public float CurrentTile;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Spawn();
    }

    private void Spawn()
    {
        if (CurrentTile <= _spawnLimit)
        {
            Instantiate(_terrainObjects[0], new Vector3(0, 0, _terrainZ), Quaternion.identity);
            _terrainZ += _incrementValue;
            CurrentTile++;
        }
    }
}

