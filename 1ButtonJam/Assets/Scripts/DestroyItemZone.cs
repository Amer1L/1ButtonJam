using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItemZone : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Player")
        {
            Destroy(collision.gameObject);
        }
    }
}
