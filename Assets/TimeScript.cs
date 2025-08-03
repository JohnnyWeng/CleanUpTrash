using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeScript : MonoBehaviour
{
    public float totalTime = 60f;
    public float timeLeft;
    public TextMeshProUGUI timerText;
    public GameObject timeOut;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeLeft = totalTime;
        timeOut.SetActive(false);
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        while (timeLeft > 0)
        {
            yield return new WaitForSeconds(1f);
            timeLeft--;
            timerText.text = "Time: " + timeLeft.ToString();
        }

        Time.timeScale = 0;
        timeOut.SetActive(true);
        Debug.Log("Time's up!");
    }
}
