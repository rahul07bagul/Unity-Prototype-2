using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameOverScreen gameOverScreen = new GameOverScreen();
    public GameObject[] animalPrefabs;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimals",startDelay,spawnInterval);
    }

    void SpawnRandomAnimals(){
        if(!gameOverScreen.isGameOver){
            int animalIndex = Random.Range(0,animalPrefabs.Length);
            Vector3 spawnPosition = new Vector3(Random.Range(-20,20),0,20);
            Instantiate(animalPrefabs[animalIndex],spawnPosition,animalPrefabs[animalIndex].transform.rotation);
        }else{
            Destroy(gameObject);
        }
    }
}
