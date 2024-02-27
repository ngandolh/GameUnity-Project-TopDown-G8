using System.Collections.Generic;
using UnityEngine;

namespace Test
{

    public class AltarDoor : MonoBehaviour
    {
        public List<SpriteRenderer> runes;
        public float lerpSpeed = 3;
        public Color curColor = new(1,1,1,0);
        public Color targetColor = new(1,1,1,0);
        public GameObject gateClosed;
        public GameObject gateOpened;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "Box")
            {
                targetColor = new Color(1, 1, 1, 1);
                OpenDoor();
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.gameObject.tag == "Box")
            {
                targetColor = new Color(1, 1, 1, 0);
                CloseDoor();
            }
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

        private void Start()
        {
            gateOpened.SetActive(false);
        }

        private void Update()
        {
            curColor = Color.Lerp(curColor, targetColor, lerpSpeed * Time.deltaTime);

            foreach (var r in runes)
            {
                r.color = curColor;
            }
        }
    }
}
