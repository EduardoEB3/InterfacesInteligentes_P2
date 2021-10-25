using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCubo : MonoBehaviour
{
    /// Velocidad a la que se hará el movimiento
	public float velocidad;
    /// Como queremos hacer una operación que no es física, creamos el Transform para inicializarlo en el Start 
    /// y modificarlo en el Update
	private Transform tf;

    // Start is called before the first frame update
    void Start()
    {
        /// Inicializamos velocidad y tf
        velocidad = 0.0f;
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        /// Derecha o izquierda(Eje x)
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        /// Alante o atrás(Eje Z)
        float movimientoVertical = Input.GetAxis("Vertical");
		
        /// Creamos un Vector3 para saber cuánto se mueve en cada eje
		Vector3 movimiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical);
		
        /// Usamos Time.deltaTime para escalar los movimientos según el tiempo transcurrido(Tiempo real) y no por frame(Tiempo Físico).
		tf.Translate(movimiento * Time.deltaTime * velocidad);
    }
}
