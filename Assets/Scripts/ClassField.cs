using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[SelectionBase] // ��������� ��� ������ ��������� ������� �� ����� �������� ������������

[RequireComponent(typeof(Rigidbody))] // ��������� �������� ���� ��� ��� � �� ���� ��� �������
public class ClassField : MonoBehaviour
{
    [Header("title")] // ����������
    [SerializeField, Range(1f, 10f)] private float _range; //� ���������
    [SerializeField, Min(1)] private float _rangeMin; // ����������� ��������
    
    [Header("������ ������ � �������")]
    [SerializeField, Multiline(3)] private string _stringField1; // �������� ������ ������� ����� ����� ����� � ����������
    [SerializeField, TextArea(1, 4)] private string _strField;
    // ������ �������� - ������� ����� ����� ����� ������ � ���������, � ������ ������� �������� ��� ���������� ������
    
    [Space(20)] // ��������� �� �����
    [Header("���������")]
    [Tooltip("��� ����� ���������")] // ���������� ��� ��������� �� ���� _speed
    [SerializeField] private float _speed;

    [ContextMenu("My Custom Command")]
    private void MyCustomCommand()
    {
        Debug.Log("Executing My Custom Command");
        // ��� ��� �����
    }
    ///
    //��� ������� ����� ������� � ����������� ���� �������, ������� ����������, ����� �� �������� ������ ������� ���� �� ���������� � ��������� Unity
    //����� �����, ���� �� �������� ������ � ������ �������� � �������� ��� � �����, �� ������� � ����������� ���� ����� "My Custom Command". ��� ������ ���� ����� ����� ������ ����� MyCustomCommand.
    //���� ������ �������, ����� ��� ����� ������������ ������� ������ � �����-�� ��������� ��� ����������� �� ��������� Unity ��� ������������� ��������� ����������� ���������������� ���� � ����������.

    //��� ����� ������������� ��� ����������� playmode!!!!
    ///
}