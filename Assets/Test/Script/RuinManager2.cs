using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Test.Script
{
    public class RuinManager2 : MonoBehaviour
    {
        private static RuinManager2 instance;
        // Start is called before the first frame update
        public static int activatedRuneCount = 0;
        public int requiredRuneCount = 2;

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
}
