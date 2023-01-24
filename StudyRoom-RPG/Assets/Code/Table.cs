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
    public static Table instance;
    public string table_name;
    public string table_code;
    public string subject;
    public Privacy privacy;

    private void Awake() {
        if (instance != null) {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
