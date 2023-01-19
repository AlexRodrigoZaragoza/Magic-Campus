using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdoll : MonoBehaviour
{
    //[SerializeField] private Animator animator;

    public Rigidbody[] rigidbodies;
    public bool ragdoll = false;
    //public GameObject Canvas;

    void Start()
    {
        rigidbodies = transform.GetComponentsInChildren<Rigidbody>();
        SetEnabled(false);
        
    }

    void SetEnabled(bool enabled)
    {
        bool isKinematic = !enabled;
        foreach (Rigidbody rigidbody in rigidbodies)
        {
            rigidbody.isKinematic = isKinematic;
        }

        //animator.enabled = !enabled;
        //Canvas.SetActive(false);
    }

    void Update()
    {
        if (ragdoll == true)
        {
            SetEnabled(true);
        }
        if (ragdoll == false)
        {
            SetEnabled(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        SetEnabled(true);
        foreach (Rigidbody rigidbody in rigidbodies)
        {
            rigidbody.velocity = transform.up * 2f;
        }
    }
}
