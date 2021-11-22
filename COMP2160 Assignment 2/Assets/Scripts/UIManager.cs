using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Declares an instance of this Manager
    private static UIManager instance;

    // Declares a Read-Only instance of this Manager allowing other scripts to pull from it.
    public static UIManager Instance
    {
        get
        {
            return instance;
        }
    }

    // Specifies the Victory Canvas.
    public Canvas victoryCanvasPrefab;

    // Specifies the Game Over Canvas.
    public Canvas gameOverCanvasPrefab;

    // Specifies Car Health component.
    public CarHealth carHP;

    // Specifies Car Health slider
    public Slider healthBar;

    // Specifies Timer Canvas;
    public Canvas timer;

    // Awake is called before Start
    void Awake()
    {
        // Sets whatever this object this is attached to as the Singleton in the Scene.
        instance = this;
    }

    // Start is called at the start of the method
    void Start()
    {
        healthBar.maxValue = carHP.maxHP;
        healthBar.value = carHP.maxHP;
    }

    // Updates Current Health displayed.
    void Update()
    {
        healthBar.value = carHP.CurrentHP;
        timer.transform.GetComponentInChildren<Text>().text = GameManager.Instance.CurrentTime;
    }

    // Calls Victory Screen to display stats from Game Manager
    public void WinGame()
    {
        GameObject victory = Instantiate(victoryCanvasPrefab.gameObject);

        Transform panel = victory.transform.Find("Panel");

        panel.transform.Find("CP1").GetComponent<Text>().text = GameManager.Instance.CP1Time;
        panel.transform.Find("CP2").GetComponent<Text>().text = GameManager.Instance.CP2Time;
        panel.transform.Find("CP3").GetComponent<Text>().text = GameManager.Instance.CP3Time;
        panel.transform.Find("CP4").GetComponent<Text>().text = GameManager.Instance.CP4Time;
    }

    // Calls Game Over Screen to display stats from Game Manager
    public void LoseGame()
    {
        GameObject gameOver = Instantiate(gameOverCanvasPrefab.gameObject);

        Transform panel = gameOver.transform.Find("Panel");

        panel.transform.Find("CP1").GetComponent<Text>().text = GameManager.Instance.CP1Time;
        panel.transform.Find("CP2").GetComponent<Text>().text = GameManager.Instance.CP2Time;
        panel.transform.Find("CP3").GetComponent<Text>().text = GameManager.Instance.CP3Time;
        panel.transform.Find("CP4").GetComponent<Text>().text = GameManager.Instance.CP4Time;
    }
}
