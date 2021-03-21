using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] Rigidbody player;
    private void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        gameManager.flag = false;
        player.constraints = RigidbodyConstraints.FreezePosition;
    }
}
