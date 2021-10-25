using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cilindros : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform tf;

    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision objetoColision)
    {
        if(objetoColision.gameObject.tag == "Jugador") {
            tf.localScale = new Vector3(tf.localScale.x + 1, tf.localScale.y + 1, tf.localScale.z + 1);
        }
    }    
}