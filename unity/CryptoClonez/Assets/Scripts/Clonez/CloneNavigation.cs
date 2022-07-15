using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneNavigation : MonoBehaviour
{
    public CreateClonez createClonez;
    public List<GameObject> cloneList;
    public LocalStats localStats;

    public int cloneAmount = 10000;
    public int currentClone = 0;
    public int previousClone = 0;

    void Start()
    {
        cloneList = createClonez.cloneList;
        InputManager.AKey += PreviousClone;
        InputManager.DKey += NextClone;
        InputManager.RKey += RandomClone;
        //InputManager.ZKey += Undo;
        InputManager.SpaceKey += SelectedClone;
    }

    public void PreviousClone()
    {
        //Debug.Log("clone back");
        previousClone = currentClone;

        if (currentClone == 0)
        {
            currentClone = 9999;
        }
        else
        {
            currentClone--;
        }
        InspectClone();
    }
    public void NextClone()
    {
        //Debug.Log("clone forward");
        previousClone = currentClone;

        if (currentClone == 9999)
        {
            currentClone = 0;
        }
        else
        {
            currentClone++;
        }
        InspectClone();
    }
    public void RandomClone()
    {
        Debug.Log("clone random");
        previousClone = currentClone;
        currentClone = Random.Range(0, cloneAmount);
        InspectClone();
    }
    public void SelectedClone()
    {
        InspectClone();
    }
    public void InspectClone()
    {
        cloneList[previousClone].SetActive(false);
        cloneList[currentClone].SetActive(true);
        previousClone = currentClone;
        
        localStats.UpdatUI();
    }

    /* public void Undo()
    {
        if (history.Count <= 1)
        {
            Debug.Log("Nothing to undo");
        }
        else if (currentClone == 0)
        {
            Debug.Log("Nothing to undo");
        }
        else
        {
            undoCount++;
            previousClone = currentClone;
            currentClone = history[history.Count - 1 - undoCount];           
            InspectClone();
        }
    }
    */

    public void RenderFromBeginning()
    {
        if (currentClone < 10000)
        {
            NextClone();
        }
    }

}
