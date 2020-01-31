using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roda : MonoBehaviour
{
    
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.left * 0.25f);  
    }
}
