using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawn : MonoBehaviour
{
    public GameObject[] Waves;
    // Start is called before the first frame update
    void Start()
    {
        GenerateWave();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateWave()
    {
        Instantiate(Waves[Random.Range(0, Waves.Length)], new Vector3(gameObject.transform.position.x, 0, 0), Quaternion.identity);
    }
}
