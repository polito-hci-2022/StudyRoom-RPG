using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public enum Mode
{
    NotUploaded,
    ReadOnly,
    Downloadable
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
    public List<Document> documents = new List<Document>();
    public Document open_doc;

    private void Awake() {
        if (instance != null) {
            Destroy(gameObject);
            return;
        }
        documents.Clear();
        Document table_note_1 = new Document("Table Note 1", Mode.ReadOnly, false);
        Document table_note_2 = new Document("Table Note 2", Mode.Downloadable, false);
        Document my_note_1 = new Document("My Note 1", Mode.NotUploaded, true);
        Document my_note_2 = new Document("My Note 2", Mode.NotUploaded, true);
        documents.Add(table_note_1);
        documents.Add(table_note_2);
        documents.Add(my_note_1);
        documents.Add(my_note_2);
        open_doc = my_note_1; 
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void UploadDocument(string title, Mode mode) {
        int i = documents.FindIndex( x => x.title == title );
        documents[i].mode = mode;
    }

    public List<Document> GetDocumentsOnTable() {
        return documents.FindAll(x => x.mode != Mode.NotUploaded);
    }

    public void DownloadDocument(string title) {
        int i = documents.FindIndex( x => x.title == title );
        documents[i].isMine = true;
    }

    public List<Document> GetMyDocuments() {
        return documents.FindAll(x => x.isMine == true);
    }

    public void SetOpenDoc(Text name) {
        open_doc = documents.Find(x => x.title == name.text);
    }

    public Document GetOpenDoc() {
        return open_doc;
    }

}
