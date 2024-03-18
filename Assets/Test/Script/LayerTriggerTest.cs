using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    public class LayerTriggerTest : MonoBehaviour
    {
        public string layer;
        public string sortingLayer;
        private void OnTriggerExit2D(Collider2D other)
        {
            other.gameObject.layer = LayerMask.NameToLayer(layer);
            other.gameObject.GetComponent<SpriteRenderer>().sortingLayerName = sortingLayer;
            SpriteRenderer[] srs = other.GetComponentsInChildren<SpriteRenderer>();
            foreach( SpriteRenderer sr in srs)
            {
                sr.sortingLayerName = sortingLayer;
            }
        }
    }
}