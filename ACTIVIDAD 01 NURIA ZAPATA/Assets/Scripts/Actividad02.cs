using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad02 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        int m = 0;
        int n;
        for (n = 0; n <= 10; n++)
        {
           
            print(n);
            if (n == 10)
            {
                m++;
                print("Se han completado " + m++ + " ciclos.");
            }

        }

    
      
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
