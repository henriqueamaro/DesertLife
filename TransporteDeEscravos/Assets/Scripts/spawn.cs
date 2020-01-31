using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject carro;
    float timer = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >=3)
        {
            Instantiate(carro, this.transform.position, this.transform.rotation);
            timer = 0;
        }
    }
}
