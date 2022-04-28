using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayerOnTheTouch : MonoBehaviour
{
    private void OnCollissionEnter(Collision collission)
    {
        Debug.Log("diskudfhsdiufh");


        if (collission.collider.GetComponent<Player>() != null)
        {
            Destroy(collission.gameObject);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>() != null)
        {
            Destroy(other.gameObject);
        }
    }
}
