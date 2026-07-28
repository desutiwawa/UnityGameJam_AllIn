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

   


    private void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Player"))
        return;

        ScoreManageScript.Instance.AddObject(objectName);

        Destroy(gameObject);

    }
   

}
