using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using LootLocker.Requests;

public class LeaderBoardManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoginRoutine());
    }
    IEnumerator LoginRoutine() 
    {
        bool done = false;
        LootLockerSDKManager.StartGuestSession((response) =>
        {
            if (response.success)
            {
                Debug.Log("Logged in");
                PlayerPrefs.SetString("Player ID", response.player_id.ToString());
                done = true;
            }
            else
            {
                Debug.Log("Could Not Start Session");
                done = true;

            }
        });
        yield return new WaitWhile(() => done = false);
    }

}
