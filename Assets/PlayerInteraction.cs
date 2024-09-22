using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInteraction : MonoBehaviour
{
    public float radius = 1.5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Collider[] hitColliders;
            hitColliders = Physics.OverlapSphere(transform.position, radius);
            foreach (Collider hitCollider in hitColliders)
            {
                hitCollider.SendMessage("open", SendMessageOptions.DontRequireReceiver);
            }

        }
    }
}
