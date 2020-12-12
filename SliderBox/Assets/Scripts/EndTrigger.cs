using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public Rigidbody player;
    private void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        gameManager.flag = false;
        player.constraints = RigidbodyConstraints.FreezePosition;
    }
}
