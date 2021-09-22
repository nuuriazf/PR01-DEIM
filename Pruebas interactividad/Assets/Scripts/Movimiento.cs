using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField] Vector3 playerposition = new Vector3(0f, 0f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        transform.position = playerposition; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
