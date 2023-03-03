using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool keyGot = false;

    public bool wonGame = false;

    public void ObtainKey()
    {
        keyGot = true;
    }

    public void WinTheGame()
    {
        if(keyGot && !wonGame)
        {
            wonGame = true;
            Debug.Log("Won the game");
        }
    }

}
