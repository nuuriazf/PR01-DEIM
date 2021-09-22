using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform playerPosition;
    [SerializeField] float disSeparacion= 3.5f;
    [SerializeField] float alturaCamara = 1.5f;
    Vector3 cameraPosition;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(playerPosition);

        float newPosY = playerPosition.position.y + alturaCamara;
        float newPosZ = playerPosition.position.z + disSeparacion;
        cameraPosition = new Vector3(0f, newPosY, newPosZ);
        transform.position= cameraPosition;


    }
}
