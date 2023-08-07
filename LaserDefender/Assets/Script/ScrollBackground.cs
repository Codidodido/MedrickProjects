using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    
        [SerializeField][Range(0f,2f)] float scrollSpeed;

        private Renderer renderer;
        private Vector2 savedOffset;

        void Start()
        {
            renderer = GetComponent<Renderer>();
        }

        void Update()
        {
            float y = Mathf.Repeat(Time.time * scrollSpeed, 1);
            Vector2 offset = new Vector2(0, y);
            renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
        }
    
}
