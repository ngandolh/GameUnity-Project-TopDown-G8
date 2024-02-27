using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Test.Script
{
    public class PropsAltarTest : MonoBehaviour
    {
        public List<SpriteRenderer> runes;
        public float lerpSpeed;
        private Color curColor;
        private Color targetColor;
        private bool activated = false;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "Box")
            {
                targetColor = new Color(1, 1, 1, 1);
                if (!activated)
                {
                    activated = true;
                    RuinManager2.activateRune();
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
                    RuinManager2.deactivateRune();
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
