using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{
    public float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        velocidad = 5;    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L)) {  
            transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * velocidad);  
        }

        if (Input.GetKey(KeyCode.J)) {  
            transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * velocidad);  
        }

        if (Input.GetKey(KeyCode.M)) {  
            transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime * velocidad);  
        }
          
        if (Input.GetKey(KeyCode.I)) {  
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * velocidad);  
        }  
    }
}
