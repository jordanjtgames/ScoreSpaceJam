using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LootLocker.Requests;
using UnityEngine.SocialPlatforms.Impl;

public class LeaderBoardScoreSubmit : MonoBehaviour
{
    string LeaderboardID = "19880";
    void Start()
    {

    }

    public IEnumerator SubmitScore(int score)
    {
        bool done = false;
        string playerID = PlayerPrefs.GetString("PlayerID");
        LootLockerSDKManager.SubmitScore(playerID, score, LeaderboardID, (response) =>
        {
            if (response.success)
            {
                Debug.Log("Score Sent");
                done = true;

            }
            else
            {
                Debug.Log("Failed" + response.errorData.ToString());
                done = true;
            }
        });
        yield return new WaitWhile(() => done == false);
    }
}
