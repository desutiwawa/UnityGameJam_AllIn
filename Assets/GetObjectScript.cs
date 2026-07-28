using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetObjectScript : MonoBehaviour
{

    

    private Renderer objectRenderer;
    public enum ObjectName
    {
        Valve,
        Floppy,
        Gear
    }

    public ObjectName objectName;

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
        if(!other.CompareTag("Player"))
        return;

        .Instance.

        Destroy(gameObject);

    }
   

}
