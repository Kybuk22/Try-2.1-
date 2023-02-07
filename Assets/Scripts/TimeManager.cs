using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{


    private static TimeManager _instance = null;
    public ManagerTime ManTime;
    public static int duration=300;
    public static float time;
    public static TimeManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<TimeManager>();

                if (_instance == null)
                {
                    Debug.LogError("Fatal Error: TimeManager not Found");
                }
            }

            return _instance;
        }
    }
    private void Start()
    {
        ManTime=new();
        time = 0;
    }

    private void Update()
    {        

        if (time > duration)
        {
            GameFlowManager.Instance.GameOver();            
            return;
        }
        time += Time.deltaTime;
    }
}
public class ManagerTime{
    public float GetRemainingTime()
    {
        return TimeManager.duration - TimeManager.time;
    }
}
