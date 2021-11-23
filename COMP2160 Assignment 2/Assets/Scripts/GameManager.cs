using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Declares an instance of this Manager
    private static GameManager instance;

    // Declares a Read-Only instance of this Manager allowing other scripts to pull from it.
    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }

    // Time
    private float ms = 0;
    private float seconds = 0;
    private float minutes = 0;

    // Timestamps for each checkpoint.
    private string cP1Time = "Incomplete";
    private string cP2Time = "Incomplete";
    private string cP3Time = "Incomplete";
    private string cP4Time = "Incomplete";

    // Public Timestamps for UIManager.
    public string CP1Time
    {
        get
        {
            return cP1Time;
        }
    }
    public string CP2Time
    {
        get
        {
            return cP2Time;
        }
    }
    public string CP3Time
    {
        get
        {
            return cP3Time;
        }
    }
    public string CP4Time
    {
        get
        {
            return cP4Time;
        }
    }

    // Strings for seconds and milliseconds when they are < 10
    private string secondsZeroed;
    private string msZeroed;

    // Strings for time
    private string currentTime;
    public string CurrentTime
    {
        get
        {
            return currentTime;
        }
    }

    // Awake is called before Start
    void Awake()
    {
        // Sets whatever this object this is attached to as the Singleton in the Scene.
        instance = this;
    }

    // Update is called every frame
    void Update()
    {
        Timer();
    }

    // Timer
    public void Timer()
    {
        ms += Time.deltaTime * 100;
        
        if (ms >= 100)
        {
            seconds += 1;
            ms = 0;
        }

        if (seconds >= 60)
        {
            minutes += 1;
            seconds = 0;
        }

        ZeroAdder();
        currentTime = minutes + " : " + secondsZeroed + " : " + msZeroed;

    }

    // Checkpoint Timecap
    public void CheckpointTime(float checkpointNumber)
    {
        if(checkpointNumber == 1)
        {
            cP1Time = "Checkpoint 1 Time = " + currentTime;
        }
        if (checkpointNumber == 2)
        {
            cP2Time = "Checkpoint 2 Time = " + currentTime;
        }
        if (checkpointNumber == 3)
        {
            cP3Time = "Checkpoint 3 Time = " + currentTime;
        }
        if (checkpointNumber == 4)
        {
            cP4Time = "Checkpoint 4 Time = " + currentTime;
        }
    }

    // Zero Adder
    public void ZeroAdder()
    {
        if (ms < 10)
        {
            msZeroed = "0" + ms.ToString("F0");
        }

        else
        {
            msZeroed = ms.ToString("F0");
        }

        if (seconds < 10)
        {
            secondsZeroed = "0" + seconds;
        }

        else
        {
            secondsZeroed = seconds.ToString();
        }
    }

    // Restart function called by Play Again Button
    public void Restart()
    {
        // Reloads the level
        SceneManager.LoadScene(0);
    }

}
