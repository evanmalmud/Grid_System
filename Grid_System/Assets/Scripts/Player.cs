using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {


}

struct PlayerData
{
    string Name;
    POSITION position;
    bool rightHanded;
    int playerValue;
    BATTING batting;
}

public struct BATTING
{
    int[] OutPU;
    int[] OutSO;
    int[] OutGB;
    int[] OutFB;
    int[] Walk;
    int[] Single;
    int[] SinglePus;
    int[] Double;
    int[] Triple;
    int[] Homer;
}

public enum POSITION
{
    [Description("Catcher")]
    eC,
    [Description("First Basemen")]
    eOneB,
    [Description("Second Basemen")]
    eTwoB,
    [Description("Third Basemen")]
    eThreeB,
    [Description("Short Stop")]
    eSS,
    [Description("Left Field")]
    eLF,
    [Description("Right Field")]
    eRF,
    [Description("Center Field")]
    eCF,
    [Description("Out Field")]
    eOF,
    [Description("Designated Hitter")]
    eDH,
    [Description("Pitcher")]
    eP 
}

public enum PITCHER_TYPE
{
    eStarting,
    eRelief,
    eCloser
}

public struct PITCHER
{
    PlayerData playerData;
    PITCHER_TYPE pitcherType;
    int inningsPitched;
}

public class Batter : Player
{
    PlayerData playerData;
    int speed;
    int strategyValue;
}