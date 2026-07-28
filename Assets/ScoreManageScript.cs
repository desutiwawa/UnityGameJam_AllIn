using UnityEngine;

public class ScoreManageScript : MonoBehaviour
{
    public static ScoreManageScript Instance;

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

    public void AddObject(GetObjectScript.ObjectName OBName)
    {
        switch (OBName)
        {
            case GetObjectScript.ObjectName.Valve:
                ValveCount++;
                break;

            case GetObjectScript.ObjectName.Floppy:
                FloppyCount++;
                break;

            case GetObjectScript.ObjectName.Gear:
                GearCount++;
                break;


        }



    }
}
