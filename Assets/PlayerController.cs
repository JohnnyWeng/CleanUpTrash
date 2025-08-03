/**
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 30f;
    public float score = 0f;
    public TextMeshProUGUI scoreText;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        // if(scoreText == null)
        // {
        //     Debug.Log("scoreText is null");
        // } else {
        //     Debug.Log("scoreText is NOT null");
        // }


        scoreText.text = "Score: " + score;
        if(Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -20){
            //30
            transform.position += new Vector3(-1 * speed, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 27){
            //-30
            transform.position += new Vector3(1 * speed, 0, 0);
        }
    }
  
}
**/
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 100f;
    public float score = 0f;
    public TextMeshProUGUI scoreText;
    private float targetX;

    void Start()
    {
        targetX = transform.position.x;
    }

    void Update()
    {
        scoreText.text = "Score: " + score;

        if (Input.GetKeyDown(KeyCode.LeftArrow) && targetX > -20)
        {
            targetX -= speed;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && targetX < 27)
        {
            targetX += speed;
        }

        Vector3 targetPosition = new Vector3(targetX, transform.position.y, transform.position.z);
        transform.position = Vector3.MoveTowards(
            transform.position,
            targetPosition,
            speed * 5 * Time.deltaTime
        );
    }
}
