using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Collider : MonoBehaviour
{
    public PlayerController playerController;
    public float score = 0;

    // Start is called before the first frame update
    // Unity Message | 0 references
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    // Unity Message | 0 references
    void FixedUpdate()
    {
        // Debug.Log("FixedUpdate");
        if (transform.position.z > -250)
        {
            transform.position += new Vector3(0, 0, -3);
        }
        else
        {
            // Destroy(gameObject);
            //  The initiate trash seems not useful. either hide it or move out from the screen.
            // transform.position = new Vector3(transform.position.x, -100f, transform.position.z);
        }
    }

    // Unity Message | 0 references
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        playerController.score += 1;
    }
}
