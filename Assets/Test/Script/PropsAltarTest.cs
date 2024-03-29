using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Test
{

    public class PropsAltarTest : MonoBehaviour
    {
        public List<SpriteRenderer> runes;
        public float lerpSpeed = 3;
        private Color curColor = new Color(1, 1, 1, 1);
        private Color targetColor = new Color(1, 1, 1, 0);
        private bool activated = false;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "Box")
            {
                targetColor = new Color(1, 1, 1, 1);
                if (!activated)
                {
                    activated = true;
                    RuinManager.activateRune();
                }
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.gameObject.tag == "Box")
            {
                targetColor = new Color(1, 1, 1, 0);
                if (activated)
                {
                    activated = false;
                    RuinManager.deactivateRune();
                }
            }
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
