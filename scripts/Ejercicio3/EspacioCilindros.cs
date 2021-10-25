using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspacioCilindros : MonoBehaviour
{
    private GameObject jugador;
    private Rigidbody rb;
    public float fuerza;

    // Start is called before the first frame update
    void Start()
    {
        jugador = null;
        rb = GetComponent<Rigidbody>();
        fuerza = 100;
    }
    
    // Update is called once per frame
    void Update() 
    {

    }

    // Update is called once per frame
    void FixedUpdate() 
    {
        jugador = GameObject.FindWithTag("Jugador");
        if (jugador == null) {
            return;
        }
        
        if (Input.GetKeyDown("space")) {
            rb.AddForce(new Vector3(1.0f, 1.0f, -1.0f) * fuerza);
        }
    }
}
