using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[SelectionBase] // позволяет при выборе дочернего обьекта НА СЦЕНЕ выбирать родительский

[RequireComponent(typeof(Rigidbody))] // добавляет компонет если его нет и не дает его удалить
public class ClassField : MonoBehaviour
{
    [Header("title")] // заоголовок
    [SerializeField, Range(1f, 10f)] private float _range; //в диапазоне
    [SerializeField, Min(1)] private float _rangeMin; // минимальное значение
    
    [Header("Пример работы с текстом")]
    [SerializeField, Multiline(3)] private string _stringField1; // параметр задает сколько строк будет видно в инспекторе
    [SerializeField, TextArea(1, 4)] private string _strField;
    // первый параметр - сколько сразу будет строк выидно в инспектре, а второй сколько максимум при добавлении текста
    
    [Space(20)] // растояние от полей
    [Header("Подсказка")]
    [Tooltip("тут текст подсказки")] // появляется при наведении на поле _speed
    [SerializeField] private float _speed;

    [ContextMenu("My Custom Command")]
    private void MyCustomCommand()
    {
        Debug.Log("Executing My Custom Command");
        // Ваш код здесь
    }
    ///
    //Это создает новую команду в контекстном меню скрипта, которое появляется, когда вы щелкаете правой кнопкой мыши по компоненту в редакторе Unity
    //После этого, если вы выберете объект с данным скриптом в иерархии или в сцене, вы увидите в контекстном меню опцию "My Custom Command". При выборе этой опции будет вызван метод MyCustomCommand.
    //Этот подход полезен, когда вам нужно предоставить быстрый доступ к каким-то действиям или функционалу из редактора Unity без необходимости создавать специальные пользовательские окна и интерфейсы.

    //это можно проворачивать без включенного playmode!!!!
    ///
}