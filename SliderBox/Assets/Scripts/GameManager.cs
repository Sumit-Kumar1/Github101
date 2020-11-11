using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool IsGameEnded = false;

    public void EndGame()
    {
        if(IsGameEnded == false) 
        {
            print("Game Ended");
            IsGameEnded = true;
        }
    }
}
