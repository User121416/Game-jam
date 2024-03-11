using UnityEngine;

public class FlashlightToggle : MonoBehaviour
{
    public Light flashlight; // Перетащите сюда ваш фонарик в инспекторе Unity

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) // Проверяем, была ли нажата клавиша R
        {
            flashlight.enabled = !flashlight.enabled; // Переключаем состояние фонарика
        }
    }
}
