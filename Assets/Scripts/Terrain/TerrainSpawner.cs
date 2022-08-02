using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] terrainObjects;   //Include all terrain objects that you would like spawned in
    [SerializeField] private float incrementValue;          //This is the Z scale value that will be used to spawn the next tile at the correct distance to ensure seamless tile spawning
    [SerializeField] private float spawnLimit;              //This is the spawn limit of the number of tiles that can be included at any one time
        
    private float terrainZ;

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
        if (CurrentTile <= spawnLimit)
        {
            Instantiate(terrainObjects[0], new Vector3(0, 0, terrainZ), Quaternion.identity);
            terrainZ += incrementValue;
            CurrentTile++;
        }
    }
}

