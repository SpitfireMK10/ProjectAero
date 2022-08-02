using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainCleaner : MonoBehaviour
{
    [SerializeField] private string terrainTag;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == terrainTag)
        {
            Destroy(other.gameObject);
        }
    }


}
