using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateClonez : MonoBehaviour
{
    public int CloneAmount = 10000; //how many clones there will be.
    public int RandomSeed = 0;
    public int CloneToInspect; //the currently selected clone. 
    private float CloneScale = 0.5f; //the size of the clone on screen.
    public GameObject FinalTallyObject;
    public GameObject UniqunessTestObject;
    public LocalStats localStats;

    private List<string> skinColourList;
    private List<Material> skinTypeMatAMList;
    private List<Material> skinTypeMatHLList;
    private List<Sprite> skinTypeSpriteCOList;
    private List<Sprite> skinTypeSpriteRRList;
    private List<Sprite> skinTypeSpriteAOList;
    private List<Sprite> skinTypeSpriteHLList;
    private List<Sprite> skinTypeSpriteRFList;
    private List<string> eyeTypeList;
    private List<Sprite> eyeTypeSpriteDDList;
    private List<Sprite> eyeTypeSpriteCOList;
    private List<string> hairColourList;
    private List<Material> hairColourMatAMList;
    private List<Material> hairColourMatHLList;
    private List<string> hairTypeList;
    private List<Sprite> hairTypeSpriteDDList;
    private List<string> browTypeList;
    private List<Sprite> browTypeSpriteDDList;
    private List<string> beardTypeList;
    private List<Sprite> beardTypeSpriteDDList;
    private List<Sprite> lashTypeSpriteDDList;
    private List<Sprite> lashTypeSpriteCOList;
    private List<string> lashTypeList;


    //============================================================ SPECIAL MATERIALS
    public Material matSkinWhiteIL;
    public Material matSkinTanIL;
    public Material matSkinBlackIL;
    public Material matSkinRedIL;
    public Material matSkinGreenIL;
    public Material matSkinBlueIL;
    public Material matSkinBronzeIL;
    public Material matSkinSilverIL;
    public Material matSkinGoldIL;

    public Material matSkinWhiteAM;
    public Material matSkinTanAM;
    public Material matSkinBlackAM;
    public Material matSkinRedAM;
    public Material matSkinGreenAM;
    public Material matSkinBlueAM;
    public Material matSkinBronzeAM;
    public Material matSkinSilverAM;
    public Material matSkinGoldAM;

    public Material matHairBlackAM;
    public Material matHairBrownDarkAM;
    public Material matHairBrownLightAM;
    public Material matHairBlondeAM;
    public Material matHairGingerAM;
    public Material matHairGreyAM;
    public Material matHairWhiteAM;

    public Material matHairBlackHL;
    public Material matHairBrownDarkHL;
    public Material matHairBrownLightHL;
    public Material matHairBlondeHL;
    public Material matHairGingerHL;
    public Material matHairGreyHL;
    public Material matHairWhiteHL;


    //============================================================ SKIN COLOUR
    public CloneType typeSkinBlackRoundCO;
    public CloneType typeSkinBlackAlmondCO;
    public CloneType typeSkinBlackUpturnedCO;
    public CloneType typeSkinTanRoundCO;
    public CloneType typeSkinTanAlmondCO;
    public CloneType typeSkinTanUpturnedCO;
    public CloneType typeSkinWhiteRoundCO;
    public CloneType typeSkinWhiteAlmondCO;
    public CloneType typeSkinWhiteUpturnedCO;
    public CloneType typeSkinRedRoundCO;
    public CloneType typeSkinRedAlmondCO;
    public CloneType typeSkinRedUpturnedCO;
    public CloneType typeSkinGreenRoundCO;
    public CloneType typeSkinGreenAlmondCO;
    public CloneType typeSkinGreenUpturnedCO;
    public CloneType typeSkinBlueRoundCO;
    public CloneType typeSkinBlueAlmondCO;
    public CloneType typeSkinBlueUpturnedCO;
    public CloneType typeSkinBronzeRoundCO;
    public CloneType typeSkinBronzeAlmondCO;
    public CloneType typeSkinBronzeUpturnedCO;
    public CloneType typeSkinSilverRoundCO;
    public CloneType typeSkinSilverAlmondCO;
    public CloneType typeSkinSilverUpturnedCO;
    public CloneType typeSkinGoldRoundCO;
    public CloneType typeSkinGoldAlmondCO;
    public CloneType typeSkinGoldUpturnedCO;

    public CloneType typeSkinBlackRoundDD;
    public CloneType typeSkinBlackAlmondDD;
    public CloneType typeSkinBlackUpturnedDD;
    public CloneType typeSkinTanRoundDD;
    public CloneType typeSkinTanAlmondDD;
    public CloneType typeSkinTanUpturnedDD;
    public CloneType typeSkinWhiteRoundDD;
    public CloneType typeSkinWhiteAlmondDD;
    public CloneType typeSkinWhiteUpturnedDD;
    public CloneType typeSkinRedRoundDD;
    public CloneType typeSkinRedAlmondDD;
    public CloneType typeSkinRedUpturnedDD;
    public CloneType typeSkinGreenRoundDD;
    public CloneType typeSkinGreenAlmondDD;
    public CloneType typeSkinGreenUpturnedDD;
    public CloneType typeSkinBlueRoundDD;
    public CloneType typeSkinBlueAlmondDD;
    public CloneType typeSkinBlueUpturnedDD;
    public CloneType typeSkinBronzeRoundDD;
    public CloneType typeSkinBronzeAlmondDD;
    public CloneType typeSkinBronzeUpturnedDD;
    public CloneType typeSkinSilverRoundDD;
    public CloneType typeSkinSilverAlmondDD;
    public CloneType typeSkinSilverUpturnedDD;
    public CloneType typeSkinGoldRoundDD;
    public CloneType typeSkinGoldAlmondDD;
    public CloneType typeSkinGoldUpturnedDD;

    public CloneType typeSkinIL;

    public CloneType typeSkinRoundRL;
    public CloneType typeSkinAlmondRL;
    public CloneType typeSkinUpturnedRL;

    public CloneType typeSkinRoundRR;
    public CloneType typeSkinAlmondRR;
    public CloneType typeSkinUpturnedRR;

    public CloneType typeSkinRoundRF;
    public CloneType typeSkinAlmondRF;
    public CloneType typeSkinUpturnedRF;

    public CloneType skinAM;
    public CloneType typeSkinRoundSS;

    public CloneType typeSkinWhiteAM;
    public CloneType typeSkinTanAM;
    public CloneType typeSkinBlackAM;
    public CloneType typeSkinRedAM;
    public CloneType typeSkinGreenAM;
    public CloneType typeSkinBlueAM;
    public CloneType typeSkinBronzeAM;
    public CloneType typeSkinSilverAM;
    public CloneType typeSkinGoldAM;

    public CloneType typeSkinRoundAO;
    public CloneType typeSkinAlmondAO;
    public CloneType typeSkinUpturnedAO;

    public CloneType typeSkinWhiteRoundHL;
    public CloneType typeSkinWhiteAlmondHL;
    public CloneType typeSkinWhiteUpturnedHL;
    public CloneType typeSkinTanRoundHL;
    public CloneType typeSkinTanAlmondHL;
    public CloneType typeSkinTanUpturnedHL;
    public CloneType typeSkinBlackRoundHL;
    public CloneType typeSkinBlackAlmondHL;
    public CloneType typeSkinBlackUpturnedHL;
    public CloneType typeSkinRedRoundHL;
    public CloneType typeSkinRedAlmondHL;
    public CloneType typeSkinRedUpturnedHL;
    public CloneType typeSkinGreenRoundHL;
    public CloneType typeSkinGreenAlmondHL;
    public CloneType typeSkinGreenUpturnedHL;
    public CloneType typeSkinBlueRoundHL;
    public CloneType typeSkinBlueAlmondHL;
    public CloneType typeSkinBlueUpturnedHL;
    public CloneType typeSkinBronzeRoundHL;
    public CloneType typeSkinBronzeAlmondHL;
    public CloneType typeSkinBronzeUpturnedHL;
    public CloneType typeSkinSilverRoundHL;
    public CloneType typeSkinSilverAlmondHL;
    public CloneType typeSkinSilverUpturnedHL;
    public CloneType typeSkinGoldRoundHL;
    public CloneType typeSkinGoldAlmondHL;
    public CloneType typeSkinGoldUpturnedHL;


    //============================================================ EYE STYLE
    public CloneType typeEyeStyleRoundCO;
    public CloneType typeEyeStyleAlmondCO;
    public CloneType typeEyeStyleUpturnedCO;

    public CloneType typeEyeStyleRoundDD;
    public CloneType typeEyeStyleAlmondDD;
    public CloneType typeEyeStyleUpturnedDD;

    public CloneType typeEyeStyleRoundCS;
    public CloneType typeEyeStyleAlmondCS;
    public CloneType typeEyeStyleUpturnedCS;

    public CloneType typeEyeStyleRoundAM;
    public CloneType typeEyeStyleAlmondAM;
    public CloneType typeEyeStyleUpturnedAM;

    public CloneType typeEyeStyleRoundRR;
    public CloneType typeEyeStyleAlmondRR;
    public CloneType typeEyeStyleUpturnedRR;

    public CloneType typeEyeStyleRoundAO;
    public CloneType typeEyeStyleAlmondAO;
    public CloneType typeEyeStyleUpturnedAO;

    public CloneType typeEyeStyleRoundRF;
    public CloneType typeEyeStyleAlmondRF;
    public CloneType typeEyeStyleUpturnedRF;

    //============================================================ EYELASH STYLE
    public CloneType typeEyelashStyleAlmondLongCO;
    public CloneType typeEyelashStyleAlmondShortCO;
    public CloneType typeEyelashStyleRoundLongCO;
    public CloneType typeEyelashStyleRoundShortCO;
    public CloneType typeEyelashStyleUpturnedLongCO;
    public CloneType typeEyelashStyleUpturnedShortCO;

    public CloneType typeEyelashStyleAlmondLongDD;
    public CloneType typeEyelashStyleAlmondShortDD;
    public CloneType typeEyelashStyleRoundLongDD;
    public CloneType typeEyelashStyleRoundShortDD;
    public CloneType typeEyelashStyleUpturnedLongDD;
    public CloneType typeEyelashStyleUpturnedShortDD;


    //============================================================ HAIR STYLE
    public CloneType typeHairStyleLBunCO;
    public CloneType typeHairStyleLCurlyCO;
    public CloneType typeHairStyleLDreadsCO;
    public CloneType typeHairStyleLMohawkCO;
    public CloneType typeHairStyleLPonytailCO;
    public CloneType typeHairStyleLStraightCO;

    public CloneType typeHairStyleMAfroCO;
    public CloneType typeHairStyleMDreadsCO;
    public CloneType typeHairStyleMMessyCO;
    public CloneType typeHairStyleMMohawkCO;
    public CloneType typeHairStyleMPartingCO;
    public CloneType typeHairStyleMPigtailsCO;
    public CloneType typeHairStyleMPonytailCO;
    public CloneType typeHairStyleMQuifCO;
    public CloneType typeHairStyleMSpikedCO;

    public CloneType typeHairStyleSAfroCO;
    public CloneType typeHairStyleSBaldCO;
    public CloneType typeHairStyleSCharlesCO;
    public CloneType typeHairStyleSMonkCO;
    public CloneType typeHairStyleSStubbleCO;
    //========DD========
    public CloneType typeHairStyleLBunDD;
    public CloneType typeHairStyleLCurlyDD;
    public CloneType typeHairStyleLDreadsDD;
    public CloneType typeHairStyleLMohawkDD;
    public CloneType typeHairStyleLPonytailDD;
    public CloneType typeHairStyleLStraightDD;

    public CloneType typeHairStyleMAfroDD;
    public CloneType typeHairStyleMDreadsDD;
    public CloneType typeHairStyleMMessyDD;
    public CloneType typeHairStyleMMohawkDD;
    public CloneType typeHairStyleMPartingDD;
    public CloneType typeHairStyleMPigtailsDD;
    public CloneType typeHairStyleMPonytailDD;
    public CloneType typeHairStyleMQuifDD;
    public CloneType typeHairStyleMSpikedDD;

    public CloneType typeHairStyleSAfroDD;
    public CloneType typeHairStyleSBaldDD;
    public CloneType typeHairStyleSCharlesDD;
    public CloneType typeHairStyleSMonkDD;
    public CloneType typeHairStyleSStubbleDD;
    //========CS========
    public CloneType typeHairStyleLBunCS;
    public CloneType typeHairStyleLCurlyCS;
    public CloneType typeHairStyleLDreadsCS;
    public CloneType typeHairStyleLMohawkCS;
    public CloneType typeHairStyleLPonytailCS;
    public CloneType typeHairStyleLStraightCS;

    public CloneType typeHairStyleMAfroCS;
    public CloneType typeHairStyleMDreadsCS;
    public CloneType typeHairStyleMMessyCS;
    public CloneType typeHairStyleMMohawkCS;
    public CloneType typeHairStyleMPartingCS;
    public CloneType typeHairStyleMPigtailsCS;
    public CloneType typeHairStyleMPonytailCS;
    public CloneType typeHairStyleMQuifCS;
    public CloneType typeHairStyleMSpikedCS;

    public CloneType typeHairStyleSAfroCS;
    public CloneType typeHairStyleSBaldCS;
    public CloneType typeHairStyleSCharlesCS;
    public CloneType typeHairStyleSMonkCS;
    public CloneType typeHairStyleSStubbleCS;
    //========AO========
    public CloneType typeHairStyleLBunAO;
    public CloneType typeHairStyleLCurlyAO;
    public CloneType typeHairStyleLDreadsAO;
    public CloneType typeHairStyleLMohawkAO;
    public CloneType typeHairStyleLPonytailAO;
    public CloneType typeHairStyleLStraightAO;

    public CloneType typeHairStyleMAfroAO;
    public CloneType typeHairStyleMDreadsAO;
    public CloneType typeHairStyleMMessyAO;
    public CloneType typeHairStyleMMohawkAO;
    public CloneType typeHairStyleMPartingAO;
    public CloneType typeHairStyleMPigtailsAO;
    public CloneType typeHairStyleMPonytailAO;
    public CloneType typeHairStyleMQuifAO;
    public CloneType typeHairStyleMSpikedAO;

    public CloneType typeHairStyleSAfroAO;
    public CloneType typeHairStyleSBaldAO;
    public CloneType typeHairStyleSCharlesAO;
    public CloneType typeHairStyleSMonkAO;
    public CloneType typeHairStyleSStubbleAO;

    //========IL========
    public CloneType typeHairStyleLBunIL;
    public CloneType typeHairStyleLCurlyIL;
    public CloneType typeHairStyleLDreadsIL;
    public CloneType typeHairStyleLMohawkIL;
    public CloneType typeHairStyleLPonytailIL;
    public CloneType typeHairStyleLStraightIL;

    public CloneType typeHairStyleMAfroIL;
    public CloneType typeHairStyleMDreadsIL;
    public CloneType typeHairStyleMMessyIL;
    public CloneType typeHairStyleMMohawkIL;
    public CloneType typeHairStyleMPartingIL;
    public CloneType typeHairStyleMPigtailsIL;
    public CloneType typeHairStyleMPonytailIL;
    public CloneType typeHairStyleMQuifIL;
    public CloneType typeHairStyleMSpikedIL;

    public CloneType typeHairStyleSAfroIL;
    public CloneType typeHairStyleSBaldIL;
    public CloneType typeHairStyleSCharlesIL;
    public CloneType typeHairStyleSMonkIL;
    public CloneType typeHairStyleSStubbleIL;

    //========AM========
    public CloneType typeHairStyleLBunAM;
    public CloneType typeHairStyleLCurlyAM;
    public CloneType typeHairStyleLDreadsAM;
    public CloneType typeHairStyleLMohawkAM;
    public CloneType typeHairStyleLPonytailAM;
    public CloneType typeHairStyleLStraightAM;

    public CloneType typeHairStyleMAfroAM;
    public CloneType typeHairStyleMDreadsAM;
    public CloneType typeHairStyleMMessyAM;
    public CloneType typeHairStyleMMohawkAM;
    public CloneType typeHairStyleMPartingAM;
    public CloneType typeHairStyleMPigtailsAM;
    public CloneType typeHairStyleMPonytailAM;
    public CloneType typeHairStyleMQuifAM;
    public CloneType typeHairStyleMSpikedAM;

    public CloneType typeHairStyleSAfroAM;
    public CloneType typeHairStyleSBaldAM;
    public CloneType typeHairStyleSCharlesAM;
    public CloneType typeHairStyleSMonkAM;
    public CloneType typeHairStyleSStubbleAM;
    //========RL========
    public CloneType typeHairStyleLBunRL;
    public CloneType typeHairStyleLCurlyRL;
    public CloneType typeHairStyleLDreadsRL;
    public CloneType typeHairStyleLMohawkRL;
    public CloneType typeHairStyleLPonytailRL;
    public CloneType typeHairStyleLStraightRL;

    public CloneType typeHairStyleMAfroRL;
    public CloneType typeHairStyleMDreadsRL;
    public CloneType typeHairStyleMMessyRL;
    public CloneType typeHairStyleMMohawkRL;
    public CloneType typeHairStyleMPartingRL;
    public CloneType typeHairStyleMPigtailsRL;
    public CloneType typeHairStyleMPonytailRL;
    public CloneType typeHairStyleMQuifRL;
    public CloneType typeHairStyleMSpikedRL;

    public CloneType typeHairStyleSAfroRL;
    public CloneType typeHairStyleSBaldRL;
    public CloneType typeHairStyleSCharlesRL;
    public CloneType typeHairStyleSMonkRL;
    public CloneType typeHairStyleSStubbleRL;
    //========RR========
    public CloneType typeHairStyleLBunRR;
    public CloneType typeHairStyleLCurlyRR;
    public CloneType typeHairStyleLDreadsRR;
    public CloneType typeHairStyleLMohawkRR;
    public CloneType typeHairStyleLPonytailRR;
    public CloneType typeHairStyleLStraightRR;

    public CloneType typeHairStyleMAfroRR;
    public CloneType typeHairStyleMDreadsRR;
    public CloneType typeHairStyleMMessyRR;
    public CloneType typeHairStyleMMohawkRR;
    public CloneType typeHairStyleMPartingRR;
    public CloneType typeHairStyleMPigtailsRR;
    public CloneType typeHairStyleMPonytailRR;
    public CloneType typeHairStyleMQuifRR;
    public CloneType typeHairStyleMSpikedRR;

    public CloneType typeHairStyleSAfroRR;
    public CloneType typeHairStyleSBaldRR;
    public CloneType typeHairStyleSCharlesRR;
    public CloneType typeHairStyleSMonkRR;
    public CloneType typeHairStyleSStubbleRR;

    //========RF========
    public CloneType typeHairStyleLBunRF;
    public CloneType typeHairStyleLCurlyRF;
    public CloneType typeHairStyleLDreadsRF;
    public CloneType typeHairStyleLMohawkRF;
    public CloneType typeHairStyleLPonytailRF;
    public CloneType typeHairStyleLStraightRF;

    public CloneType typeHairStyleMAfroRF;
    public CloneType typeHairStyleMDreadsRF;
    public CloneType typeHairStyleMMessyRF;
    public CloneType typeHairStyleMMohawkRF;
    public CloneType typeHairStyleMPartingRF;
    public CloneType typeHairStyleMPigtailsRF;
    public CloneType typeHairStyleMPonytailRF;
    public CloneType typeHairStyleMQuifRF;
    public CloneType typeHairStyleMSpikedRF;

    public CloneType typeHairStyleSAfroRF;
    public CloneType typeHairStyleSBaldRF;
    public CloneType typeHairStyleSCharlesRF;
    public CloneType typeHairStyleSMonkRF;
    public CloneType typeHairStyleSStubbleRF;

    //========HL========
    public CloneType typeHairStyleLBunHL;
    public CloneType typeHairStyleLCurlyHL;
    public CloneType typeHairStyleLDreadsHL;
    public CloneType typeHairStyleLMohawkHL;
    public CloneType typeHairStyleLPonytailHL;
    public CloneType typeHairStyleLStraightHL;

    public CloneType typeHairStyleMAfroHL;
    public CloneType typeHairStyleMDreadsHL;
    public CloneType typeHairStyleMMessyHL;
    public CloneType typeHairStyleMMohawkHL;
    public CloneType typeHairStyleMPartingHL;
    public CloneType typeHairStyleMPigtailsHL;
    public CloneType typeHairStyleMPonytailHL;
    public CloneType typeHairStyleMQuifHL;
    public CloneType typeHairStyleMSpikedHL;

    public CloneType typeHairStyleSAfroHL;
    public CloneType typeHairStyleSBaldHL;
    public CloneType typeHairStyleSCharlesHL;
    public CloneType typeHairStyleSMonkHL;
    public CloneType typeHairStyleSStubbleHL;

    //============================================================ HAIR COLOUR
    public CloneType typeHairColourBlackCO;
    public CloneType typeHairColourBrownDarkCO;
    public CloneType typeHairColourBrownLightCO;
    public CloneType typeHairColourBlondeCO;
    public CloneType typeHairColourGingerCO;
    public CloneType typeHairColourGreyCO;
    public CloneType typeHairColourWhiteCO;

    //============================================================ EYE COLOUR
    public CloneType typeEyeColourBrownCO;
    public CloneType typeEyeColourBlueCO;
    public CloneType typeEyeColourHazelCO;
    public CloneType typeEyeColourGreenCO;

    public CloneType typeEyeColourBrownDD;
    public CloneType typeEyeColourBlueDD;
    public CloneType typeEyeColourHazelDD;
    public CloneType typeEyeColourGreenDD;

    //============================================================ BEARD STYLE
    public CloneType typeBeardStyleLongCO;
    public CloneType typeBeardStyleMustacheCO;
    public CloneType typeBeardStyleNoneCO;
    public CloneType typeBeardStyleShortCO;

    public CloneType typeBeardStyleLongDD;
    public CloneType typeBeardStyleMustacheDD;
    public CloneType typeBeardStyleNoneDD;
    public CloneType typeBeardStyleShortDD;

    public CloneType typeBeardStyleLongCS;
    public CloneType typeBeardStyleMustacheCS;
    public CloneType typeBeardStyleNoneCS;
    public CloneType typeBeardStyleShortCS;

    public CloneType typeBeardStyleLongRR;
    public CloneType typeBeardStyleMustacheRR;
    public CloneType typeBeardStyleNoneRR;
    public CloneType typeBeardStyleShortRR;

    public CloneType typeBeardStyleLongRL;
    public CloneType typeBeardStyleMustacheRL;
    public CloneType typeBeardStyleNoneRL;
    public CloneType typeBeardStyleShortRL;

    public CloneType typeBeardStyleLongAO;
    public CloneType typeBeardStyleMustacheAO;
    public CloneType typeBeardStyleNoneAO;
    public CloneType typeBeardStyleShortAO;

    public CloneType typeBeardStyleLongRF;
    public CloneType typeBeardStyleMustacheRF;
    public CloneType typeBeardStyleNoneRF;
    public CloneType typeBeardStyleShortRF;

    public CloneType typeBeardStyleLongHL;
    public CloneType typeBeardStyleMustacheHL;
    public CloneType typeBeardStyleNoneHL;
    public CloneType typeBeardStyleShortHL;

    //============================================================ TONGUE STYLE
    public CloneType typeTongueStyleNormalCO;
    public CloneType typeTongueStyleDogCO;

    public CloneType typeTongueStyleNormalDD;
    public CloneType typeTongueStyleDogDD;

    public CloneType typeTongueStyleNormalAO;
    public CloneType typeTongueStyleDogAO;

    public CloneType typeTongueStyleNormalGD;
    public CloneType typeTongueStyleDogGD;

    public CloneType typeTongueStyleNormalAM;
    public CloneType typeTongueStyleDogAM;

    //============================================================ TEETH STYLE
    public CloneType typeTeethStyleNormalCO;

    public CloneType typeTeethStyleNormalDD;

    public CloneType typeTeethStyleNormalAO;

    public CloneType typeTeethStyleNormalAM;

    public CloneType typeTeethStyleNormalIL;

    //============================================================ EYE SPECULAR STYLE
    public CloneType typeSpecRoundCO;
    public CloneType typeSpecSquareCO;
    public CloneType typeSpecDiamondCO;
    public CloneType typeSpecHeartCO;
    public CloneType typeSpecStarCO;

    public CloneType typeSpecRoundDD;
    public CloneType typeSpecSquareDD;
    public CloneType typeSpecDiamondDD;
    public CloneType typeSpecHeartDD;
    public CloneType typeSpecStarDD;

    //============================================================ EYEBROW STYLE
    public CloneType typeBrowThickCO;
    public CloneType typeBrowThinCO;
    public CloneType typeBrowMonobrowCO;

    public CloneType typeBrowThickDD;
    public CloneType typeBrowThinDD;
    public CloneType typeBrowMonobrowDD;

    public CloneType typeBrowThickCS;
    public CloneType typeBrowThinCS;
    public CloneType typeBrowMonobrowCS;

    public CloneType typeBrowThickIL;
    public CloneType typeBrowThinIL;
    public CloneType typeBrowMonobrowIL;

    public CloneType typeBrowThickAM;
    public CloneType typeBrowThinAM;
    public CloneType typeBrowMonobrowAM;

    public CloneType typeBrowThickRR;
    public CloneType typeBrowThinRR;
    public CloneType typeBrowMonobrowRR;

    public CloneType typeBrowThickAO;
    public CloneType typeBrowThinAO;
    public CloneType typeBrowMonobrowAO;

    public CloneType typeBrowThickRF;
    public CloneType typeBrowThinRF;
    public CloneType typeBrowMonobrowRF;

    public CloneType typeBrowThickHL;
    public CloneType typeBrowThinHL;
    public CloneType typeBrowMonobrowHL;

    //============================================================ MOUTHBAG STYLE

    public CloneType typeMouthbagNormalDD;

    public CloneType typeMouthbagNormalCO;


    //============================================================ OTHER

    public List<GameObject> cloneList;
    public int layerDepth;


    public void Start()
    {
        FillDescriptionLists();
        CreateAllClonez();
        FinalTallyObject.GetComponent<CloneFinalTally>().FinalTally();
    }


    private void CreateAllClonez() // This is run on startup to create the 10000 Clonez and place them correctly.
    {
        for (int i = 0; i < CloneAmount; i++)
        {
            GameObject clone = new GameObject("" + i);
            cloneList.Add(clone);

            clone.transform.localScale = new Vector3(CloneScale, CloneScale, CloneScale);
            CloneDetails thisCloneDetails = clone.AddComponent<CloneDetails>();
            thisCloneDetails.cloneNumber = i;

            layerDepth = 1;

            //This section defines the draw order of each face element

            CloneType thisHairColour = CreateHairColour(clone, "hairColour"); // special as it needs to be sent to multiple Create stacks that require hair colour

            CreateEyeStyle(clone, "EyeStyle", false, thisHairColour);
            CreateEyeColour(clone, "EyeColourStyle", false, thisHairColour);
            CreateEyeSpec(clone, "EyeSpecStyle", false, thisHairColour);
            CreateSkinColour(clone, "SkinStyle", false, thisHairColour);
            CreateMouthbagStyle(clone, "MouthbagStyle", false, thisHairColour);
            CreateBrowStyle(clone, "EyebrowStyle", true, thisHairColour);
            CreateEyelashStyle(clone, "LashStyle", false, thisHairColour);                    
            CreateTeethStyle(clone, "TeethStyle", false, thisHairColour);
            CreateBeardStyle(clone, "BeardStyle", true, thisHairColour);
            CreateTongueStyle(clone, "TongueStyle", false, thisHairColour);
            CreateHairStyle(clone, "HairStyle", true, thisHairColour);

            if (i!=0)
            {
                clone.SetActive(false); //makes sure all clones are switched off for the CloneNavigation to work.
            }
            
        }
        localStats.UpdatUI();
    }

    private CloneType CreateHairColour(GameObject clone, string cloneStyleName)
    {
        int black = 3000;
        int brownDark = 2000;
        int brownLight = 2000;
        int blonde = 1400;
        int ginger = 1000;
        int grey = 500;
        int white = 100;

        List<int> numberedList = new List<int>
        {
            black,
            brownDark,
            brownLight,
            blonde,
            ginger,
            grey,
            white
         };

        List<int> additionList = CreateAdditionList(numberedList); //does the number addition for each tier (type 1, type1 + type2, etc)


        List<CloneType> styleList = new List<CloneType>
        {
            typeHairColourBlackCO,
            typeHairColourBrownDarkCO,
            typeHairColourBrownLightCO,
            typeHairColourBlondeCO,
            typeHairColourGingerCO,
            typeHairColourGreyCO,
            typeHairColourWhiteCO
        };

        List<List<CloneType>> listOfLists = new List<List<CloneType>>
        {
            styleList // IF WANT TO COUNT PROPERLY, ENSURE CLONETYPE IS SET TO C INSTEAD OF THE USUAL DD
        };


        CloneType thisCloneType = GetWeightedResult(clone, cloneStyleName, layerDepth, listOfLists, additionList, true, false, null);
        CloneType thisHairColour = thisCloneType;
        return thisHairColour;

    }
    private void CreateSkinColour(GameObject clone, string cloneStyleName, bool requiresHairColour, CloneType thisHairColour)
    {
        int white = 4200;
        int tan = 2100;
        int black = 2100;
        int red = 400;
        int green = 400;
        int blue = 400;
        int bronze = 288;
        int silver = 96;
        int gold = 16;

        List<int> numberedList = new List<int>
        {
            white,
            tan,
            black,
            red,
            green,
            blue,
            bronze,
            silver,
            gold
         };

        List<int> additionList = CreateAdditionList(numberedList); //does the number addition for each tier (type 1, type1 + type2, etc)

        List<CloneType> styleListCO = new List<CloneType>
        {
            typeSkinWhiteRoundCO,
            typeSkinTanRoundCO,
            typeSkinBlackRoundCO,
            typeSkinRedRoundCO,
            typeSkinGreenRoundCO,
            typeSkinBlueRoundCO,
            typeSkinBronzeRoundCO,
            typeSkinSilverRoundCO,
            typeSkinGoldRoundCO
        };
        List<CloneType> styleListDD = new List<CloneType>
        {
            typeSkinWhiteRoundDD,
            typeSkinTanRoundDD,
            typeSkinBlackRoundDD,
            typeSkinRedRoundDD,
            typeSkinGreenRoundDD,
            typeSkinBlueRoundDD,
            typeSkinBronzeRoundDD,
            typeSkinSilverRoundDD,
            typeSkinGoldRoundDD
        };
        List<CloneType> styleListAM = new List<CloneType>
        {
            typeSkinWhiteAM,
            typeSkinTanAM,
            typeSkinBlackAM,
            typeSkinRedAM,
            typeSkinGreenAM,
            typeSkinBlueAM,
            typeSkinBronzeAM,
            typeSkinSilverAM,
            typeSkinGoldAM
        };

        List<CloneType> styleListRL = new List<CloneType>
        {
            typeSkinRoundRL,
            typeSkinRoundRL,
            typeSkinRoundRL,
            typeSkinRoundRL,
            typeSkinRoundRL,
            typeSkinRoundRL,
            typeSkinRoundRL,
            typeSkinRoundRL,
            typeSkinRoundRL
        };
        List<CloneType> styleListRR = new List<CloneType>
        {
            typeSkinRoundRR,
            typeSkinRoundRR,
            typeSkinRoundRR,
            typeSkinRoundRR,
            typeSkinRoundRR,
            typeSkinRoundRR,
            typeSkinRoundRR,
            typeSkinRoundRR,
            typeSkinRoundRR
        };
        List<CloneType> styleListAO = new List<CloneType>
        {
            typeSkinRoundAO,
            typeSkinRoundAO,
            typeSkinRoundAO,
            typeSkinRoundAO,
            typeSkinRoundAO,
            typeSkinRoundAO,
            typeSkinRoundAO,
            typeSkinRoundAO,
            typeSkinRoundAO
        };

        List<CloneType> styleListHL = new List<CloneType>
        {
            typeSkinWhiteRoundHL,
            typeSkinWhiteRoundHL,
            typeSkinWhiteRoundHL,
            typeSkinWhiteRoundHL,
            typeSkinWhiteRoundHL,
            typeSkinWhiteRoundHL,
            typeSkinWhiteRoundHL,
            typeSkinWhiteRoundHL,
            typeSkinWhiteRoundHL
        };


        List<CloneType> styleListRF = new List<CloneType>
        {
            typeSkinRoundRF,
            typeSkinRoundRF,
            typeSkinRoundRF,
            typeSkinRoundRF,
            typeSkinRoundRF,
            typeSkinRoundRF,
            typeSkinRoundRF,
            typeSkinRoundRF,
            typeSkinRoundRF
        };

        List<CloneType> styleListSS = new List<CloneType>
        {
            typeSkinRoundSS,
            typeSkinRoundSS,
            typeSkinRoundSS,
            typeSkinRoundSS,
            typeSkinRoundSS,
            typeSkinRoundSS,
            typeSkinRoundSS,
            typeSkinRoundSS,
            typeSkinRoundSS
        };

        List<List<CloneType>> listOfLists = new List<List<CloneType>>
        {
            styleListDD,//0
            styleListCO,//1
            styleListAM,//2
            styleListRL,//3
            styleListRR,//4
            styleListAO,//5
            styleListHL,//6
            styleListRF,//7
            styleListSS //8

        };

        GetWeightedResult(clone, cloneStyleName, layerDepth, listOfLists, additionList, false, requiresHairColour, thisHairColour);
        layerDepth++;

    }
    private void CreateEyeStyle(GameObject clone, string cloneStyleName, bool requiresHairColour, CloneType thisHairColour)
    {
        int round = 5000;
        int almond = 2500;
        int upturned = 2500;

        List<int> numberedList = new List<int>
        {
            round,
            almond,
            upturned
         };

        List<int> additionList = CreateAdditionList(numberedList); //does the number addition for each tier (type 1, type1 + type2, etc)

        List<CloneType> styleListCO = new List<CloneType>
        {
            typeEyeStyleRoundCO,
            typeEyeStyleAlmondCO,
            typeEyeStyleUpturnedCO,
        };
        List<CloneType> styleListDD = new List<CloneType>
        {
            typeEyeStyleRoundDD,
            typeEyeStyleAlmondDD,
            typeEyeStyleUpturnedDD,
        };
        List<CloneType> styleListAM = new List<CloneType>
        {
            typeEyeStyleRoundAM,
            typeEyeStyleAlmondAM,
            typeEyeStyleUpturnedAM,
        };
        List<CloneType> styleListRR = new List<CloneType>
        {
            typeEyeStyleRoundRR,
            typeEyeStyleAlmondRR,
            typeEyeStyleUpturnedRR,
        };
        List<CloneType> styleListCS = new List<CloneType>
        {
            typeEyeStyleRoundCS,
            typeEyeStyleAlmondCS,
            typeEyeStyleUpturnedCS,
        };

        List<CloneType> styleListAO = new List<CloneType>
        {
            typeEyeStyleRoundAO,
            typeEyeStyleAlmondAO,
            typeEyeStyleUpturnedAO,
        };

        List<CloneType> styleListRF = new List<CloneType>
        {
            typeEyeStyleRoundRF,
            typeEyeStyleAlmondRF,
            typeEyeStyleUpturnedRF,
        };

        List<List<CloneType>> listOfLists = new List<List<CloneType>>
        {
            styleListDD,
            styleListCO,
            styleListCS,
            styleListAM,
            styleListRR,
            styleListAO,
            styleListRF
        };

        GetWeightedResult(clone, cloneStyleName, layerDepth, listOfLists, additionList, false, requiresHairColour, thisHairColour);
        layerDepth++;
    }
    private void CreateEyelashStyle(GameObject clone, string cloneStyleName, bool requiresHairColour, CloneType thisHairColour)
    {
        int eyelashShort = 7500;
        int eyelashLong = 2500;


        List<int> numberedList = new List<int>
        {
            eyelashShort,
            eyelashLong
         };

        List<int> additionList = CreateAdditionList(numberedList); //does the number addition for each tier (type 1, type1 + type2, etc)

        List<CloneType> styleListCO = new List<CloneType>
        {
            typeEyelashStyleRoundShortCO,
            typeEyelashStyleRoundLongCO
        };

        List<CloneType> styleListDD = new List<CloneType>
        {
            typeEyelashStyleRoundShortDD,
            typeEyelashStyleRoundLongDD
        };

        List<List<CloneType>> listOfLists = new List<List<CloneType>>
        {
            styleListDD,
            styleListCO,
        };

        GetWeightedResult(clone, cloneStyleName, layerDepth, listOfLists, additionList, false, requiresHairColour, thisHairColour);
        layerDepth++;
    }    
    private void CreateEyeColour(GameObject clone, string cloneStyleName, bool requiresHairColour, CloneType thisHairColour)
    {
        int brown = 6000;
        int blue = 2500;
        int hazel = 1000;
        int green = 500;

        List<int> numberedList = new List<int>
        {
            brown,
            blue,
            hazel,
            green
         };

        List<int> additionList = CreateAdditionList(numberedList); //does the number addition for each tier (type 1, type1 + type2, etc)


        List<CloneType> styleListCO = new List<CloneType>
        {
            typeEyeColourBrownCO,
            typeEyeColourBlueCO,
            typeEyeColourHazelCO,
            typeEyeColourGreenCO
        };


        List<CloneType> styleListDD = new List<CloneType>
        {
            typeEyeColourBrownDD,
            typeEyeColourBlueDD,
            typeEyeColourHazelDD,
            typeEyeColourGreenDD
        };

        List<List<CloneType>> listOfLists = new List<List<CloneType>>
        {
            styleListDD,
            styleListCO
        };

        GetWeightedResult(clone, cloneStyleName, layerDepth, listOfLists, additionList, false, requiresHairColour, thisHairColour);
        layerDepth++;
    }
    private void CreateEyeSpec(GameObject clone, string cloneStyleName, bool requiresHairColour, CloneType thisHairColour)
    {
        int round = 5000;
        int square = 3000;
        int diamond = 1500;
        int heart = 490;
        int star = 10;

        List<int> numberedList = new List<int>
        {
            round,
            square,
            diamond,
            heart,
            star
         };

        List<int> additionList = CreateAdditionList(numberedList); //does the number addition for each tier (type 1, type1 + type2, etc)


        List<CloneType> styleListCO = new List<CloneType>
        {
            typeSpecRoundCO,
            typeSpecSquareCO,
            typeSpecDiamondCO,
            typeSpecHeartCO,
            typeSpecStarCO
        };

        List<CloneType> styleListDD = new List<CloneType>
        {
            typeSpecRoundDD,
            typeSpecSquareDD,
            typeSpecDiamondDD,
            typeSpecHeartDD,
            typeSpecStarDD
        };

        List<List<CloneType>> listOfLists = new List<List<CloneType>>
        {
            styleListDD,
            styleListCO
        };


        GetWeightedResult(clone, cloneStyleName, layerDepth, listOfLists, additionList, false, requiresHairColour, thisHairColour);
        layerDepth++;
    }
    private void CreateBeardStyle(GameObject clone, string cloneStyleName, bool requiresHairColour, CloneType thisHairColour)
    {
        int beardMustache = 500;
        int beardLong = 1500;
        int beardShort = 3000;
        int beardNone = 6000;


        List<int> numberedList = new List<int>
        {
            beardMustache,
            beardLong,
            beardShort,
            beardNone

         };

        List<int> additionList = CreateAdditionList(numberedList); //does the number addition for each tier (type 1, type1 + type2, etc)


        List<CloneType> styleListCO = new List<CloneType>
        {
            typeBeardStyleMustacheCO,
            typeBeardStyleLongCO,
            typeBeardStyleShortCO,
            typeBeardStyleNoneCO
        };

        List<CloneType> styleListDD = new List<CloneType>
        {
            typeBeardStyleMustacheDD,
            typeBeardStyleLongDD,
            typeBeardStyleShortDD,
            typeBeardStyleNoneDD
        };

        List<CloneType> styleListAM = new List<CloneType>
        {
            typeBeardStyleMustacheDD,
            typeBeardStyleLongDD,
            typeBeardStyleShortDD,
            typeBeardStyleNoneDD
        };

        List<CloneType> styleListCS = new List<CloneType>
        {
            typeBeardStyleMustacheCS,
            typeBeardStyleLongCS,
            typeBeardStyleShortCS,
            typeBeardStyleNoneCS
        };

        List<CloneType> styleListRR = new List<CloneType>
        {
            typeBeardStyleMustacheRR,
            typeBeardStyleLongRR,
            typeBeardStyleShortRR,
            typeBeardStyleNoneRR
        };

        List<CloneType> styleListRL = new List<CloneType>
        {
            typeBeardStyleMustacheRL,
            typeBeardStyleLongRL,
            typeBeardStyleShortRL,
            typeBeardStyleNoneRL
        };

        List<CloneType> styleListAO = new List<CloneType>
        {
            typeBeardStyleMustacheAO,
            typeBeardStyleLongAO,
            typeBeardStyleShortAO,
            typeBeardStyleNoneAO
        };

        List<CloneType> styleListRF = new List<CloneType>
        {
            typeBeardStyleMustacheRF,
            typeBeardStyleLongRF,
            typeBeardStyleShortRF,
            typeBeardStyleNoneRF
        };

        List<CloneType> styleListHL = new List<CloneType>
        {
            typeBeardStyleMustacheHL,
            typeBeardStyleLongHL,
            typeBeardStyleShortHL,
            typeBeardStyleNoneHL
        };

        List<List<CloneType>> listOfLists = new List<List<CloneType>>
        {
            styleListDD,//0
            styleListCO,//1
            styleListAM,//2
            styleListCS,//3
            styleListRR,//4
            styleListRL,//5
            styleListAO,//6
            styleListRF,//7
            styleListHL//8
        };



        GetWeightedResult(clone, cloneStyleName, layerDepth, listOfLists, additionList, false, requiresHairColour, thisHairColour);
        layerDepth++;
    }
    private void CreateBrowStyle(GameObject clone, string cloneStyleName, bool requiresHairColour, CloneType thisHairColour)
    {
        int thick = 6000;
        int thin = 3500;
        int monobrow = 500;

        List<int> numberedList = new List<int>
        {
            thick,
            thin,
            monobrow
         };

        List<int> additionList = CreateAdditionList(numberedList); //does the number addition for each tier (type 1, type1 + type2, etc)


        List<CloneType> styleListDD = new List<CloneType>
        {
            typeBrowThickDD,
            typeBrowThinDD,
            typeBrowMonobrowDD

        };

        List<CloneType> styleListCO = new List<CloneType>
        {
            typeBrowThickCO,
            typeBrowThinCO,
            typeBrowMonobrowCO
        };

        List<CloneType> styleListCS = new List<CloneType>
        {
            typeBrowThickCS,
            typeBrowThinCS,
            typeBrowMonobrowCS
        };

        List<CloneType> styleListAM = new List<CloneType>
        {
            typeBrowThickAM,
            typeBrowThinAM,
            typeBrowMonobrowAM
        };

        List<CloneType> styleListRR = new List<CloneType>
        {
            typeBrowThickRR,
            typeBrowThinRR,
            typeBrowMonobrowRR
        };

        List<CloneType> styleListAO = new List<CloneType>
        {
            typeBrowThickAO,
            typeBrowThinAO,
            typeBrowMonobrowAO
        };

        List<CloneType> styleListRF = new List<CloneType>
        {
            typeBrowThickRF,
            typeBrowThinRF,
            typeBrowMonobrowRF
        };

        List<CloneType> styleListHL = new List<CloneType>
        {
            typeBrowThickHL,
            typeBrowThinHL,
            typeBrowMonobrowHL
        };

        List<List<CloneType>> listOfLists = new List<List<CloneType>>
        {
            styleListDD, //0
            styleListCO, //1
            styleListCS, //2
            styleListAM, //3
            styleListRR, //4
            styleListAO,  //5
            styleListRF, //6
            styleListHL, //7
        };


        GetWeightedResult(clone, cloneStyleName, layerDepth, listOfLists, additionList, false, requiresHairColour, thisHairColour);
        layerDepth++;
    }
    private void CreateTeethStyle(GameObject clone, string cloneStyleName, bool requiresHairColour, CloneType thisHairColour)
    {
        int normal = 10000;

        List<int> numberedList = new List<int>
        {
            normal
         };

        List<int> additionList = CreateAdditionList(numberedList); //does the number addition for each tier (type 1, type1 + type2, etc)


        List<CloneType> styleListCO = new List<CloneType>
        {
            typeTeethStyleNormalCO
        };

        List<CloneType> styleListDD = new List<CloneType>
        {
            typeTeethStyleNormalDD
        };

        List<CloneType> styleListAO = new List<CloneType>
        {
            typeTeethStyleNormalAO
        };

        List<CloneType> styleListAM = new List<CloneType>
        {
            typeTeethStyleNormalAM
        };


        List<CloneType> styleListIL = new List<CloneType>
        {
            typeTeethStyleNormalIL
        };


        List<List<CloneType>> listOfLists = new List<List<CloneType>>
        {
            styleListDD, //0
            styleListCO, //1
            styleListIL, //2
            styleListAO, //3
            styleListAM //4
            
        };


        GetWeightedResult(clone, cloneStyleName, layerDepth, listOfLists, additionList, false, requiresHairColour, thisHairColour);
        layerDepth++;
    }
    private void CreateTongueStyle(GameObject clone, string cloneStyleName, bool requiresHairColour, CloneType thisHairColour)
    {
        int normal = 10000;
        //int dog = 2000;

        List<int> numberedList = new List<int>
        {
            normal//,
            //dog
         };

        List<int> additionList = CreateAdditionList(numberedList); //does the number addition for each tier (type 1, type1 + type2, etc)


        List<CloneType> styleListCO = new List<CloneType>
        {
            typeTongueStyleNormalCO//,
            //typeTongueStyleDogCO
        };

        List<CloneType> styleListDD = new List<CloneType>
        {
            typeTongueStyleNormalDD//,
            //typeTongueStyleDogDD
        };

        List<CloneType> styleListAO = new List<CloneType>
        {
            typeTongueStyleNormalAO//,
            //typeTongueStyleDogAO
        };

        List<CloneType> styleListAM = new List<CloneType>
        {
            typeTongueStyleNormalAM//,
            //typeTongueStyleDogAM
        };

        List<CloneType> styleListGD = new List<CloneType>
        {
            typeTongueStyleNormalGD//,
            //typeTongueStyleDogGD
        };

        List<List<CloneType>> listOfLists = new List<List<CloneType>>
        {
            styleListDD,
            styleListCO,
            styleListAO,
            styleListAM,
            styleListGD
        };


        GetWeightedResult(clone, cloneStyleName, layerDepth, listOfLists, additionList, false, requiresHairColour, thisHairColour);
        layerDepth++;

    }
    private void CreateMouthbagStyle(GameObject clone, string cloneStyleName, bool requiresHairColour, CloneType thisHairColour)
    {
        int normal = 10000;

        List<int> numberedList = new List<int>
        {
            normal

         };

        List<int> additionList = CreateAdditionList(numberedList); //does the number addition for each tier (type 1, type1 + type2, etc)


        List<CloneType> styleListCO = new List<CloneType>
        {
            typeMouthbagNormalCO
        };

        List<CloneType> styleListDD = new List<CloneType>
        {
            typeMouthbagNormalDD
        };

        List<List<CloneType>> listOfLists = new List<List<CloneType>>
        {
            styleListDD,
            styleListCO
        };


        GetWeightedResult(clone, cloneStyleName, layerDepth, listOfLists, additionList, false, requiresHairColour, thisHairColour);
        layerDepth++;

    }
    private void CreateHairStyle(GameObject clone, string cloneStyleName, bool requiresHairColour, CloneType thisHairColour)
    {
        int hairStyleLBun = 500;
        int hairStyleLCurly = 500;
        int hairStyleLDreads = 500;
        int hairStyleLMohawk = 500;
        int hairStyleLPonytail = 500;
        int hairStyleLStraight = 500;

        int hairStyleMAfro = 500;
        int hairStyleMDreads = 500;
        int hairStyleMMessy = 500;
        int hairStyleMMohawk = 500;
        int hairStyleMParting = 500;
        int hairStyleMPigtails = 500;
        int hairStyleMPonytail = 500;
        int hairStyleMQuif = 500;
        int hairStyleMSpiked = 500;

        int hairStyleSAfro = 500;
        int hairStyleSBald = 500;
        int hairStyleSCharles = 500;
        int hairStyleSMonk = 500;
        int hairStyleSStubble = 500;

        List<int> numberedList = new List<int>
        {
            hairStyleLBun,
            hairStyleLCurly,
            hairStyleLDreads,
            hairStyleLMohawk,
            hairStyleLPonytail,
            hairStyleLStraight,

            hairStyleMAfro,
            hairStyleMDreads,
            hairStyleMMessy,
            hairStyleMMohawk,
            hairStyleMParting,
            hairStyleMPigtails,
            hairStyleMPonytail,
            hairStyleMQuif,
            hairStyleMSpiked,

            hairStyleSAfro,
            hairStyleSBald,
            hairStyleSCharles,
            hairStyleSMonk,
            hairStyleSStubble
        };

        List<int> additionList = CreateAdditionList(numberedList); //does the number addition for each tier (type 1, type1 + type2, etc)

        List<CloneType> styleListCO = new List<CloneType>
        {
            typeHairStyleLBunCO,
            typeHairStyleLCurlyCO,
            typeHairStyleLDreadsCO,
            typeHairStyleLMohawkCO,
            typeHairStyleLPonytailCO,
            typeHairStyleLStraightCO,

            typeHairStyleMAfroCO,
            typeHairStyleMDreadsCO,
            typeHairStyleMMessyCO,
            typeHairStyleMMohawkCO,
            typeHairStyleMPartingCO,
            typeHairStyleMPigtailsCO,
            typeHairStyleMPonytailCO,
            typeHairStyleMQuifCO,
            typeHairStyleMSpikedCO,

            typeHairStyleSAfroCO,
            typeHairStyleSBaldCO,
            typeHairStyleSCharlesCO,
            typeHairStyleSMonkCO,
            typeHairStyleSStubbleCO
        };

        List<CloneType> styleListDD = new List<CloneType>
        {
            typeHairStyleLBunDD,
            typeHairStyleLCurlyDD,
            typeHairStyleLDreadsDD,
            typeHairStyleLMohawkDD,
            typeHairStyleLPonytailDD,
            typeHairStyleLStraightDD,

            typeHairStyleMAfroDD,
            typeHairStyleMDreadsDD,
            typeHairStyleMMessyDD,
            typeHairStyleMMohawkDD,
            typeHairStyleMPartingDD,
            typeHairStyleMPigtailsDD,
            typeHairStyleMPonytailDD,
            typeHairStyleMQuifDD,
            typeHairStyleMSpikedDD,

            typeHairStyleSAfroDD,
            typeHairStyleSBaldDD,
            typeHairStyleSCharlesDD,
            typeHairStyleSMonkDD,
            typeHairStyleSStubbleDD
        };

        List<CloneType> styleListCS = new List<CloneType>
        {
            typeHairStyleLBunCS,
            typeHairStyleLCurlyCS,
            typeHairStyleLDreadsCS,
            typeHairStyleLMohawkCS,
            typeHairStyleLPonytailCS,
            typeHairStyleLStraightCS,

            typeHairStyleMAfroCS,
            typeHairStyleMDreadsCS,
            typeHairStyleMMessyCS,
            typeHairStyleMMohawkCS,
            typeHairStyleMPartingCS,
            typeHairStyleMPigtailsCS,
            typeHairStyleMPonytailCS,
            typeHairStyleMQuifCS,
            typeHairStyleMSpikedCS,

            typeHairStyleSAfroCS,
            typeHairStyleSBaldCS,
            typeHairStyleSCharlesCS,
            typeHairStyleSMonkCS,
            typeHairStyleSStubbleCS
        };

        List<CloneType> styleListAO = new List<CloneType>
        {
            typeHairStyleLBunAO,
            typeHairStyleLCurlyAO,
            typeHairStyleLDreadsAO,
            typeHairStyleLMohawkAO,
            typeHairStyleLPonytailAO,
            typeHairStyleLStraightAO,

            typeHairStyleMAfroAO,
            typeHairStyleMDreadsAO,
            typeHairStyleMMessyAO,
            typeHairStyleMMohawkAO,
            typeHairStyleMPartingAO,
            typeHairStyleMPigtailsAO,
            typeHairStyleMPonytailAO,
            typeHairStyleMQuifAO,
            typeHairStyleMSpikedAO,

            typeHairStyleSAfroAO,
            typeHairStyleSBaldAO,
            typeHairStyleSCharlesAO,
            typeHairStyleSMonkAO,
            typeHairStyleSStubbleAO
        };

        List<CloneType> styleListAM = new List<CloneType>
        {
            typeHairStyleLBunAM,
            typeHairStyleLCurlyAM,
            typeHairStyleLDreadsAM,
            typeHairStyleLMohawkAM,
            typeHairStyleLPonytailAM,
            typeHairStyleLStraightAM,
            typeHairStyleMAfroAM,
            typeHairStyleMDreadsAM,
            typeHairStyleMMessyAM,
            typeHairStyleMMohawkAM,
            typeHairStyleMPartingAM,
            typeHairStyleMPigtailsAM,
            typeHairStyleMPonytailAM,
            typeHairStyleMQuifAM,
            typeHairStyleMSpikedAM,
            typeHairStyleSAfroAM,
            typeHairStyleSBaldAM,
            typeHairStyleSCharlesAM,
            typeHairStyleSMonkAM,
            typeHairStyleSStubbleAM
        };

        List<CloneType> styleListIL = new List<CloneType>
        {
            typeHairStyleLBunIL,
            typeHairStyleLCurlyIL,
            typeHairStyleLDreadsIL,
            typeHairStyleLMohawkIL,
            typeHairStyleLPonytailIL,
            typeHairStyleLStraightIL,
            typeHairStyleMAfroIL,
            typeHairStyleMDreadsIL,
            typeHairStyleMMessyIL,
            typeHairStyleMMohawkIL,
            typeHairStyleMPartingIL,
            typeHairStyleMPigtailsIL,
            typeHairStyleMPonytailIL,
            typeHairStyleMQuifIL,
            typeHairStyleMSpikedIL,
            typeHairStyleSAfroIL,
            typeHairStyleSBaldIL,
            typeHairStyleSCharlesIL,
            typeHairStyleSMonkIL,
            typeHairStyleSStubbleIL
        };

        List<CloneType> styleListRL = new List<CloneType>
        {
            typeHairStyleLBunRL,
            typeHairStyleLCurlyRL,
            typeHairStyleLDreadsRL,
            typeHairStyleLMohawkRL,
            typeHairStyleLPonytailRL,
            typeHairStyleLStraightRL,
            typeHairStyleMAfroRL,
            typeHairStyleMDreadsRL,
            typeHairStyleMMessyRL,
            typeHairStyleMMohawkRL,
            typeHairStyleMPartingRL,
            typeHairStyleMPigtailsRL,
            typeHairStyleMPonytailRL,
            typeHairStyleMQuifRL,
            typeHairStyleMSpikedRL,
            typeHairStyleSAfroRL,
            typeHairStyleSBaldRL,
            typeHairStyleSCharlesRL,
            typeHairStyleSMonkRL,
            typeHairStyleSStubbleRL
        };

        List<CloneType> styleListRR = new List<CloneType>
        {
            typeHairStyleLBunRR,
            typeHairStyleLCurlyRR,
            typeHairStyleLDreadsRR,
            typeHairStyleLMohawkRR,
            typeHairStyleLPonytailRR,
            typeHairStyleLStraightRR,
            typeHairStyleMAfroRR,
            typeHairStyleMDreadsRR,
            typeHairStyleMMessyRR,
            typeHairStyleMMohawkRR,
            typeHairStyleMPartingRR,
            typeHairStyleMPigtailsRR,
            typeHairStyleMPonytailRR,
            typeHairStyleMQuifRR,
            typeHairStyleMSpikedRR,
            typeHairStyleSAfroRR,
            typeHairStyleSBaldRR,
            typeHairStyleSCharlesRR,
            typeHairStyleSMonkRR,
            typeHairStyleSStubbleRR
        };

        List<CloneType> styleListRF = new List<CloneType>
        {
            typeHairStyleLBunRF,
            typeHairStyleLCurlyRF,
            typeHairStyleLDreadsRF,
            typeHairStyleLMohawkRF,
            typeHairStyleLPonytailRF,
            typeHairStyleLStraightRF,
            typeHairStyleMAfroRF,
            typeHairStyleMDreadsRF,
            typeHairStyleMMessyRF,
            typeHairStyleMMohawkRF,
            typeHairStyleMPartingRF,
            typeHairStyleMPigtailsRF,
            typeHairStyleMPonytailRF,
            typeHairStyleMQuifRF,
            typeHairStyleMSpikedRF,
            typeHairStyleSAfroRF,
            typeHairStyleSBaldRF,
            typeHairStyleSCharlesRF,
            typeHairStyleSMonkRF,
            typeHairStyleSStubbleRF
        };

        List<CloneType> styleListHL = new List<CloneType>
        {
            typeHairStyleLBunHL,
            typeHairStyleLCurlyHL,
            typeHairStyleLDreadsHL,
            typeHairStyleLMohawkHL,
            typeHairStyleLPonytailHL,
            typeHairStyleLStraightHL,
            typeHairStyleMAfroHL,
            typeHairStyleMDreadsHL,
            typeHairStyleMMessyHL,
            typeHairStyleMMohawkHL,
            typeHairStyleMPartingHL,
            typeHairStyleMPigtailsHL,
            typeHairStyleMPonytailHL,
            typeHairStyleMQuifHL,
            typeHairStyleMSpikedHL,
            typeHairStyleSAfroHL,
            typeHairStyleSBaldHL,
            typeHairStyleSCharlesHL,
            typeHairStyleSMonkHL,
            typeHairStyleSStubbleHL
        };

        List<List<CloneType>> listOfLists = new List<List<CloneType>>
        {
            styleListDD,//0
            styleListCO,//1
            styleListCS,//2           
            styleListAM,//3
            styleListIL,//4
            styleListRL,//5
            styleListRR,//6
            styleListRF,//7
            styleListHL,//8
            styleListAO,//9
        };

        GetWeightedResult(clone, cloneStyleName, layerDepth, listOfLists, additionList, false, requiresHairColour, thisHairColour);
        layerDepth++;
    }

    // ========        MAIN ACTION        ========
    // Chooses a Clone attribute, depending on the weighted chance perameters

    private CloneType GetWeightedResult(GameObject clone, string name, int layerDepth, List<List<CloneType>> listOfLists, List<int> styleTypes, bool settingCloneHairColour, bool takesHairColour, CloneType thisHairColour)
    {
        int randomNumber = GetRandomNumber(CloneAmount); // gets a random number with the max as an input
        CloneType thisCloneType = null;

        float imageLayerOffset = 0f;
        for (int j = 0; j < listOfLists.Count; j++)
        {
            thisCloneType = listOfLists[0][0]; //the type that is applied after the if statments

            for (int i = 0; i < styleTypes.Count; i++)
            {
                //If it is the first style type on the list
                if (i == 0)
                {
                    if (randomNumber < styleTypes[0])
                    {
                        thisCloneType = listOfLists[j][0];
                    }
                    else if (randomNumber > styleTypes[styleTypes.Count - 1])
                    {
                        thisCloneType = listOfLists[j][styleTypes.Count - 1];
                    }
                    else if (randomNumber > styleTypes[1] & randomNumber < styleTypes[i + 1])
                    {
                        thisCloneType = listOfLists[j][i];
                    }
                }

                //If it is the last style type on the list
                else if (i == styleTypes.Count - 1)
                {
                    if (randomNumber > styleTypes[styleTypes.Count - 2]) // THIS COULD BREAK IF WE OVERCOUNT
                    {
                        thisCloneType = listOfLists[j][styleTypes.Count - 1];
                    }
                }

                //If it is intermediary style type on the list
                else if (randomNumber > styleTypes[i - 1] & randomNumber < styleTypes[i + 1])
                {
                    thisCloneType = listOfLists[j][i];
                }
            }

            if (!settingCloneHairColour)
            {
                GameObject thisImageLayer = new GameObject(name);
                thisImageLayer.transform.parent = clone.transform;
                thisImageLayer.transform.position = new Vector3(0, 0, -layerDepth - imageLayerOffset);
                thisImageLayer.AddComponent<SpriteRenderer>();

                thisImageLayer.GetComponent<SpriteRenderer>().sprite = thisCloneType.image;
                if (j == 0)
                {
                    PopulateCloneDetails(thisCloneType, clone); // Sends details to the Clone Details card
                    FinalTally(thisCloneType); // sends details to the final tally (global stats card)
                }

                if (j == 1)
                {
                    if (takesHairColour)
                    {
                        thisImageLayer.GetComponent<SpriteRenderer>().material = thisHairColour.material;
                        thisHairColour.material.mainTexture = thisCloneType.image.texture;

                    }

                    else
                    {
                        thisImageLayer.GetComponent<SpriteRenderer>().material = thisCloneType.material;
                    }
                }

                else
                {
                    thisImageLayer.GetComponent<SpriteRenderer>().material = thisCloneType.material;
                }

                //CAST SHADOW MOVE
                if (j == 2 && thisCloneType.type == CloneType.CloneFeature.HairStyle) //If it is the Cast Shadow Layer it will be placed in the skin layer
                {
                    thisImageLayer.transform.position = new Vector3(0, 0, -4.15f);
                }
                else if (j == 2 && thisCloneType.type == CloneType.CloneFeature.EyeStyle) //If it is the Cast Shadow Layer it will be placed in the skin layer
                {
                    if (clone.GetComponent<CloneDetails>().eyeStyle == "upturned")
                    {
                        thisImageLayer.SetActive(false);
                    }
                    else
                    {
                        //Debug.Log("moving eye shadow layer");
                        thisImageLayer.transform.position = new Vector3(0, 0, -4.05f);
                    }

                }
                else if (j == 2 && thisCloneType.type == CloneType.CloneFeature.EyebrowStyle)
                {
                    thisImageLayer.transform.position = new Vector3(0, 0, -4.1f);
                }

                // SKIN
                if (thisCloneType.type == CloneType.CloneFeature.SkinColour)
                {
                    // DD
                    if (j == 0)
                    {
                        for (int k = 0; k < skinColourList.Count; k++)
                        {
                            if (clone.GetComponent<CloneDetails>().skinColour == skinColourList[k])
                            {
                                for (int l = 0; l < eyeTypeList.Count; l++)
                                {
                                    if (clone.GetComponent<CloneDetails>().eyeStyle == eyeTypeList[l])
                                    {
                                        thisImageLayer.GetComponent<SpriteRenderer>().sprite = eyeTypeSpriteDDList[l];
                                    }
                                }
                            }
                        }
                    }
                    // CO
                    if (j == 1)
                    {
                        for (int k = 0; k < skinColourList.Count; k++)
                        {
                            if (clone.GetComponent<CloneDetails>().skinColour == skinColourList[k])
                            {
                                for (int l = 0; l < eyeTypeList.Count; l++)
                                {
                                    if (clone.GetComponent<CloneDetails>().eyeStyle == eyeTypeList[l])
                                    {
                                        thisImageLayer.GetComponent<SpriteRenderer>().sprite = skinTypeSpriteCOList[CalculateMultiList(3, k, l)];
                                    }
                                }
                            }
                        }
                    }
                    // AM
                    if (j == 2)
                    {
                        for (int k = 0; k < skinColourList.Count; k++)
                        {
                            if (clone.GetComponent<CloneDetails>().skinColour == skinColourList[k])
                            {
                                thisImageLayer.GetComponent<SpriteRenderer>().material = skinTypeMatAMList[k];

                                for (int l = 0; l < eyeTypeList.Count; l++)
                                {
                                    if (clone.GetComponent<CloneDetails>().eyeStyle == eyeTypeList[l])
                                    {
                                        thisImageLayer.GetComponent<SpriteRenderer>().sprite = eyeTypeSpriteDDList[l];
                                    }
                                }
                            }
                        }

                    }
                    // RR
                    if (j == 4)
                    {
                        for (int k = 0; k < eyeTypeList.Count; k++)
                        {
                            if (clone.GetComponent<CloneDetails>().eyeStyle == eyeTypeList[k])
                            {
                                thisImageLayer.GetComponent<SpriteRenderer>().sprite = skinTypeSpriteRRList[k];
                            }
                        }
                    }
                    // AO
                    if (j == 5)
                    {
                        for (int k = 0; k < eyeTypeList.Count; k++)
                        {
                            if (clone.GetComponent<CloneDetails>().eyeStyle == eyeTypeList[k])
                            {
                                thisImageLayer.GetComponent<SpriteRenderer>().sprite = skinTypeSpriteAOList[k];
                            }
                        }
                    }
                    // HL
                    if (j == 6)
                    {
                        for (int k = 0; k < skinColourList.Count; k++)
                        {
                            if (clone.GetComponent<CloneDetails>().skinColour == skinColourList[k])
                            {
                                thisImageLayer.GetComponent<SpriteRenderer>().material = skinTypeMatHLList[k];

                                for (int l = 0; l < eyeTypeList.Count; l++)
                                {
                                    if (clone.GetComponent<CloneDetails>().eyeStyle == eyeTypeList[l])
                                    {
                                        thisImageLayer.GetComponent<SpriteRenderer>().sprite = skinTypeSpriteHLList[l];
                                    }
                                }
                            }
                        }
                    }
                    // RF
                    if (j == 7)
                    {
                        for (int k = 0; k < eyeTypeList.Count; k++)
                        {
                            if (clone.GetComponent<CloneDetails>().eyeStyle == eyeTypeList[k])
                            {
                                thisImageLayer.GetComponent<SpriteRenderer>().sprite = skinTypeSpriteRFList[k];
                            }
                        }
                    }

                }
                // HAIR
                if (thisCloneType.type == CloneType.CloneFeature.HairStyle)
                {
                    // AM
                    if (j == 3)
                    {
                        for (int k = 0; k < hairColourList.Count; k++)
                        {
                            if (clone.GetComponent<CloneDetails>().hairColour == hairColourList[k])
                            {
                                thisImageLayer.GetComponent<SpriteRenderer>().material = hairColourMatAMList[k];
                                for (int l = 0; l < hairTypeList.Count; l++)
                                {
                                    if (clone.GetComponent<CloneDetails>().hairStyle == hairTypeList[l])
                                    {
                                        thisImageLayer.GetComponent<SpriteRenderer>().sprite = hairTypeSpriteDDList[l];
                                    }
                                }
                            }
                        }
                    }
                    // HL
                    if (j == 8)
                    {
                        for (int k = 0; k < hairColourList.Count; k++)
                        {
                            if (clone.GetComponent<CloneDetails>().hairColour == hairColourList[k])
                            {
                                thisImageLayer.GetComponent<SpriteRenderer>().material = hairColourMatHLList[k];
                            }
                        }
                    }

                }
                // BROW
                if (thisCloneType.type == CloneType.CloneFeature.EyebrowStyle)
                {
                    // AM
                    if (j == 3)
                    {
                        for (int k = 0; k < browTypeList.Count; k++)
                        {
                            if (clone.GetComponent<CloneDetails>().browStyle == browTypeList[k])
                            {
                                thisImageLayer.GetComponent<SpriteRenderer>().sprite = browTypeSpriteDDList[k];

                                for (int l = 0; l < hairColourList.Count; l++)
                                {
                                    if (clone.GetComponent<CloneDetails>().hairColour == hairColourList[l])
                                    {
                                        thisImageLayer.GetComponent<SpriteRenderer>().material = hairColourMatAMList[l];
                                    }
                                }
                            }
                        }
                    }

                    // HL
                    if (j == 7)
                    {
                        for (int k = 0; k < hairColourList.Count; k++)
                        {
                            if (clone.GetComponent<CloneDetails>().hairColour == hairColourList[k])
                            {
                                thisImageLayer.GetComponent<SpriteRenderer>().material = hairColourMatHLList[k];
                            }
                        }
                    }

                    // HL
                    /*if (j == 6)
                    {
                        for (int k = 0; k < browTypeList.Count; k++)
                        {
                            if (clone.GetComponent<CloneDetails>().browStyle == browTypeList[k])
                            {
                                thisImageLayer.GetComponent<SpriteRenderer>().sprite = browTypeSpriteHLList[k];

                                for (int l = 0; l < hairColourList.Count; l++)
                                {
                                    if (clone.GetComponent<CloneDetails>().hairColour == hairColourList[l])
                                    {
                                        thisImageLayer.GetComponent<SpriteRenderer>().material = hairColourMatHLList[l];
                                    }
                                }
                            }
                        }
                    }
                    */
                }
                // BEARD
                if (thisCloneType.type == CloneType.CloneFeature.BeardStyle)
                {
                    // AM
                    if (j == 2)
                    {
                        for (int k = 0; k < beardTypeList.Count; k++)
                        {
                            if (clone.GetComponent<CloneDetails>().beardStyle == beardTypeList[k])
                            {
                                thisImageLayer.GetComponent<SpriteRenderer>().sprite = beardTypeSpriteDDList[k];

                                for (int l = 0; l < hairColourList.Count; l++)
                                {
                                    if (clone.GetComponent<CloneDetails>().hairColour == hairColourList[l])
                                    {
                                        thisImageLayer.GetComponent<SpriteRenderer>().material = hairColourMatAMList[l];
                                    }
                                }
                            }
                        }
                    }
                    // HL
                    if (j == 8)
                    {
                        for (int k = 0; k < hairColourList.Count; k++)
                        {
                            if (clone.GetComponent<CloneDetails>().hairColour == hairColourList[k])
                            {
                                thisImageLayer.GetComponent<SpriteRenderer>().material = hairColourMatHLList[k];
                            }
                        }
                    }
                }
                // EYE
                if (thisCloneType.type == CloneType.CloneFeature.EyeStyle)
                {
                    // AM
                    if (j == 3)
                    {
                        for (int k = 0; k < eyeTypeList.Count; k++)
                        {
                            if (clone.GetComponent<CloneDetails>().eyeStyle == eyeTypeList[k])
                            {
                                thisImageLayer.GetComponent<SpriteRenderer>().material = skinAM.material;
                                thisImageLayer.GetComponent<SpriteRenderer>().sprite = eyeTypeSpriteCOList[k];
                            }
                        }
                    }
                }
                // LASHES
                if (thisCloneType.type == CloneType.CloneFeature.LashStyle)
                {
                    // DD
                    if (j == 0)
                    {
                        for (int k = 0; k < eyeTypeList.Count; k++)
                        {
                            if (clone.GetComponent<CloneDetails>().eyeStyle == eyeTypeList[k])
                            {
                                for (int l = 0; l < lashTypeList.Count; l++)
                                {
                                    if (clone.GetComponent<CloneDetails>().lashStyle == lashTypeList[l])
                                    {
                                        thisImageLayer.GetComponent<SpriteRenderer>().sprite = lashTypeSpriteDDList[CalculateMultiList(2, k, l)];
                                    }
                                }

                            }
                        }
                    }

                    //CO
                    if (j == 1)
                    {
                        for (int k = 0; k < eyeTypeList.Count; k++)
                        {
                            if (clone.GetComponent<CloneDetails>().eyeStyle == eyeTypeList[k])
                            {
                                for (int l = 0; l < lashTypeList.Count; l++)
                                {
                                    if (clone.GetComponent<CloneDetails>().lashStyle == lashTypeList[l])
                                    {
                                        thisImageLayer.GetComponent<SpriteRenderer>().sprite = lashTypeSpriteCOList[CalculateMultiList(2, k, l)];
                                    }
                                }

                            }
                        }
                    }
                }
                // TEETH
                if (thisCloneType.type == CloneType.CloneFeature.TeethStyle)
                {
                    //AM
                    if (j == 4)
                    {
                        thisImageLayer.GetComponent<SpriteRenderer>().sprite = typeTeethStyleNormalDD.image;
                    }
                }

                imageLayerOffset = imageLayerOffset + 0.1f; //Offsets the sub layer (eg. AO, IL, RR)

                AddLayerTypeToName(thisImageLayer, listOfLists[j][0].name); //renames the game object to have AO, DD at the end

                }
            

        }
        if (settingCloneHairColour)
        {
            PopulateCloneDetails(thisCloneType, clone);
            FinalTally(thisCloneType);
            return thisCloneType; // returns only if an image layer doesn't need to be created, like with the hair colour initialisation step          
        }

        else return null;
    }

    //========    UTILITIES    ========

    private List<int> CreateAdditionList(List<int> additionList)
    {
        List<int> newList = new List<int> {};
        int lastNumber = 0;
        for (int i = 0; i < additionList.Count; i++)
        {
            int thisNumber = lastNumber + additionList[i];
            newList.Add(thisNumber);
            lastNumber = thisNumber;
        }
        return newList;
    }   //  adds together the style numbers into an odds chart
    private void PopulateCloneDetails(CloneType thisCloneType, GameObject clone) // populates the clone details card that exists on each clone.
    {
        if (thisCloneType.type == CloneType.CloneFeature.SkinColour)
        {
            string thisString = thisCloneType.featureName;
            thisString = RemoveString(thisString, " DD");
            thisString = thisString.Substring(12);
            clone.GetComponent<CloneDetails>().skinColour = thisString;
        }

        else if (thisCloneType.type == CloneType.CloneFeature.BeardStyle)
        {
            string thisString = thisCloneType.featureName;
            thisString = RemoveString(thisString, " DD");
            thisString = thisString.Substring(6);
            clone.GetComponent<CloneDetails>().beardStyle = thisString;
        }           

        else if (thisCloneType.type == CloneType.CloneFeature.EyebrowStyle)
        {
            string thisString = thisCloneType.featureName;
            thisString = RemoveString(thisString, " DD");
            thisString = thisString.Substring(11);

            clone.GetComponent<CloneDetails>().browStyle = thisString;
        }            

        else if (thisCloneType.type == CloneType.CloneFeature.EyeColour)
        {
            string thisString = thisCloneType.featureName;
            thisString = RemoveString(thisString, " DD");
            thisString = thisString.Substring(5);
            clone.GetComponent<CloneDetails>().eyeColour = thisString;
        }            

        else if (thisCloneType.type == CloneType.CloneFeature.EyeSpecStyle)
        {
            string thisString = thisCloneType.featureName;
            thisString = RemoveString(thisString, " DD");
            thisString = thisString.Substring(11);
            clone.GetComponent<CloneDetails>().eyeSpecStyle = thisString;
        }


        else if (thisCloneType.type == CloneType.CloneFeature.EyeStyle)
        {
            string thisString = thisCloneType.featureName;
            thisString = RemoveString(thisString, " DD");
            thisString = thisString.Substring(10);
            clone.GetComponent<CloneDetails>().eyeStyle = thisString;
        }
           
        else if (thisCloneType.type == CloneType.CloneFeature.HairColour)
        {
            //Debug.Log(thisCloneType.featureName);
            string thisString = thisCloneType.featureName;
            thisString = RemoveString(thisString, " C");
            thisString = thisString.Substring(12);
            clone.GetComponent<CloneDetails>().hairColour = thisString;
        }
            

        else if (thisCloneType.type == CloneType.CloneFeature.HairStyle)
        {
            string thisString = thisCloneType.featureName;
            thisString = RemoveString(thisString, " DD");
            thisString = thisString.Substring(10);
            clone.GetComponent<CloneDetails>().hairStyle = thisString;
        }
            

        else if (thisCloneType.type == CloneType.CloneFeature.LashStyle)
        {
            string thisString = thisCloneType.featureName;
            thisString = RemoveString(thisString, " DD");
            thisString = thisString.Substring(7);
            clone.GetComponent<CloneDetails>().lashStyle = thisString;
        }
            

        else if (thisCloneType.type == CloneType.CloneFeature.TeethStyle)
        {
            string thisString = thisCloneType.featureName;
            thisString = RemoveString(thisString, " DD");
            thisString = thisString.Substring(12);
            clone.GetComponent<CloneDetails>().teethStyle = thisString;
        }
            

        else if (thisCloneType.type == CloneType.CloneFeature.TongueStyle)
        {
            string thisString = thisCloneType.featureName;
            thisString = RemoveString(thisString," DD");
            thisString = thisString.Substring(13);
            clone.GetComponent<CloneDetails>().tongueStyle = thisString;
        }       
    }
    private void FinalTally(CloneType thisCloneType)
    {
        string thisString = thisCloneType.featureName;
        string typeString;

        typeString = thisCloneType.type.ToString();

        FinalTallyObject.GetComponent<CloneFinalTally>().AddToTally(thisString, typeString);
    }
    private string RemoveString(string thisString, string stringToRemove)
    {       
        thisString = thisString.Substring(0, thisString.LastIndexOf(stringToRemove));
        return thisString;
    }
    private int GetRandomNumber(int amount)
    {
        Random.InitState(RandomSeed);
        int thisNumber = Random.Range(0, amount);
        RandomSeed++;
        return thisNumber;
    }     // generate a random number
    private void AddLayerTypeToName(GameObject thisImageLayer, string layerType)
    {
        string substr = layerType.Substring(layerType.Length - 2);
        thisImageLayer.name += " " + substr;
    }
    private int CalculateMultiList(int numberOfTypes, int listTop, int listBottom)
    {
        int answer = ((numberOfTypes * (listTop + 1)) - numberOfTypes) + (listBottom + 1) - 1;
        return answer;
    }
    private void FillDescriptionLists()
    {
        skinColourList = new List<string>
        {
            "white",
            "tan",
            "black",           
            "red",
            "green",
            "blue",
            "bronze",
            "silver",
            "gold",
        };

        skinTypeMatAMList = new List<Material>
        {
            matSkinWhiteAM,
            matSkinTanAM,
            matSkinBlackAM,
            matSkinRedAM,
            matSkinGreenAM,
            matSkinBlueAM,
            matSkinBronzeAM,
            matSkinSilverAM,
            matSkinGoldAM
        };

        skinTypeMatHLList = new List<Material>
        {
            typeSkinWhiteRoundHL.material,
            typeSkinTanRoundHL.material,
            typeSkinBlackRoundHL.material,
            typeSkinRedRoundHL.material,
            typeSkinGreenRoundHL.material,
            typeSkinBlueRoundHL.material,
            typeSkinBronzeRoundHL.material,
            typeSkinSilverRoundHL.material,
            typeSkinGoldRoundHL.material,
        };

        skinTypeSpriteCOList = new List<Sprite>
        {
            typeSkinWhiteRoundCO.image, 
            typeSkinWhiteAlmondCO.image,
            typeSkinWhiteUpturnedCO.image, 
            typeSkinTanRoundCO.image, 
            typeSkinTanAlmondCO.image,
            typeSkinTanUpturnedCO.image, 
            typeSkinBlackRoundCO.image, 
            typeSkinBlackAlmondCO.image, 
            typeSkinBlackUpturnedCO.image, 
            typeSkinRedRoundCO.image,
            typeSkinRedAlmondCO.image,
            typeSkinRedUpturnedCO.image, 
            typeSkinGreenRoundCO.image, 
            typeSkinGreenAlmondCO.image, 
            typeSkinGreenUpturnedCO.image, 
            typeSkinBlueRoundCO.image,
            typeSkinBlueAlmondCO.image,
            typeSkinBlueUpturnedCO.image,
            typeSkinBronzeRoundCO.image,
            typeSkinBronzeAlmondCO.image,
            typeSkinBronzeUpturnedCO.image,
            typeSkinSilverRoundCO.image,
            typeSkinSilverAlmondCO.image,
            typeSkinSilverUpturnedCO.image,
            typeSkinGoldRoundCO.image,
            typeSkinGoldAlmondCO.image,
            typeSkinGoldUpturnedCO.image,
        };

        skinTypeSpriteRRList = new List<Sprite>
        {
            typeSkinRoundRR.image,
            typeSkinAlmondRR.image,
            typeSkinUpturnedRR.image
        };

        skinTypeSpriteAOList = new List<Sprite>
        {
            typeSkinRoundAO.image,
            typeSkinAlmondAO.image,
            typeSkinUpturnedAO.image
        };

        skinTypeSpriteHLList = new List<Sprite>
        {
            typeSkinWhiteRoundHL.image,
            typeSkinWhiteAlmondHL.image,
            typeSkinWhiteUpturnedHL.image,
        };

        skinTypeSpriteRFList = new List<Sprite>
        {
            typeSkinRoundRF.image,
            typeSkinAlmondRF.image,
            typeSkinUpturnedRF.image,
        };

        eyeTypeList = new List<string>
        {
            "round",
            "almond",
            "upturned"
        };

        eyeTypeSpriteDDList = new List<Sprite>
        {
            typeSkinWhiteRoundDD.image,
            typeSkinWhiteAlmondDD.image,
            typeSkinWhiteUpturnedDD.image
        };

        eyeTypeSpriteCOList = new List<Sprite>
        {
            typeEyeStyleRoundCO.image,
            typeEyeStyleAlmondCO.image,
            typeEyeStyleUpturnedCO.image,
        };

        hairColourList = new List<string>
        {
            "black",
            "brown dark",
            "brown light",
            "blonde",
            "ginger",
            "grey",
            "white"
        };

        hairColourMatAMList = new List<Material>
        {
            matHairBlackAM,
            matHairBrownDarkAM,
            matHairBrownLightAM,
            matHairBlondeAM,
            matHairGingerAM,
            matHairGreyAM,
            matHairWhiteAM
        };

        hairColourMatHLList = new List<Material>
        {
            matHairBlackHL,
            matHairBrownDarkHL,
            matHairBrownLightHL,
            matHairBlondeHL,
            matHairGingerHL,
            matHairGreyHL,
            matHairWhiteHL
        };

        hairTypeList = new List<string>
        {
            "long bun",
            "long curly",
            "long dreads", 
            "long mohawk", 
            "long ponytail", 
            "long straight", 
            "medium afro", 
            "medium dreads", 
            "medium messy", 
            "medium mohawk", 
            "medium parting", 
            "medium pigtails", 
            "medium ponytail", 
            "medium quif", 
            "medium spiked", 
            "short afro", 
            "short bald", 
            "short charles",
            "short monk", 
            "short stubble" 
        };


        hairTypeSpriteDDList = new List<Sprite>
        {
            typeHairStyleLBunDD.image,
            typeHairStyleLCurlyDD.image,
            typeHairStyleLDreadsDD.image,
            typeHairStyleLMohawkDD.image,
            typeHairStyleLPonytailDD.image,
            typeHairStyleLStraightDD.image,
            typeHairStyleMAfroDD.image,
            typeHairStyleMDreadsDD.image,
            typeHairStyleMMessyDD.image,
            typeHairStyleMMohawkDD.image,
            typeHairStyleMPartingDD.image,
            typeHairStyleMPigtailsDD.image,
            typeHairStyleMPonytailDD.image,
            typeHairStyleMQuifDD.image,
            typeHairStyleMSpikedDD.image,
            typeHairStyleSAfroDD.image,
            typeHairStyleSBaldDD.image,
            typeHairStyleSCharlesDD.image,
            typeHairStyleSMonkDD.image,
            typeHairStyleSStubbleDD.image
        };

        //=======>   EYEBROWS   <========

        browTypeList = new List<string>
        {
             "thick",
             "thin",
             "monobrow"
        };

        browTypeSpriteDDList = new List<Sprite>
        {
            typeBrowThickDD.image,
            typeBrowThinDD.image,
            typeBrowMonobrowDD.image,
        };

        beardTypeList = new List<string>
        {
             "mustache",
             "short",
             "long"
        };

        beardTypeSpriteDDList = new List<Sprite>
        {
            typeBeardStyleMustacheDD.image,
            typeBeardStyleShortDD.image,
            typeBeardStyleLongDD.image
        };

        beardTypeList = new List<string>
        {
             "mustache",
             "short",
             "long"
        };

        lashTypeList = new List<string>
        {
             "round short",
             "round long"
        };

        lashTypeSpriteDDList = new List<Sprite>
        {
            typeEyelashStyleRoundShortDD.image,
            typeEyelashStyleRoundLongDD.image,
            typeEyelashStyleAlmondShortDD.image,
            typeEyelashStyleAlmondLongDD.image,
            typeEyelashStyleUpturnedShortDD.image,
            typeEyelashStyleUpturnedLongDD.image
        };

        lashTypeSpriteCOList = new List<Sprite>
        {
            typeEyelashStyleRoundShortCO.image,
            typeEyelashStyleRoundLongCO.image,
            typeEyelashStyleAlmondShortCO.image,
            typeEyelashStyleAlmondLongCO.image,
            typeEyelashStyleUpturnedShortCO.image,
            typeEyelashStyleUpturnedLongCO.image
        };
    }

}

