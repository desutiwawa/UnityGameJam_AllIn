using JetBrains.Annotations;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class ScoreManageScript : MonoBehaviour
{

    public static ScoreManageScript Instance;
    

    public int ValveCount;
    public int FloppyCount;
    public int GearCount;

    public int TotalScore;

    public int TotalValveCount;
    public int TotalFloppyCount;
    public int TotalGearCount;

    public int ValvePoint = 300;
    public int GearPoint = 500;
    public int FloppyPoint = 1000;

    public TextMeshProUGUI scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score : " + Mathf.Ceil(TotalScore);
    }

    private void Awake()
    {
        Instance = this;
    }

    public void AddObject(GetObjectScript.ObjectName OBName)
    {
        switch (OBName)
        {
            case GetObjectScript.ObjectName.Valve:
                ValveCount++;
                TotalValveCount++;
                break;

            case GetObjectScript.ObjectName.Floppy:
                FloppyCount++;
                TotalFloppyCount++;
                break;

            case GetObjectScript.ObjectName.Gear:
                GearCount++;
                TotalGearCount++;
                break;

        }

    }

    public void CalculateScore()
    {
        TotalScore += ValveCount * ValvePoint;
        TotalScore += FloppyCount * FloppyPoint;
        TotalScore += GearCount * GearPoint;


        ValveCount = 0;
        FloppyCount = 0;
        GearCount = 0;

    }

    

}
