using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Script
{
    public class Tile : MonoBehaviour
    {
        private Transform _child;
        private Image _image;
        public Color color;
        public int index;
        
        private void OnEnable()
        {
            _child = transform.GetChild(0);
            _image = _child.GetComponent<Image>();
        }
        
        // public void OnPointerEnter(PointerEventData eventData)
        // {
        //     _image.color = Color.gray;
        // }
        //
        // public void OnPointerExit(PointerEventData eventData)
        // {
        //     _image.color = Color.white;
        // }

        public void UpdateView()
        {
            _image.color = color;
        }
    }
}