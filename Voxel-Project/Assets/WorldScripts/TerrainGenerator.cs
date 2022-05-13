using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{

    public BiomeGenerator biomeGenerator;

    public ChunkData GenerateChunkData(ChunkData data, Vector2Int mapSeedOffset)
    {

        //For each z and z position, we need to generate individual noise value with perlin noise function
        for (int x = 0; x < data.chunkSize; x++)
        {
            for (int z = 0; z < data.chunkSize; z++)
            {
                //To process each voxel, we will use our BiomeGenerator class
                data = biomeGenerator.ProcessChunkColumn(data, x, z, mapSeedOffset);
            }
            
        }
        return data;
    }
}
