using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    public Rigidbody rb;
    public float velocidad;
    public int contadorCubo;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        velocidad = 100;
        contadorCubo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.I)) {
            rb.AddForce(new Vector3(0, 0, 1) * velocidad);
        }

        if(Input.GetKey(KeyCode.M)) {
            rb.AddForce(new Vector3(0, 0, -1) * velocidad);
        }

        if(Input.GetKey(KeyCode.L)) {
            rb.AddForce(new Vector3(1, 0, 0) * velocidad);
        }

        if(Input.GetKey(KeyCode.J)) {
            rb.AddForce(new Vector3(-1, 0, 0) * velocidad);
        }
    }

    void OnCollisionEnter(Collision objetoColision)
    {
        if(objetoColision.gameObject.tag == "Jugador" || objetoColision.gameObject.tag == "Cilindro") { 
            contadorCubo++;
        }

    }
}