using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private GameObject projectileController;

    public GameObject projectil;
    public float Potencia;
    public Transform spawnPoint;
    private GameObject BolaDeFuego;

    public void Start()
    {
        projectileController = this.gameObject;
    }

    public void Fireball_created()
    {
        BolaDeFuego = Instantiate(projectil, spawnPoint);
        BolaDeFuego.GetComponent<Rigidbody>().useGravity = false;
    }
    public void Fireball_projectile()
    {
        BolaDeFuego.transform.SetParent(projectileController.transform);
        BolaDeFuego.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        BolaDeFuego.GetComponent<Rigidbody>().useGravity = true;
        BolaDeFuego.GetComponent<Rigidbody>().velocity = spawnPoint.transform.forward * Potencia;
    }
    public void Fireball_deleted()
    {
        Destroy(BolaDeFuego);
    }
}
