using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneDetails : MonoBehaviour
{
    private enum skinColourTypes
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
    private enum eyeStyleTypes
    {
        round,
        almond,
        upturned
    };
    private enum hairStyleTypes
    {
        hairStyleBunL,
        hairStyleCurlyL,
        hairStyleDreadsL,
        hairStyleMohawkL,
        hairStylePonytailL,
        hairStyleStraightL,

        hairStyleAfroM,
        hairStyleDreadsM,
        hairStyleMessyM,
        hairStyleMohawkM,
        hairStylePartingM,
        hairStylePigtailsM,
        hairStylePonytailM,
        hairStyleQuifM,
        hairStyleSpikedM,

        hairStyleAfroS,
        hairStyleBaldS,
        hairStyleCharlesS,
        hairStyleMonkS,
        hairStyleStubbleS
    };
    private enum hairColoureTypes
    {
        black,
        blonde,
        brownDark,
        brownLight,
        ginger,
        grey,
        white
    };
    private enum eyeColourTypes
    {
        brown,
        blue,
        hazel,
        green,
    };
    private enum beardStyleTypes
    {
        beardNone,
        beardShort,
        beardLong,
        beardmustache
    };
    private enum lashTypes
    {
        roundShort,
        roundLong,
        almondShort,
        almondLong,
        upturnedShort,
        upturnedLong
    };
    private enum eyeSpecTypes
    {
        round,
        square,
        diamond,
        heart,
        star,
    };
    private enum teethStyleTypes
    {
        normal
    };
    private enum browStyleTypes
    {
        thick,
        thin,
        monobrow
    };
    private enum tongueStyleTypes
    {
        normal,
        dog
    };
    private enum mouthbagStyleTypes
    {
        normal
    };

    public int cloneNumber;
    public string skinColour;
    public string eyeStyle;
    public string lashStyle;
    public string hairStyle;
    public string hairColour;
    public string eyeColour;
    public string beardStyle;
    public string eyeSpecStyle;
    public string teethStyle;
    public string browStyle;
    public string tongueStyle;
    public string mouthbagStyle;

    public List<string> CloneDetailList = new List<string>();

    public void PopulateCloneDetailList()
    {
         CloneDetailList = new List<string>()
        {
            skinColour,
            eyeStyle,
            lashStyle,
            hairStyle,
            hairColour,
            eyeColour,
            beardStyle,
            eyeSpecStyle,
            teethStyle,
            browStyle,
            tongueStyle,
            mouthbagStyle
        };
}





}
