using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniquenessTest : MonoBehaviour
{
    public CreateClonez createClonez;
    public List<GameObject> cloneList;


    public void TestForUniqueness()
    {
        bool unique = RunTest();
        if(unique)
            Debug.Log("Clonez are unique!");
        else
            Debug.Log("Clonez are NOT unique, do something about it!");
    }

    public bool RunTest()
    {
        cloneList = createClonez.cloneList;
        List<string> previousCloneDetails = new List<string>();
        for (int i = 0; i < cloneList.Count; i++) // Loops through all clones
        {
            
            cloneList[i].GetComponent<CloneDetails>().PopulateCloneDetailList();

            if (i == 0) // first clone gets stored a "Prevous" and then we move on to the second.
            {
                previousCloneDetails = cloneList[i].GetComponent<CloneDetails>().CloneDetailList;
            }

            else if (i == cloneList.Count - 1)
            {

            }   // last clone gets skipped because the test is done.

            else
            {
                
                int matchCount = 0;
                for (int j = 0; j < previousCloneDetails.Count; j++) //loops through all CloneTypes (hair style etc)
                {
                    if (previousCloneDetails[j] == cloneList[i].GetComponent<CloneDetails>().CloneDetailList[j])
                    {
                        matchCount++;
                        //Debug.Log(matchCount);
                    }
                }
                if (matchCount >= previousCloneDetails.Count)
                {
                    Debug.Log("Clones Are Not Unique");
                    return false;
                }
                previousCloneDetails = cloneList[i].GetComponent<CloneDetails>().CloneDetailList;
                //Debug.Log(matchCount);
            }
            
        }
        return true;
    }
}
