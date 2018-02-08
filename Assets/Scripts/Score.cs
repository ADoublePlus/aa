using UnityEngine;
using UnityEngine.UI;

namespace aa
{
    public class Score : MonoBehaviour
    {
        public Text text;

        public static int pinCount;

        // Use this for initialization
        void Start ()
        {
            pinCount = 0;
        }

        // Update is called once per frame
        void Update ()
        {
            text.text = pinCount.ToString();
        }
    }
}