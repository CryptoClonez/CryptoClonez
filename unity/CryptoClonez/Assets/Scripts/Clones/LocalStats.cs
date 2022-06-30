using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocalStats : MonoBehaviour
{
    public GameObject cloneCreator;
    public CloneNavigation cloneNavigation;
    List<GameObject> cloneList = new List<GameObject>();
    public int currentClone = 0;

    public GameObject cloneNumber;
    public GameObject skinColour;
    public GameObject eyeType;
    public GameObject lashType;
    public GameObject specType;
    public GameObject hairType;
    public GameObject hairColour;
    public GameObject browType;
    public GameObject eyeColour;
    public GameObject beardType;
    public GameObject tongueType;
    public GameObject teethType;

    public void Awake()
    {
        cloneList = cloneCreator.GetComponent<CreateClonez>().cloneList;
        currentClone = cloneNavigation.currentClone;
    }
    public void UpdatUI()
    {
        cloneList = cloneCreator.GetComponent<CreateClonez>().cloneList;
        currentClone = cloneNavigation.currentClone;

        cloneNumber.GetComponent<Text>().text = cloneList[currentClone].GetComponent<CloneDetails>().cloneNumber.ToString();

        skinColour.GetComponent<Text>().text = cloneList[currentClone].GetComponent<CloneDetails>().skinColour;
        eyeType.GetComponent<Text>().text = cloneList[currentClone].GetComponent<CloneDetails>().eyeStyle;
        lashType.GetComponent<Text>().text = cloneList[currentClone].GetComponent<CloneDetails>().lashStyle;
        specType.GetComponent<Text>().text = cloneList[currentClone].GetComponent<CloneDetails>().eyeSpecStyle;
        hairType.GetComponent<Text>().text = cloneList[currentClone].GetComponent<CloneDetails>().hairStyle;
        hairColour.GetComponent<Text>().text = cloneList[currentClone].GetComponent<CloneDetails>().hairColour;
        browType.GetComponent<Text>().text = cloneList[currentClone].GetComponent<CloneDetails>().browStyle;
        eyeColour.GetComponent<Text>().text = cloneList[currentClone].GetComponent<CloneDetails>().eyeColour;
        beardType.GetComponent<Text>().text = cloneList[currentClone].GetComponent<CloneDetails>().beardStyle;
        tongueType.GetComponent<Text>().text = cloneList[currentClone].GetComponent<CloneDetails>().tongueStyle;
        teethType.GetComponent<Text>().text = cloneList[currentClone].GetComponent<CloneDetails>().teethStyle;
    }
}
