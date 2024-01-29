
using UnityEngine;

public class Audiomanager : MonoBehaviour
{
    [SerializeField] public AudioSource Player;
    [SerializeField] public AudioSource GreenSlimeCollection;
    [SerializeField] public AudioSource RedSlimeCollection;
    [SerializeField] AudioClip move;
    [SerializeField] AudioClip death;
    [SerializeField] AudioClip ContinueScreen;
    [SerializeField] AudioClip GreenSlime;
    bool played = false;
    private void Start()
    {
        MoveAudio();
    }
    public void MoveAudio()
    {
        Player.loop= true;
        Player.clip= move;
        if (!Player.isPlaying)
        {
            Player.Play();
        }
    }
    public void DeathAudio()
    {
        Player.clip= death;
        Player.loop= false;
        
        if (!Player.isPlaying && !played)
        { 
           played= true;
            Player.Play();
        }
        Debug.Log("Playing deathSound");
    }
    public void ContinueScreenPlay()
    {
        Player.clip= ContinueScreen;
        Player.loop= true;
        bool played = false;
        if (!Player.isPlaying && !played)
        {
            played = true;
            Player.Play();
        }
    }

    public void GreenSlimeCollect()
    {
        if(!GreenSlimeCollection.isPlaying)
        GreenSlimeCollection.Play();


    }
    public void RedSlimeCollect()
    {
        if(!RedSlimeCollection.isPlaying) RedSlimeCollection.Play();


    }

}
