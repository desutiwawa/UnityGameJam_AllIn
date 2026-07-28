using UnityEngine;

public class ScoreManageScript : MonoBehaviour
{
    public static ScoreManager Instance;

    public int ValveCount;
    public int FloppyCount;
    public int GearCount;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Awake()
    {
        Instance = this;
    }

    public void AddObject()
    {
        switch (objectName)
        {
            case ObjectName.Valve:
                ValveCount++;
                break;

            case ObjectName.Floppy:
                FloppyCount++;
                break;

            case ObjectName.Gear:
                GearCount++;
                break;


        }



    }
}
