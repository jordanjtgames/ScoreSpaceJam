using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using LootLocker.Requests;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] MovementScript Shape;
    [SerializeField] LeaderBoardScoreSubmit leaderboard;
    [SerializeField] ScoreSystem score;
    // [SerializeField] Spawner spawner;
    [SerializeField] KeyCode ResetKey;
    GameObject[] Tiles;
    public bool isDead = false;
    public int Shapes;
    Audiomanager audio;

    private void Start()
    {
        audio = GameObject.FindObjectOfType<Audiomanager>();
    }
    private void Update()
    {
        Shapes = Shape.ShapeIndex;
        ResetPlayer();
        //Debug.Log(isDead);
        // isDead = false;


        if (isDead)
        {
            /* bool Scoresent = false;
             if (!Scoresent) 
             {
                 StartCoroutine(ScoreSend() ) ;
                 Scoresent = true ;
             }
             audio.DeathAudio();
            // audio.ContinueScreenPlay();
            */
            StartCoroutine(DeathCoroutine());

        }

    }
    public void ResetPlayer()
    {
        if (Input.GetKeyDown(ResetKey))
        {

            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);

        }


    }
    IEnumerator ScoreSend()
    {
        Debug.Log("ScoreSent");
        StartCoroutine(leaderboard.SubmitScore((int)(score.ScoreCount)));
        yield return null;
    }
    IEnumerator DeathCoroutine()
    {
        bool Scoresent = false;
        if (!Scoresent)
        {
            StartCoroutine(ScoreSend());
            Scoresent = true;
        }
        audio.DeathAudio();
        

        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("DeathScreen");


    }
}   