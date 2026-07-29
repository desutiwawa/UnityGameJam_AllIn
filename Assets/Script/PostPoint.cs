using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
//using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.SceneManagement;


public class PostPoint : MonoBehaviour
{
    private AudioSource audioSource = null;
    public AudioClip PostItem;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
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


        if (!other.CompareTag("Player"))
            return;

        ScoreManageScript.Instance.CalculateScore();

        PlaySE(PostItem);

        SpawnManager.Instance.RandSpawn();

        
    }

    

}
