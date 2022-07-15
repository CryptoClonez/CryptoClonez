using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloneFinalTally : MonoBehaviour
{
    public List<string> typeList;
    public List<List<string>> superListStrings = new List<List<string>>();
    public List<List<int>> superListInts = new List<List<int>>();

    public GameObject canvas;

    public GameObject skinWhiteUI;
    public GameObject skinTanUI;
    public GameObject skinBlackUI;
    public GameObject skinRedUI;
    public GameObject skinGreenUI;
    public GameObject skinBlueUI;
    public GameObject skinBronzeUI;
    public GameObject skinSilverUI;
    public GameObject skinGoldUI;

    public GameObject eyeStyleRoundUI;
    public GameObject eyeStyleAlmondUI;
    public GameObject eyeStyleUpturnedUI;

    public GameObject eyelashesShortUI;
    public GameObject eyelashesLongUI;

    public GameObject hairStyleLBunUI;
    public GameObject hairStyleLCurlyUI;
    public GameObject hairStyleLDreadsUI;
    public GameObject hairStyleLMohawkUI;
    public GameObject hairStyleLPonytailUI;
    public GameObject hairStyleLStraightUI;
    public GameObject hairStyleMAfroUI;
    public GameObject hairStyleMDreadsUI;
    public GameObject hairStyleMMessyUI;
    public GameObject hairStyleMMohawkUI;
    public GameObject hairStyleMPartingUI;
    public GameObject hairStyleMPigtailsUI;
    public GameObject hairStyleMPonytailUI;
    public GameObject hairStyleMQuifUI;
    public GameObject hairStyleMSpikedUI;
    public GameObject hairStyleSAfroUI;
    public GameObject hairStyleSBaldUI;
    public GameObject hairStyleSCharlesUI;
    public GameObject hairStyleSMonkUI;
    public GameObject hairStyleSStubbleUI;

    public GameObject hairColourBlackUI;
    public GameObject hairColourBrownDarkUI;
    public GameObject hairColourBrownLightUI;
    public GameObject hairColourBlondeUI;
    public GameObject hairColourGingerUI;
    public GameObject hairColourGreyUI;
    public GameObject hairColourWhiteUI;

    public GameObject specRoundUI;
    public GameObject specSquareUI;
    public GameObject specDiamondUI;
    public GameObject specHeartUI;
    public GameObject specStarUI;

    public GameObject eyeColourBrownUI;
    public GameObject eyeColourBlueUI;
    public GameObject eyeColourHazelUI;
    public GameObject eyeColourGreenUI;

    public GameObject beardStyleNoneUI;
    public GameObject beardStyleShortUI;
    public GameObject beardStyleLongUI;
    public GameObject beardStyleMustacheUI;

    public GameObject browStyleThickUI;
    public GameObject browStyleThinUI;
    public GameObject browStyleMonobrowUI;

    public GameObject tongueStyleNormalUI;
    public GameObject tongueStyleDogUI;

    public GameObject teethStyleNormalUI;

    List<GameObject> ListUI;

    public void Start()
    {
        InputManager.HKey += TurnOffUI;
    }

    private void TurnOffUI()
    {
        if (canvas.activeSelf == true)
        {
            canvas.SetActive(false);
        }
        else
            canvas.SetActive(true);
    }

    public void AddToTally(string thisString /* eg White Skin */, string typeString /* eg Skin colour,  */)
    {
        if (!typeList.Contains(typeString))
        {

            List<string> thisStringList = new List<string>(); //adds a list for skin colour
            List<int> thisIntList = new List<int>(); //adds a counter list for skin colour

            superListStrings.Add(thisStringList); //adds the skin colour list to the super list
            superListInts.Add(thisIntList); //adds the counter list to the super list

            thisStringList.Add(thisString); //adds the skin colour type to the nested list inside the super list
            thisIntList.Add(1); ////adds the counter skin colour type to the nested list inside the super list

            typeList.Add(typeString); 

        }
        else //Already contains skin colour category
        {
            int thisInt = typeList.IndexOf(typeString);
            if (superListStrings[thisInt].Contains(thisString))
            {
                int thisOtherInt = superListStrings[thisInt].IndexOf(thisString);
                superListInts[thisInt][thisOtherInt]++;
            }
            else
            {
                superListStrings[thisInt].Add(thisString);
                superListInts[thisInt].Add(1);
            }
        }
    }

    public void FinalTally()//at the end all the types and amounts are tallied up
    {
        ListUI = new List<GameObject>()
    {
        skinWhiteUI,
        skinTanUI,
        skinBlackUI,
        skinRedUI,
        skinGreenUI,
        skinBlueUI,
        skinBronzeUI,
        skinSilverUI,
        skinGoldUI,

        eyeStyleRoundUI,
        eyeStyleAlmondUI,
        eyeStyleUpturnedUI,

        eyelashesShortUI,
        eyelashesLongUI,

        hairStyleLBunUI,
        hairStyleLCurlyUI,
        hairStyleLDreadsUI,
        hairStyleLMohawkUI,
        hairStyleLPonytailUI,
        hairStyleLStraightUI,
        hairStyleMAfroUI,
        hairStyleMDreadsUI,
        hairStyleMMessyUI,
        hairStyleMMohawkUI,
        hairStyleMPartingUI,
        hairStyleMPigtailsUI,
        hairStyleMPonytailUI,
        hairStyleMQuifUI,
        hairStyleMSpikedUI,
        hairStyleSAfroUI,
        hairStyleSBaldUI,
        hairStyleSCharlesUI,
        hairStyleSMonkUI,
        hairStyleSStubbleUI,

        hairColourBlackUI,
        hairColourBrownDarkUI,
        hairColourBrownLightUI,
        hairColourBlondeUI,
        hairColourGingerUI,
        hairColourGreyUI,
        hairColourWhiteUI,

        specRoundUI,
        specSquareUI,
        specDiamondUI,
        specHeartUI,
        specStarUI,

        eyeColourBrownUI,
        eyeColourBlueUI,
        eyeColourHazelUI,
        eyeColourGreenUI,

        beardStyleNoneUI,
        beardStyleShortUI,
        beardStyleLongUI,
        beardStyleMustacheUI,
        
        browStyleThickUI,
        browStyleThinUI,
        browStyleMonobrowUI,

        tongueStyleNormalUI,
        tongueStyleDogUI,

        teethStyleNormalUI

    };

        for (int i = 0; i < superListStrings.Count; i++)
        {
            
            for (int j = 0; j < superListStrings[i].Count; j++)
            {
                string thisUIElement = null;
                for (int k = 0; k < ListUI.Count; k++)
                {
                    thisUIElement = ListUI[k].GetComponent<StyleHolder>().cloneTypeUI.featureName;
                    if (superListStrings[i][j] == thisUIElement)
                    {
                        ListUI[k].GetComponent<Text>().text = superListInts[i][j].ToString();
                    }
                }
            }
        }
    }
}


