using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Collision : MonoBehaviour
{

    
    private SpriteRenderer blockRenderer;
    private Color originalColor;
    private AudioSource audioSource;

    void Start()
    {
        blockRenderer = GetComponent <SpriteRenderer>();
        originalColor = blockRenderer.color;
        audioSource = GetComponent<AudioSource>();

    }

    void OnCollisionEnter2D(Collision2D collision){
        blockRenderer.color = Color.yellow;
        StartCoroutine(ChangeColorBack());
        Sonido(250f);

    }

    void Sonido(float frecuencia){

        int sampleRate = 882;
        int sampleLenght = sampleRate;
        float[] samples = new float[sampleLenght]; 

        for (int i = 0; i < sampleLenght; i++)
        {
            samples[i] = Mathf.Sin(2 * Mathf.PI * frecuencia * i / sampleRate);
        }

        AudioClip clip = AudioClip.Create(" ", sampleLenght, 1, sampleRate, false);
        clip.SetData(samples, 0);

        audioSource.PlayOneShot(clip);
    }

    IEnumerator ChangeColorBack(){
        yield return new WaitForSeconds(0.5f);
        blockRenderer.color = originalColor;
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
