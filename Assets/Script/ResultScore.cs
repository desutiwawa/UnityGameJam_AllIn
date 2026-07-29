using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class ResultScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ValveUI;

    [SerializeField] private TextMeshProUGUI GearUI;

    [SerializeField] private TextMeshProUGUI FloppyUI;

    [SerializeField] private TextMeshProUGUI TotalUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        ValveUI.text = "" + ScoreManageScript.Instance.TotalValveCount;
        FloppyUI.text = "" + ScoreManageScript.Instance.TotalFloppyCount;
        GearUI.text = "" + ScoreManageScript.Instance.TotalGearCount;
        TotalUI.text = "" + ScoreManageScript.Instance.TotalScore;


    //public int TotalValveCount;
    //public int TotalFloppyCount;
    //public int TotalGearCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
