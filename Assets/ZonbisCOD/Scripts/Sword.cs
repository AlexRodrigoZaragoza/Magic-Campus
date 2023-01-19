using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public static bool hasCollision;
    public Vector3 startPosition;
    //public Vector3 lastPosition;

    private void Awake()
    {
        this.GetComponentInParent<Transform>().position = startPosition;
    }
    private void Start()
    {
        transform.position = new Vector3(startPosition.x, startPosition.y, startPosition.z);
    }
    private void OnCollisionEnter(Collision collision)
    {
        hasCollision = true;
    }
    private void Update()
    {
        if (hasCollision == true)
        {
            transform.position = startPosition;
        }
    }
}
