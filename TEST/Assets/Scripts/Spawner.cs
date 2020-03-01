using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] ObstaculoPatron;
    private float TiempoEntreSpawn;
    public float startTimeEntreSpawn;

    public float decrementoTiempo;
    public float minTime = 0.65f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TiempoEntreSpawn <= 0)
        {
            int random = Random.Range(0, ObstaculoPatron.Length);
            Instantiate(ObstaculoPatron[random], transform.position, Quaternion.identity);
            TiempoEntreSpawn = startTimeEntreSpawn;
            if(startTimeEntreSpawn> minTime)
            {
            startTimeEntreSpawn -= decrementoTiempo;
            }
        }
        else
        {
            TiempoEntreSpawn -= Time.deltaTime; 
        }
    }


}
