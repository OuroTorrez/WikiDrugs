using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MedicamentoController : MonoBehaviour
{
    [SerializeField] Sprite Medicamento;
    [SerializeField] string Nombre;
    [SerializeField] string Info;

    [SerializeField] Image ImgMedicamento;
    [SerializeField] TextMeshProUGUI TxtMedicamento;
    [SerializeField] TextMeshProUGUI TxtInfoMedicamento;
    [SerializeField] TextMeshProUGUI TxtInfo;
    [SerializeField] WikiDrugsController WikiDrugsController;
    [SerializeField] InfoController infoController;

    [SerializeField] Animator player;
    private void Start()
    {
        
        ImgMedicamento.sprite = Medicamento;
        TxtMedicamento.text = Nombre;
    }
    public void clickMed()
    {
        player.SetTrigger("Hurt");
        ImgMedicamento.sprite = Medicamento;
        TxtMedicamento.text = Nombre;
        TxtInfoMedicamento.text = Nombre;
        TxtInfo.text = Info;
        WikiDrugsController.clickInfo();
        infoController.checkPages();
    }
}
