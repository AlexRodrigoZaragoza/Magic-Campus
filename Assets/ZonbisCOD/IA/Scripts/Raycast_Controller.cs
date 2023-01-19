using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast_Controller : MonoBehaviour
{
    public float range = 30f;

    public Camera cam;

    public bool Personaje1;
    public bool Personaje2;
    public bool Personaje3;
    public bool Personaje4;

    public GameObject personaje1;
    //public GameObject personaje2;
    //public GameObject personaje3;
    //public GameObject personaje4;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;


            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
            {
                Debug.Log(hit.collider.name);

                if (hit.collider.tag == "Personaje1")
                {
                    Personaje1 = true;
                    personaje1.SetActive(true);
                    //personaje2.SetActive(false);
                    //personaje3.SetActive(false);
                    //personaje4.SetActive(false);
                }
                else if (hit.collider.tag == "Personaje2")
                {
                    Personaje2 = true;
                    personaje1.SetActive(false);
                    //personaje2.SetActive(true);
                    //personaje3.SetActive(false);
                    //personaje4.SetActive(false);
                }
                else if (hit.collider.tag == "Personaje3")
                {
                    Personaje3 = true;
                    personaje1.SetActive(false);
                    //personaje2.SetActive(false);
                    //personaje3.SetActive(true);
                    //personaje4.SetActive(false);
                }
            }
        }

        Debug.DrawRay(cam.transform.position, cam.transform.forward, Color.red, 0.1f);
    }
}
