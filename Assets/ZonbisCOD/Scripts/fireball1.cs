using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball1 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
