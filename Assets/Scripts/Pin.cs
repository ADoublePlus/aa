using UnityEngine;

namespace aa
{
    public class Pin : MonoBehaviour
    {
        public Rigidbody2D rigid2D;

        public float speed = 20f;

        private bool isPinned = false;

        // Update is called once per frame
        void Update ()
        {
            if (!isPinned)
            {
                rigid2D.MovePosition(rigid2D.position + Vector2.up * speed * Time.deltaTime);
            }
        }

        void OnTriggerEnter2D (Collider2D _col2D)
        {
            if (_col2D.tag == "Rotator")
            {
                transform.SetParent(_col2D.transform);

                Score.pinCount++;

                isPinned = true;
            }
            else if (_col2D.tag == "Pin")
            {
                FindObjectOfType<GameManager>().EndGame();
            }
        }
    }
}