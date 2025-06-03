using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SongSelector : MonoBehaviour
{
    public static string selectedSong;

    public void SelectSong(string songName)
    {
        selectedSong = songName;
        SceneManager.LoadScene("Gameplay");
    }
}
