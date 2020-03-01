using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern1 : MonoBehaviour
{
    public GameObject Obstaculo;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Obstaculo, transform.position, Quaternion.identity);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
