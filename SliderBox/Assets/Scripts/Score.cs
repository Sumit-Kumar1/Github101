using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Text scoreText ; // The text is from unity engine.ui
    private float _score = 0.0f;
    private float _finalScore = 0.0f;
    [SerializeField] movement _playerMovement;

    void FixedUpdate()
    {
        _score = -player.position.z;
        if(_playerMovement.enabled){
            scoreText.text = _score.ToString("0");
            _finalScore = _score;
        }else{
            scoreText.text = _finalScore.ToString("0");
        }
    }
}
