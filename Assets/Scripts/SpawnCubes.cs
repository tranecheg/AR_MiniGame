using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubes : MonoBehaviour
{
    public GameObject cubePref;
    public int minCubes = 1, maxCubes = 5;

    private void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        while (true){
            int countCubes = Random.Range(minCubes, maxCubes);
            GameObject spawnCube = null;
            Vector3 pos = transform.position;
            for(int i = 0; i < countCubes; i++)
            {
                if (i > 0)
                {
                    pos = new Vector3(spawnCube.transform.position.x, spawnCube.transform.position.y, spawnCube.transform.position.z + 0.9f); ;
                }

                spawnCube = Instantiate(cubePref, pos, Quaternion.identity);
            }
            float sec = 4.2f;
            switch (countCubes)
            {
                case 1: sec = 2f; break;
                case 2: sec = 2.8f; break;
                case 3: sec = 3.3f; break;
                case 4: sec = 3.7f; break;
            }
            yield return new WaitForSeconds(sec);
        }
    }
}
