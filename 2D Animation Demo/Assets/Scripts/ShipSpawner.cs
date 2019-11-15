using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSpawner : MonoBehaviour
{
    public GameObject ship1;
    public GameObject ship2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnShip());
    }

    IEnumerator SpawnShip()
    {
        yield return new WaitForSeconds(2);
        while (true)
        {
            bool spawnShip1 = Random.value > 0.5f;
            Vector3 spawnPosition = new Vector3(spawnShip1 ? 100 : -100, Random.Range(-5.0f, 5.0f), 0);
            Instantiate(spawnShip1 ? ship1 : ship2, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(2);   
        }
    }
}
