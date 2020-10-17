using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public string direction;
    public GameObject car;
    List<GameObject> spawnPoints = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CarSpawnCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CarSpawnCoroutine() {
        while(true) {
            int random = Random.Range(1, 9);
            Vector3 spawnPoint = new Vector3(spawnPoints[random].transform.position.x, spawnPoints[random].transform.position.y, spawnPoints[random].transform.position.z);
            GameObject newCar = Instantiate(car);
            newCar.transform.position = spawnPoint;
            
            random = Random.Range(1, 9);
            spawnPoint = new Vector3(spawnPoints[random].transform.position.x, spawnPoints[random].transform.position.y, spawnPoints[random].transform.position.z);
            newCar = Instantiate(car);
            newCar.transform.position = spawnPoint;

            yield return new WaitForSeconds(5);
        }
    }
}