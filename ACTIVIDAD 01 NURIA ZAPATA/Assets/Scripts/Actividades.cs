using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividades : MonoBehaviour
{
     // ejercicio 1: variables  
    [SerializeField] string nombre = "Nuria";
    [SerializeField] int numLives = 3;
    public float numEnergy = 10;
    [SerializeField] bool alive= true; 
    // Start is called before the first frame update
    void Start()
    {
        print(numEnergy);
         numEnergy = 20;
        print(numEnergy);
        

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
