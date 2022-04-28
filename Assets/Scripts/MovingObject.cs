using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    [SerializeField] private float speed;
    public bool isLog;

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    /*public void OnTriggerEnter(Collider tree)
    {
        Debug.Log("test");
        if (tree.gameObject.tag == "Player")
        {
            tree.transform.parent = transform;
        }
    }*/


}
