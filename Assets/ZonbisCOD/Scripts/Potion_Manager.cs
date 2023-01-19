using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion_Manager : MonoBehaviour
{
    public bool Pollo, Calavera, Zanahoria, Zumo, Hierba, Raiz, Mezcla1, Mezcla2, Mezcla3;
    public List<bool> Conenidos = new List<bool>();

    public GameObject Pollo_go, Calavera_go, Zanahoria_go, Zumo_go, Hierba_go, Raiz_go, Canvas_Texto;
    public GameObject Potion_red, Potion_green, Potion_blue;

    public Vector3 Pollo_pos, Calavera_pos, Zanahoria_pos, Zumo_pos, Hierba_pos, Raiz_pos;
    private Vector3 posicion_spawn;

    public Quaternion Pollo_rot, Calavera_rot, Zanahoria_rot, Zumo_rot, Hierba_rot, Raiz_rot;

    public Transform origen_spawn;

    void Start()
    {
        Pollo_pos = Pollo_go.transform.position;
        Pollo_rot = Pollo_go.transform.rotation;
        Calavera_pos = Calavera_go.transform.position;
        Calavera_rot = Calavera_go.transform.rotation;
        Zanahoria_pos = Zanahoria_go.transform.position;
        Zanahoria_rot = Zumo_go.transform.rotation;
        Zumo_pos = Zumo_go.transform.position;
        Zumo_rot = Zumo_go.transform.rotation;
        Hierba_pos = Hierba_go.transform.position;
        Hierba_rot = Hierba_go.transform.rotation;
        Raiz_pos = Raiz_go.transform.position;
        Raiz_rot = Raiz_go.transform.rotation;

        posicion_spawn = new Vector3(origen_spawn.position.x, origen_spawn.position.y, origen_spawn.position.z);
    }

    void Update()
    {
        Crafting();

        if(Mezcla1 == true && Mezcla2 == true && Mezcla3 == true)
        {
            Mezcla1 = false;
            Mezcla2 = false;
            Mezcla3 = false;

            Debug.Log("Victoria");
            Canvas_Texto.SetActive(true);
            StartCoroutine(Victoria());
        }
    }

    public IEnumerator Victoria()
    {
        yield return new WaitForSeconds(5f);

        Canvas_Texto.SetActive(false);
    }


    void OnTriggerEnter(Collider ingrediente)
    {
         
        if (ingrediente.gameObject.tag == "Raiz")
        {
            Raiz = true;
            Debug.Log("Ingrediente Raiz añadido");
            Destroy(ingrediente.gameObject);
        }

        else if (ingrediente.gameObject.tag == "Calavera")
        {
            Calavera = true;
            Debug.Log("Ingrediente Calavera añadido");
            Destroy(ingrediente.gameObject);
        }

        else if (ingrediente.gameObject.tag == "Pollo")
        {
            Pollo = true;
            Debug.Log("Ingrediente Pollo añadido");
            Destroy(ingrediente.gameObject);
        }

        else if (ingrediente.gameObject.tag == "Hierba")
        {
            Hierba = true;
            Debug.Log("Ingrediente Hierba añadido");
            Destroy(ingrediente.gameObject);
        }

        else if (ingrediente.gameObject.tag == "Zanahoria")
        {
            Zanahoria = true;
            Debug.Log("Ingrediente Zanahoria añadido");
            Destroy(ingrediente.gameObject);
        }

        else if (ingrediente.gameObject.tag == "Zumo")
        {
            Zumo = true;
            Debug.Log("Ingrediente Zumo añadido");
            Destroy(ingrediente.gameObject);
        }
    }


    void Crafting()
    {
        if (Raiz == true && Calavera == true)
        {
            GameObject pocion;
            Raiz = false;
            Calavera = false;
            pocion = Instantiate(Potion_red);
            pocion.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.up * 4);
            pocion.transform.position = posicion_spawn;
            Debug.Log("Pocion Creada");
            Mezcla1 = true;

            Instantiate(Raiz_go, Raiz_pos, Raiz_rot);
            Instantiate(Calavera_go, Calavera_pos, Calavera_rot);
        }

        else if (Pollo == true && Hierba == true)
        {
            GameObject pocion;
            Pollo = false;
            Hierba = false;
            pocion = Instantiate(Potion_green);
            pocion.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.up * 4);
            pocion.transform.position = posicion_spawn;
            Debug.Log("Pocion Creada");
            Mezcla2 = true;

            Instantiate(Pollo_go, Pollo_pos, Pollo_rot);
            Instantiate(Hierba_go, Hierba_pos, Hierba_rot);
        }

        else if (Zanahoria == true && Zumo == true)
        {
            GameObject pocion;
            Zanahoria = false;
            Zumo = false;
            pocion = Instantiate(Potion_blue);
            pocion.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.up * 4);
            pocion.transform.position = posicion_spawn;
            Debug.Log("Pocion Creada");
            Mezcla3 = true;

            Instantiate(Zanahoria_go, Zanahoria_pos, Zanahoria_rot);
            Instantiate(Zumo_go, Zumo_pos, Zumo_rot);
        }

        #region Descartes

        if (Raiz == true && Pollo == true)
        {
            Raiz = false;
            Pollo = false;

            Instantiate(Raiz_go, Raiz_pos, Raiz_rot);
            Instantiate(Pollo_go, Pollo_pos, Pollo_rot);
        }

        if (Raiz == true && Hierba == true)
        {
            Raiz = false;
            Hierba = false;

            Instantiate(Raiz_go, Raiz_pos, Raiz_rot);
            Instantiate(Hierba_go, Hierba_pos, Hierba_rot);
        }

        if (Raiz == true && Zanahoria == true)
        {
            Raiz = false;
            Zanahoria = false;

            Instantiate(Raiz_go, Raiz_pos, Raiz_rot);
            Instantiate(Zanahoria_go, Zanahoria_pos, Zanahoria_rot);
        }

        if (Raiz == true && Zumo == true)
        {
            Raiz = false;
            Zumo = false;

            Instantiate(Raiz_go, Raiz_pos, Raiz_rot);
            Instantiate(Zumo_go, Zumo_pos, Zumo_rot);
        }

        if (Pollo == true && Raiz == true)
        {
            Pollo = false;
            Raiz = false;

            Instantiate(Pollo_go, Pollo_pos, Pollo_rot);
            Instantiate(Raiz_go, Raiz_pos, Raiz_rot);
        }

        if (Pollo == true && Zumo == true)
        {
            Pollo = false;
            Zumo = false;

            Instantiate(Pollo_go, Pollo_pos, Pollo_rot);
            Instantiate(Zumo_go, Zumo_pos, Zumo_rot);
        }

        if (Pollo == true && Zanahoria == true)
        {
            Pollo = false;
            Zanahoria = false;

            Instantiate(Pollo_go, Pollo_pos, Pollo_rot);
            Instantiate(Zanahoria_go, Zanahoria_pos, Zanahoria_rot);
        }

        if (Pollo == true && Calavera == true)
        {
            Pollo = false;
            Calavera = false;

            Instantiate(Pollo_go, Pollo_pos, Pollo_rot);
            Instantiate(Calavera_go, Calavera_pos, Calavera_rot);
        }

        if (Calavera == true && Pollo == true)
        {
            Calavera = false;
            Pollo = false;

            Instantiate(Calavera_go, Calavera_pos, Calavera_rot);
            Instantiate(Pollo_go, Pollo_pos, Pollo_rot);
        }

        if (Calavera == true && Zumo == true)
        {
            Calavera = false;
            Zumo = false;

            Instantiate(Calavera_go, Calavera_pos, Calavera_rot);
            Instantiate(Zumo_go, Zumo_pos, Zumo_rot);
        }

        if (Calavera == true && Zanahoria == true)
        {
            Calavera = false;
            Zanahoria = false;

            Instantiate(Calavera_go, Calavera_pos, Calavera_rot);
            Instantiate(Zanahoria_go, Zanahoria_pos, Zanahoria_rot);
        }

        if (Calavera == true && Hierba == true)
        {
            Calavera = false;
            Hierba = false;

            Instantiate(Calavera_go, Calavera_pos, Calavera_rot);
            Instantiate(Hierba_go, Hierba_pos, Hierba_rot);
        }

        if (Hierba == true && Raiz == true)
        {
            Hierba = false;
            Raiz = false;

            Instantiate(Hierba_go, Hierba_pos, Hierba_rot);
            Instantiate(Raiz_go, Raiz_pos, Raiz_rot);
        }

        if (Hierba == true && Zumo == true)
        {
            Hierba = false;
            Zumo = false;

            Instantiate(Hierba_go, Hierba_pos, Hierba_rot);
            Instantiate(Zumo_go, Zumo_pos, Zumo_rot);
        }

        if (Hierba == true && Zanahoria == true)
        {
            Hierba = false;
            Zanahoria = false;

            Instantiate(Hierba_go, Hierba_pos, Hierba_rot);
            Instantiate(Zanahoria_go, Zanahoria_pos, Zanahoria_rot);
        }

        if (Hierba == true && Calavera == true)
        {
            Hierba = false;
            Calavera = false;

            Instantiate(Hierba_go, Hierba_pos, Hierba_rot);
            Instantiate(Calavera_go, Calavera_pos, Calavera_rot);
        }

        if (Zanahoria == true && Calavera == true)
        {
            Zanahoria = false;
            Calavera = false;

            Instantiate(Zanahoria_go, Zanahoria_pos, Zanahoria_rot);
            Instantiate(Calavera_go, Calavera_pos, Calavera_rot);
        }

        if (Zanahoria == true && Hierba == true)
        {
            Zanahoria = false;
            Hierba = false;

            Instantiate(Zanahoria_go, Zanahoria_pos, Zanahoria_rot);
            Instantiate(Hierba_go, Hierba_pos, Hierba_rot);
        }

        if (Zanahoria == true && Raiz == true)
        {
            Zanahoria = false;
            Raiz = false;

            Instantiate(Zanahoria_go, Zanahoria_pos, Zanahoria_rot);
            Instantiate(Raiz_go, Raiz_pos, Raiz_rot);
        }

        if (Zanahoria == true && Pollo == true)
        {
            Zanahoria = false;
            Pollo = false;

            Instantiate(Zanahoria_go, Zanahoria_pos, Zanahoria_rot);
            Instantiate(Pollo_go, Pollo_pos, Pollo_rot);
        }

        if (Zumo == true && Pollo == true)
        {
            Zumo = false;
            Pollo = false;

            Instantiate(Zumo_go, Zumo_pos, Zumo_rot);
            Instantiate(Pollo_go, Pollo_pos, Pollo_rot);
        }

        if (Zumo == true && Calavera == true)
        {
            Zumo = false;
            Calavera = false;

            Instantiate(Zumo_go, Zumo_pos, Zumo_rot);
            Instantiate(Calavera_go, Calavera_pos, Calavera_rot);
        }

        if (Zumo == true && Hierba == true)
        {
            Zumo = false;
            Hierba = false;

            Instantiate(Zumo_go, Zumo_pos, Zumo_rot);
            Instantiate(Hierba_go, Hierba_pos, Hierba_rot);
        }

        if (Zumo == true && Raiz == true)
        {
            Zumo = false;
            Raiz = false;

            Instantiate(Zumo_go, Zumo_pos, Zumo_rot);
            Instantiate(Raiz_go, Raiz_pos, Raiz_rot);
        }
        #endregion
    }


}
