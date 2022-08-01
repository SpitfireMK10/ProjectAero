using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainDestroyer : MonoBehaviour
{
    public TerrainSpawner TerrainSpawner;
    void Awake()
    {
        TerrainSpawner = FindObjectOfType<TerrainSpawner>();
    }
    private void OnDestroy()
    {
        TerrainSpawner.CurrentTile--;
    }
}
