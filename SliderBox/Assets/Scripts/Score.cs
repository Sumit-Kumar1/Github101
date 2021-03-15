using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText; // The text is from unity engine.ui
    float s = 0.0f;
    float _finalScore = 0.0f;
    bool flag = true;
    
    void FixedUpdate()
    {
        s = -player.position.z;
        
        if(player.movement == enabled){
            scoreText.text = s.ToString("0");
            s = _finalScore;
        }
        else
        {
            scoreText.text = _finalScore.ToString("0");
        }
    }
}
