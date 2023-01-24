using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Privacy
{
    Undefined,
    Public,
    Private
}

public class Table : MonoBehaviour
{
    public string table_name;
    public string table_code;
    public string subject;
    public Privacy privacy;
}
