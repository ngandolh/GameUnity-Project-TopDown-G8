using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuinManagement : MonoBehaviour
{
    private static RuinManagement instance;
    // Start is called before the first frame update
    public static int activatedRuneCount = 0;
    public int requiredRuneCount = 3;

    public GameObject gateClosed;
    public GameObject gateOpened;
    public static void activateRune()
    {
        activatedRuneCount++;
        if (activatedRuneCount >= instance.requiredRuneCount)
            instance.OpenDoor();
    }
    public static void deactivateRune()
    {
        activatedRuneCount--;
        if (activatedRuneCount <= instance.requiredRuneCount)
            instance.CloseDoor();
    }

    private void Start()
    {
        instance = this;
    }

    private void OpenDoor()
    {
        if (gateClosed != null && gateOpened != null)
        {
            gateClosed.SetActive(false);
            gateOpened.SetActive(true);
        }
    }
    private void CloseDoor()
    {
        if (gateClosed != null && gateOpened != null)
        {
            gateClosed.SetActive(true);
            gateOpened.SetActive(false);
        }
    }
}
