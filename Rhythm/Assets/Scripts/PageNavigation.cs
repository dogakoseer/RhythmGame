using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageNavigation : MonoBehaviour
{
    public GameObject[] pages;
    private int currentPage = 0;

    void Start()
    {
        UpdatePages();
    }

    public void NextPage()
    {
        currentPage = (currentPage + 1) % pages.Length;
        UpdatePages();
    }

    public void PreviousPage()
    {
        currentPage = (currentPage - 1 + pages.Length) % pages.Length;
        UpdatePages();
    }

    void UpdatePages()
    {
        for (int i = 0; i < pages.Length; i++)
        {
            pages[i].SetActive(i == currentPage);
        }
    }
}
