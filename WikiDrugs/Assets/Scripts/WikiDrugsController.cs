using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WikiDrugsController : MonoBehaviour
{
    [SerializeField]Animator DolenciasCanvas, InfoCanvas, TitleCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickDolencias()
    {
        if (DolenciasCanvas.GetBool("isOpen"))
        {
            DolenciasCanvas.SetBool("isOpen", false);
        }
        else if (InfoCanvas.GetBool("isOpen"))
        {
            InfoCanvas.SetBool("isOpen", false);
            DolenciasCanvas.SetBool("isOpen", true);
        }
        else if (TitleCanvas.GetBool("isOpen"))
        {
            TitleCanvas.SetBool("isOpen", false);
            DolenciasCanvas.SetBool("isOpen", true);
        } else
        {
            DolenciasCanvas.SetBool("isOpen", true);
        }
    }

    public void clickInfo()
    {
        if (InfoCanvas.GetBool("isOpen"))
        {
            InfoCanvas.SetBool("isOpen", false);
        }
        else if (DolenciasCanvas.GetBool("isOpen"))
        {
            DolenciasCanvas.SetBool("isOpen", false);
            InfoCanvas.SetBool("isOpen", true);
        }
        else if (TitleCanvas.GetBool("isOpen"))
        {
            TitleCanvas.SetBool("isOpen", false);
            InfoCanvas.SetBool("isOpen", true);
        } else
        {
            InfoCanvas.SetBool("isOpen", true);
        }
    }

    public void clickTitle()
    {
        if (TitleCanvas.GetBool("isOpen"))
        {
            TitleCanvas.SetBool("isOpen", false);
        }
        else if (InfoCanvas.GetBool("isOpen"))
        {
            InfoCanvas.SetBool("isOpen", false);
            TitleCanvas.SetBool("isOpen", true);
        }
        else if (DolenciasCanvas.GetBool("isOpen"))
        {
            DolenciasCanvas.SetBool("isOpen", false);
            TitleCanvas.SetBool("isOpen", true);
        } else
        {
            TitleCanvas.SetBool("isOpen", true);
        }
    }

    public void clickExit(){
        Application.Quit();
    }
}
