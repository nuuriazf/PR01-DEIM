using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad01 : MonoBehaviour
{
     // ejercicio 1: variables  
    [SerializeField] string nombre = "Nuria";
    [SerializeField] int numLives = 3;
    public float numEnergy = 10;
    [SerializeField] bool alive= true; 
    // Start is called before the first frame update
    void Start()
    {
        int numero2 = 4;
        int numero1 = 5;
        int resultadooperacion = numero2 + numero1;
        print ("El resultado de la suma es " + resultadooperacion);
        
        

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
