using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad02 : MonoBehaviour
{
    int n;
    int m;
    // Start is called before the first frame update
    void Start()
    {

        while (n==10)
        {
          
            int m = 0;
            m++;
            print("Se han completado" + m++ +" ciclos.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        for (n = 0; n <= 10; n++)
        {
            print(n);

        }

    }
}
