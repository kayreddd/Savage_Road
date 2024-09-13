using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawners;
    public GameObject[] cars;
    // Start is called before the first frame update
    public void Spawn (){
        Transform spawn = spawners[Random.Range(0,spawners.Length)];
        Instantiate(cars[Random.Range(0,cars.Length)], spawn);
    }
    void Start()
    {
        
    }

    // Update is called once per frame  
    private float timer = 0f;
    public float spawnInterval = 1f;  
    void Update()
    {
        // Incrémenter le compteur de temps
        timer += Time.deltaTime;

        // Si le temps écoulé est supérieur ou égal à l'intervalle de spawn
        if (timer >= spawnInterval)
        {
            // Appeler la méthode Spawn et réinitialiser le compteur
            Spawn();
            timer = 0f;
        }
    }
}
