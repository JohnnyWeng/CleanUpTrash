using System.Collections;
using UnityEngine;

public class TrashSpawnerScript : MonoBehaviour
{
    public GameObject[] trashPrefabs;
    // public GameObject trashPrefab; // Trash object
    // public GameObject trashPrefab2; // trashPrefab2
    public GameObject selectedPrefab;
    public int position = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    StartCoroutine(SpawnTrashCoroutine());
    }

    IEnumerator SpawnTrashCoroutine()
    {
        while (true) 
        {
            float delay = 0;
            int selectedIndex = Random.Range(0, trashPrefabs.Length);
            selectedPrefab = trashPrefabs[selectedIndex];

            float yValue = selectedPrefab.transform.position.y;
            float zValue = selectedPrefab.transform.position.z; 

            float randomNumber = Random.Range(0, 3);
            // Inside SpawnTrashCoroutine()
            if (randomNumber == 0)
                StartCoroutine(SpawnTrash(-30f, yValue, zValue)); // Correct: Call SpawnCoin with the value
            if (randomNumber == 1)
                StartCoroutine(SpawnTrash(20f, yValue, zValue));   // Correct: Call SpawnCoin with the value
            if (randomNumber == 2)
                StartCoroutine(SpawnTrash(70f, yValue, zValue));  // Correct: Call SpawnCoin with the value

            // Wait for a random time before spawning the next coin
            if (position==1){
                delay = 0.5f;
                position = 0;
            } else {
            delay = Random.Range(1f, 4f);
            }
            yield return new WaitForSeconds(delay);
        }
    }
IEnumerator SpawnTrash(float xValue, float yValue, float zValue)
{
    // Debug.Log("trashPrefab is: " + trashPrefab);
    // Wait for 3 seconds before spawning the coin
    yield return new WaitForSeconds(3f);

    // Check if coinPrefab is still valid
    if (selectedPrefab != null)
    {
        // Get Y and Z values from the position
        float xRotation = selectedPrefab.transform.rotation.eulerAngles.x;
        float yRotation = selectedPrefab.transform.rotation.eulerAngles.y;
        float zRotation = selectedPrefab.transform.rotation.eulerAngles.z; 

        // Instantiate the coin at the given position
        Quaternion customRotation = Quaternion.Euler(xRotation, yRotation, zRotation);
        GameObject instantiatedTrash = Instantiate(selectedPrefab, new Vector3(xValue, -0.13f, 361.6f), customRotation);  
        
        Debug.Log("Instantiated x: " + instantiatedTrash.transform.position.x +
            ", y: " + instantiatedTrash.transform.position.y +
            ", z: " + instantiatedTrash.transform.position.z);
    }
    else
    {
        Debug.LogWarning("trashPrefab is null and cannot be instantiated.");
    }
}
}
