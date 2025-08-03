using UnityEngine;

public class LandGeneration : MonoBehaviour
{   
    public GameObject Rotation1;
    public GameObject Rotation2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Rotation1.transform.position.z > -1500) // repeat
        {
            Rotation1.transform.position += new Vector3(0, 0, -0.1f); //speed
        }
        else Rotation1.transform.position = new Vector3(-8.12f, 63.66f, 32.35f);

        if (Rotation2.transform.position.z > -1500) // repeat
        {
            Rotation2.transform.position += new Vector3(0, 0, -0.1f); //speed
        }
        else Rotation2.transform.position = new Vector3(-8.12f, 63.66f, 32.35f);
    }
}
