using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private TerrainGenerator terrainGenerator;
    [SerializeField] private Text scoreText;
    private int score; 

    private Animator animator;
    private bool isHopping;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
       score++;
    }

    private void Update()
    {

        scoreText.text = "Score: " + score;
        if (Input.GetKeyDown(KeyCode.W) && !isHopping)
        {
            Debug.Log("moving");

            float zDifference = 0;
            if (transform.position.z % 1 != 0)
            {
                zDifference = transform.position.z + Mathf.Round(transform.position.z) - transform.position.z;

            }
            MoveCharacter(new Vector3(1, 0, 0));
        }
        else if (Input.GetKeyDown(KeyCode.A) && !isHopping)
        {
            MoveCharacter(new Vector3(0, 0, 1));
        }
        else if (Input.GetKeyDown(KeyCode.D) && !isHopping)
        {
            MoveCharacter(new Vector3(0, 0, -1));
        }
    }

  private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<MovingObject>() != null)
        {
            Debug.Log("collide");
            if(collision.collider.GetComponent<MovingObject>().isLog)
            {
                Debug.Log("is log");

                transform.parent = collision.collider.transform;
            }
        }
        else
        {
            Debug.Log("nah");

            transform.parent = null;
        }
    }
 


    private void MoveCharacter(Vector3 difference)
    {
        animator.SetTrigger("hop");
        isHopping = true;
        transform.position = (transform.position + difference);

        terrainGenerator.SpawnTerrain(false, transform.position);

        transform.parent = null;
        /*if (transform.parent.transform.gameObject.tag == "Log")
        {
            Debug.Log("move");
            transform.parent = null;
        }*/
    }

    public void FinishHop()
    {
        isHopping = false;
    }

    
    public void Jump()
    {
        if (transform.parent.gameObject.tag == "Log")
        {
            transform.parent = null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Log")
        {
            transform.parent = other.transform;
        }
          
    }
} 

