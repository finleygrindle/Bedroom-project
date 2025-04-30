using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireStart : MonoBehaviour
{
    public GameObject BedroomFire;
    public GameObject Disappear;
    public GameObject Player;
    public GameObject Facts;
    Fader fade;

    public AudioClip gasp;
    public AudioClip fire;
    private AudioSource audioSource;

    public CanvasGroup canvasGroup;
    public bool fadeout = false;

    public float TimeToFade;

    // Start is called before the first frame update
    void Start()
    {
        fade = FindObjectOfType<Fader>();

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(fadeout == true)
        {
            if(canvasGroup.alpha >=0)
            {
                canvasGroup.alpha -= TimeToFade * Time.deltaTime;
                if (canvasGroup.alpha == 0)
                {
                    fadeout = false;
                }
            }
        }
    }

    public void FadeOut()
    {
        fadeout = true;
    }

    public IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(2);
        Player.transform.position = new Vector3(-1.945f, 0.909f, -0.296f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Carpet")
        {
            Debug.Log(collision.gameObject.name);
            BedroomFire.transform.position = new Vector3(6f, 6f, 4f);
            Disappear.transform.position = new Vector3(30f, 6f, 4f);
            Player.transform.position = new Vector3(0.61f, 0.909f, 11.43f);
            Facts.transform.position = new Vector3(-16.43114f, -2.5f, -6.887037f);
            audioSource.PlayOneShot(gasp, 1f);
            audioSource.PlayOneShot(fire, 1f);
            StartCoroutine(ChangeScene());
        }
    }
}
