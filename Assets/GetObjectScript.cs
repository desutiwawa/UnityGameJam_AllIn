using Unity.VisualScripting;
using UnityEngine;

public class GetObjectScript : MonoBehaviour
{
    private Renderer objectRenderer;
    public enum ObjectName
    {
        Valve,
        Floppy,
        Gear
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {

            Destroy(gameObject);
        }
    }


}
