using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOperator : MonoBehaviour
{

    [SerializeField] private Vector3 dPos;
    private bool status;


    public void open()
    {
        if (status)
        {
            Vector3 pos = transform.position + dPos;
            transform.position = pos;
        }
        else
        {
            Vector3 pos = transform.position - dPos;
            transform.position = pos;
        }

        status = !status;

    }

    public void activate()
    {
        if (!status)
        {
            Vector3 pos = transform.position - dPos;
            transform.position = pos;
        }
        status = true;
    }

     public void deactivate()
    {
        {
            if (status)
            {
                Vector3 pos = transform.position + dPos;
                transform.position = pos;
            }
            status = false;

        }
    }
        
}
