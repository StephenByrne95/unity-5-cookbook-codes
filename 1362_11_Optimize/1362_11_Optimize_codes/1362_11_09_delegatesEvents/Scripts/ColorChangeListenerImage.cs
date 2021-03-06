using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColorChangeListenerImage : MonoBehaviour
{
	/*----------------------------------------------
	 * when this object enabled, register method ChangeColorEvent()
	 * to respond to broadcast events of 'onChangeColor' from ColorManager
	 */
	void OnEnable()
	{
		ColorManager.onChangeColor += ChangeColorEvent;
	}
	
	/*----------------------------------------------
	 * when this object disabled, un-register method ChangeColorEvent()
	 *
	 * so we only respond to such events when enabled
	 */
	private void OnDisable()
	{
		ColorManager.onChangeColor -= ChangeColorEvent;
	}

	/*----------------------------------------------
	 * change the color of our sibling UI Image component to the provided Color
	 */
	void ChangeColorEvent(Color newColor)
	{
			GetComponent<Image>().color = newColor;
	}
}