using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject popcatClose;
    public GameObject popcatOpen;
    public TextMeshProUGUI scoreText;

    int scoreCount;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            popcatOpen.SetActive(true);
            popcatClose.SetActive(false);

            GetComponent<AudioSource>().Play();
            scoreCount++;
            scoreText.text = scoreCount.ToString();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            popcatClose.SetActive(true);
            popcatOpen.SetActive(false);

        }
    }
}
