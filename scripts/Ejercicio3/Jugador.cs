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
        velocidad = 5;
        contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.A)) {
            rb.MovePosition(rb.position + new Vector3(-1, 0, 0) * Time.fixedDeltaTime * velocidad);
        }

        if(Input.GetKey(KeyCode.D)) {
            rb.MovePosition(rb.position + new Vector3(1, 0, 0) * Time.fixedDeltaTime * velocidad);
        }

        if(Input.GetKey(KeyCode.S)) {
            rb.MovePosition(rb.position + new Vector3(0, 0, -1) * Time.fixedDeltaTime * velocidad);
        }

        if(Input.GetKey(KeyCode.W)) {
            rb.MovePosition(rb.position + new Vector3(0, 0, 1) * Time.fixedDeltaTime * velocidad);
        }
    }

    void OnCollisionEnter(Collision objetoColision) 
    {
        if(objetoColision.gameObject.tag == "Cilindro") { 
            contador++;
        }
    }
}
