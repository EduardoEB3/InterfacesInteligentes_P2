using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlejarCilindros : MonoBehaviour
{
    private GameObject jugador;
    private Rigidbody rb;
    public float fuerza;
    public float distanciaPorDefecto;

    // Start is called before the first frame update
    void Start()
    {
        jugador = null;
        rb = GetComponent<Rigidbody>();
        fuerza = 5;
        distanciaPorDefecto = 100;
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
        float distancia = Vector3.Distance(transform.position, jugador.transform.position);
        if (distancia < distanciaPorDefecto) {
            rb.AddForce((transform.position - jugador.transform.position) * fuerza);
        }
    }
}
