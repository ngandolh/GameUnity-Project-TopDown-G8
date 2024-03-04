using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//when something get into the alta, make the runes glowa
namespace Cainos.PixelArtTopDown_Basic
{

    public class PropsAltar : MonoBehaviour
    {
        public List<SpriteRenderer> runes;
        public float lerpSpeed;

        private Color curColor = new(1, 1, 1, 0);
        private Color targetColor = new(1, 1, 1, 0);

        private void OnTriggerEnter2D(Collider2D other)
        {
            targetColor = new Color(1, 1, 1, 1);
            Console.WriteLine(targetColor);
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            targetColor = new Color(1, 1, 1, 0);
        }

        private void Update()
        {
            /*
             * curColor = Color.Lerp(curColor, targetColor, lerpSpeed * Time.deltaTime);
             */
            if (new Color(1,1,1,1) == targetColor)
            {
                Console.WriteLine("Glowing");
            }
            foreach (var r in runes)
            {
                //r.color = curColor;
                r.color = targetColor;
            }
        }
    }
}
