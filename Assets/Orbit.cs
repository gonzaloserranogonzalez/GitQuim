using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacionElectron : MonoBehaviour
{  
    float timeCounter=0;
    float speed;
    Vector3 posicion;
    float radio;

    // Start is called before the first frame update
    void Start()
    {
        speed = 1;
        posicion=GameObject.Find("Electron").transform.position;
        Debug.Log(posicion.x);
        Debug.Log(posicion.y);
        Debug.Log(posicion.z);
        radio = 1;
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime;
        float x = Mathf.Cos(timeCounter)*radio;
        float y = Mathf.Sin(timeCounter)*radio;
        float z = 0;
        transform.position= new Vector3 (posicion.x+x, posicion.y+y,posicion.z+z);
    }
}