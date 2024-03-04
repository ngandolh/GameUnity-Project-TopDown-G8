using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//when something get into the alta, make the runes glow
namespace Cainos.PixelArtTopDown_Basic
{

    public class PropsAltar : MonoBehaviour
    {
        public List<SpriteRenderer> runes;
        public float lerpSpeed = 3;
        private Color curColor = new(1,1,1,0);
        private Color targetColor = new(1,1,1,0);
        private bool activated = false;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "Box")
            {
                targetColor = new Color(1, 1, 1, 1);
                if (!activated)
                {
                    activated = true;
                    RuinManagement.activateRune();
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
                    RuinManagement.deactivateRune();
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
