using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{

    public float Potencia = 50;

    public GameObject Fireball;
    public Transform Disparador;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //AQUI HABRIA QUE PONER LO DE LOS GESTOS DE LA MANO, 
        /*
        if() 
        {
            Debug.Log("PULSADO");
            GameObject BolaDeFuego = Instantiate(Fireball);
            BolaDeFuego.GetComponent<Rigidbody>().velocity = Disparador.transform.up * Potencia;
        }
        */
        
    }


}
