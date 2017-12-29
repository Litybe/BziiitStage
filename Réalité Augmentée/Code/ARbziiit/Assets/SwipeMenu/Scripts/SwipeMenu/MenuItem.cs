using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace SwipeMenu
{
	/// <summary>
	/// Attach to any menu item. 
	/// </summary>
	public class MenuItem : MonoBehaviour
	{
        public bool isBig { get; set; }
        private float scaleUpdate = 1.6f;
		/// <summary>
		/// The behaviour to be invoked when the menu item is selected.
		/// </summary>
		public Button.ButtonClickedEvent OnClick;

		/// <summary>
		/// The behaviour to be invoked when another menu item is selected.
		/// </summary>
		public Button.ButtonClickedEvent OnOtherMenuClick;

        private void Start()
        {
            //Input.gyro.enabled = true;
            this.isBig = false;
        }

        private void Update()
        {
            /*Vector3 rotFix = new Vector3(Input.gyro.attitude.x,
                                    Input.gyro.attitude.y,
                                    -2f);
            this.transform.localPosition = rotFix;*/

            //Transform debug = GameObjectController.Instance.findGameObject("InstanceManager/Canvas/debugText (1)");
            //debug.transform.GetComponent<Text>().text = "menu x: " + this.gameObject.transform.position.x + "\nmenu y:" + this.gameObject.transform.position.y + " \nmenu z: " + this.gameObject.transform.position.z;
        }
        public void onClikedSlide(MenuItem item)
        {
            if (!item.isBig)
            {
                item.gameObject.GetComponent<RectTransform>().transform.localScale = item.gameObject.GetComponent<RectTransform>().transform.localScale * scaleUpdate;
                item.isBig = true;
            }
            else if(item.isBig)
            {
                item.gameObject.GetComponent<RectTransform>().transform.localScale = item.gameObject.GetComponent<RectTransform>().transform.localScale / scaleUpdate;
                item.isBig = false;
            }
        }
    }
}