using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;

public class rumbletrigger : MonoBehaviour
{
    PlayerIndex playerIndex;
    GamePadState state;
    GamePadState prevstate;

    public float rumbletime;
    public float rumblePressure;

    public void RumbleStart()
    {
        GamePad.SetVibration(playerIndex, rumblePressure, rumblePressure);
        Invoke("RumbleStop", rumbletime);
    }

    public void RumbleStop()
    {
        GamePad.SetVibration(playerIndex, 0, 0);
    }
}
