using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{

    public Rigidbody rb;
    public float velocidad;
    public int contador;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        velocidad = 100;
        contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.A)) {
            rb.AddForce(new Vector3(-1, 0, 0) * velocidad);
        }

        if(Input.GetKey(KeyCode.D)) {
            rb.AddForce(new Vector3(1, 0, 0) * velocidad);
        }

        if(Input.GetKey(KeyCode.S)) {
            rb.AddForce(new Vector3(0, 0, -1) * velocidad);
        }

        if(Input.GetKey(KeyCode.W)) {
            rb.AddForce(new Vector3(0, 0, 1) * velocidad);
        }
    }

    void OnCollisionEnter(Collision objetoColision) 
    {
        if(objetoColision.gameObject.tag == "Cilindro") { 
            contador++;
        }
    }
}
