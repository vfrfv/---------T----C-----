using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovingCar : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.TryGetComponent<Quad>(out Quad quad))
        {
            Destroy(gameObject);
        }
    }
}
