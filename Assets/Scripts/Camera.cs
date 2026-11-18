using UnityEngine;

    public class Camera : MonoBehaviour
    {
        [SerializeField] private Transform horseTransform;
        [SerializeField] private Vector3 offset;
        void Start()
        {
        
        }
    
        void Update()
        {
            transform.position = horseTransform.position+offset;
        }
    }
    