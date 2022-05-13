using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InfoController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI infoText;

    int totalPages;
    int currenPage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkPages()
    {
        totalPages = infoText.textInfo.pageCount;
        currenPage = 1;
    }

    public void nextPage()
    {
        if (currenPage == infoText.textInfo.pageCount)
        {
            currenPage = 1;
            infoText.pageToDisplay = 1;
        }
        else
        {
            infoText.pageToDisplay++;
            currenPage++;
        }
    }

    public void prevPage()
    {
        if (currenPage == 1)
        {
            currenPage = infoText.textInfo.pageCount;
            infoText.pageToDisplay = infoText.textInfo.pageCount;
        }
        else
        {
            infoText.pageToDisplay--;
            currenPage--;
        }
    }
}
