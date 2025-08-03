using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Unity Script (1 asset reference) | 0 references
public class TrashScript : MonoBehaviour
{
    public PlayerController playerController;
    // public Apple Apple;
    public float score = 0;
    public int position = 1;

    // Start is called before the first frame update
    // Unity Message | 0 references
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();

        // apple = GameObject.Find("Apple").GetComponent<Apple>();
    }

    // Update is called once per frame
    // Unity Message | 0 references
    void FixedUpdate()
    {
        // Debug.Log("FixedUpdate");
        // Transform: The current instance, Trash
        if (transform.position.z > 122) 
        {
            if (position==1){
                transform.position = new Vector3(transform.position.x, -100f, transform.position.z);
                position = 0;
            } else {
                transform.position += new Vector3(0, 0, -2);
            }
            // Hard mode
            // transform.position += new Vector3(0, 0, -5);
        }
        else 
        {
            // Destroy(gameObject);
            //  The initiate trash seems not useful. either hide it or move out from the screen.
            transform.position = new Vector3(transform.position.x, -100f, transform.position.z);
        }
    }

    // Unity Message | 0 references
    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log("Instance ID: " + gameObject.GetInstanceID());

        Debug.Log("OnTriggerEnter");
        if (other.CompareTag("Player")) 
        {
            playerController.score += 1;
            Debug.Log("score + 1");
            // Destroy(gameObject);
        }

        // if (other.CompareTag("Apple")) 
        // {
        //     Debug.Log("Apple + 1");
        //     // Destroy(other.gameObject);
        // }
    }
}