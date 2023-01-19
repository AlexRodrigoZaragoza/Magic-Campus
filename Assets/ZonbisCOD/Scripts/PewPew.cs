using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PewPew : MonoBehaviour
{
    private LineRenderer rendo;

    // Start is called before the first frame update
    void Start()
    {
        rendo = gameObject.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider)
            {
                rendo.SetPosition(1, new Vector3(0, 0, hit.distance));
            }
            else
            {
                rendo.SetPosition(1, new Vector3(0, 0, 5000));
            }
        }
    }
}
