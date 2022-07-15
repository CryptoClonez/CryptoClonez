using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatSwitcher : MonoBehaviour
{
    public GameObject globalStats;
    public GameObject localStats;
    public bool localStatsActive = true;

    public void Start()
    {
        SwitchStats();
    }
    public void SwitchStats()
    {
        if (localStatsActive)
        {
            globalStats.SetActive(false);
            localStats.SetActive(true);
            localStatsActive = false;
        }
        else
        {
            globalStats.SetActive(true);
            localStats.SetActive(false);
            localStatsActive = true;
        }
    }
}
