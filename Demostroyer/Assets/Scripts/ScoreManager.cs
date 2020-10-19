using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    int score;
    int lives;
    int carCount;
    public GameObject scoreTextObj;
    public GameObject livesTextObj;
    public GameObject carCountTextObj;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreTextObj.GetComponent<Text>().text = "Score : " + score;
        lives = 5;
        livesTextObj.GetComponent<Text>().text = "Lives : " + lives;
        carCount = 0;
        carCountTextObj.GetComponent<Text>().text = "Car Count : " + carCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScore() {
        score = score + 5;
        scoreTextObj.GetComponent<Text>().text = "Score : " + score;
    }
    public void DecreaseLives() {
        lives = lives - 1;
        livesTextObj.GetComponent<Text>().text = "Lives : " + lives;
        // if lives becomes 0 -> Timscale 0 + Activate GameOverScreen
    }
    public void CarCountUp() {
        carCount = carCount + 1;
        carCountTextObj.GetComponent<Text>().text = "Car Count : " + carCount;
        // if carcount becomes 10 -> Timscale 0 + Activate GameOverScreen
    }
    public void CarCountDown() {
        carCount = carCount - 1;
        carCountTextObj.GetComponent<Text>().text = "Car Count : " + carCount;
    }
}
