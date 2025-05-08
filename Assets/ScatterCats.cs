using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScatterCats : MonoBehaviour
{
    public GameObject[] catPrefabs;
    public Terrain terrain;      
    public int numberOfCats = 50;  

    void Start()
    {
        Scatter();
    }

    void Scatter()
    {
        TerrainData terrainData = terrain.terrainData;
        Vector3 terrainPos = terrain.transform.position;

        for (int i = 0; i < numberOfCats; i++)
        {
            // Random X and Z within terrain size
            float x = Random.Range(0, terrainData.size.x);
            float z = Random.Range(0, terrainData.size.z);

            // Get the Y height from the terrain
            float y = terrain.SampleHeight(new Vector3(x, 0, z)) + terrainPos.y;

            // Pick a random cat prefab
            GameObject cat = catPrefabs[Random.Range(0, catPrefabs.Length)];

            // Instantiate at world position
            Vector3 spawnPos = new Vector3(x + terrainPos.x, y, z + terrainPos.z);
            Instantiate(cat, spawnPos, Quaternion.identity);
        }
    }
}
