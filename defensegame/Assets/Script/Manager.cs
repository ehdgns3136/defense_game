using System.Collections.Generic;
using UnityEngine;

namespace Script
{
    public class Manager : MonoBehaviour
    {
        public GameObject view;
        public Transform layout;

        public List<Tile> tileList;
        
        private void OnEnable()
        {
            for (int i = 0; i < 20; i++)
            {
                GameObject instance = Instantiate(view, layout);
                Tile tile = instance.GetComponent<Tile>();
                tile.color = i % 2 == 0 ? Color.black : Color.grey;
                tile.index = i;
                tile.UpdateView();
                
                tileList.Add(tile);
            }
        }
    }
}