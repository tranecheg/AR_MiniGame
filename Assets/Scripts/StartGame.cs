using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject spawn;
    public void playGame()
    {
        spawn.GetComponent<SpawnCubes>().enabled = true;
        Gaming.isInGame = true;
        gameObject.SetActive(false);
    }
}
