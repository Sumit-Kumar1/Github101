using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public Camera Cam;
    private void Start() {
        Cam = GetComponent<Camera>();
    }
    // Update is called once per frame
    void Update()
    {
        Cam.transform.position = player.position + offset;    // The camera is positioned to player position
    }
}
