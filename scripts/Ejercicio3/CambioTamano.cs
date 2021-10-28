using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioTamano : MonoBehaviour
{
    private GameObject jugador;
    private GameObject esfera;
    private Vector3 escalaInicial;

    // Start is called before the first frame update
    void Start()
    {
        jugador = null;
        esfera = null;
        escalaInicial = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    { 
        jugador = GameObject.FindWithTag("Jugador");
        esfera = GameObject.FindWithTag("Esfera");
        if (jugador == null || esfera == null) {
            return;
        }

        float distanciaJugador = Vector3.Distance(jugador.transform.position, transform.localPosition);
        float distanciaEsfera = Vector3.Distance(esfera.transform.position, transform.localPosition);

        transform.localScale = escalaInicial / distanciaEsfera;
        transform.localScale *= distanciaJugador;      
    }
}
