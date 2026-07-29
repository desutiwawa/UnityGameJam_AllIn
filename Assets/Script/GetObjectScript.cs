using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Assertions.Must;



public class GetObjectScript : MonoBehaviour
{
    private AudioSource audioSource = null;
    public AudioClip GetItem;


    private Renderer objectRenderer;
    public enum ObjectName
    {
        Valve,
        Floppy,
        Gear
    }

    public ObjectName objectName;

   void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySE(AudioClip clip)
    {
        if(audioSource != null)
        {
            audioSource.PlayOneShot(clip);
        }
   
    }
    private void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Player"))
        return;

        ScoreManageScript.Instance.AddObject(objectName);

        PlaySE(GetItem);
        Destroy(gameObject);

    }
   

}
