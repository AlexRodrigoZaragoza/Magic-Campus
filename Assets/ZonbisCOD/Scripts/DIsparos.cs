using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DIsparos : MonoBehaviour
{

    public Ragdoll ragdoll;
    public Collider collider;
    // Start is called before the first frame update
    void Start()
    {
        collider.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Laser" || collision.gameObject.tag == "Fireball")
        {
            collider.enabled = false;
            ragdoll.ragdoll = true;
            Debug.Log("Hited");
        }
    }
}
