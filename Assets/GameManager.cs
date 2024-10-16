using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float TimeCounter = 120;
    public TextMeshProUGUI Timer;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (TimeCounter > 0)
        {
            TimeCounter -= Time.deltaTime;
        }
        else if (TimeCounter < 0)
        {
            SceneManager.LoadScene("YouSurvived");
        }

        Timer.text = "" + TimeCounter.ToString("F0");
    }
}