using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad02 : MonoBehaviour
{
    int n;
    int m= 0;
    // Start is called before the first frame update
    void Start()
    {
        for (n = 0; n <= 10; n++)
        {
            print(n);

        }
        while (m<20)
        {
          
            
            m++;
            print("Se han completado" + m +" ciclos.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    
    }
}
