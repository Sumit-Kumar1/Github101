using UnityEngine;

public class particle : MonoBehaviour
{
    [SerializeField] ParticleSystem part;

    // Start is called before the first frame update
    void Start()
    {
        part = FindObjectOfType<ParticleSystem>();
        part.Play();
    }

    // Update is called once per frame
    
}
