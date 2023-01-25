using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Mode
{
    NotUploaded,
    ReadOnly,
    ReadWrite
}

public class Document {
    public string title;
    public Mode mode;
    public bool isMine;

    public Document (string title, Mode mode, bool isMine) {
        this.title = title;
        this.mode = mode;
        this.isMine = isMine;
    }
}

public class DocumentList : MonoBehaviour
{
    public static DocumentList instance;
    public static List<Document> documents = new List<Document>();

    private void Awake() {
        if (instance != null) {
            Destroy(gameObject);
            return;
        }
        documents.Clear();
        Document table_note_1 = new Document("Table Note 1", Mode.ReadOnly, false);
        Document table_note_2 = new Document("Table Note 2", Mode.ReadWrite, false);
        Document my_note_1 = new Document("My Note 1", Mode.NotUploaded, true);
        Document my_note_2 = new Document("My Note 2", Mode.NotUploaded, true);
        documents.Add(table_note_1);
        documents.Add(table_note_2);
        documents.Add(my_note_1);
        documents.Add(my_note_2);
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public static void UploadDocument(string title, int mode) {
        int i = documents.FindIndex( x => x.title == title );
        documents[i].mode = (Mode) mode;
    }

}
