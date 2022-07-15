using UnityEngine;

[CreateAssetMenu(fileName = "CloneType", menuName = "CryptoClonez", order = 1)]
public class CloneType : ScriptableObject
{
    [SerializeField]
    public string featureName;
    public CloneFeature type;
    public Sprite image;
    public Material material;

    public enum CloneFeature 
    { 
        SkinColour,
        EyeStyle,
        LashStyle,
        HairStyle,
        HairColour,
        EyeColour,
        BeardStyle,
        EyebrowStyle,
        EyeSpecStyle,
        TeethStyle,
        TongueStyle,
        MouthbagStyle
    };
}
