using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    private AudioSource audio;
    [SerializeField] AudioClip[] gunshots;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int rand = Random.Range(0, gunshots.Length);
            if (!audio.isPlaying)
            {
                audio.PlayOneShot(gunshots[rand]);
            }
            
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            audio.Stop();
        }
        
    }
}
