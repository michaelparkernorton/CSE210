using System;
using System.Collections.Generic;
using System.IO;

namespace Solution
{
    
    public class Note
    {
        public string name;
        public string state;

        public Note(string name, string state) {
            this.name = name;
            this.state = state;
        }
    }
    
    public class NotesStore
    {
        public List<Note> Notes;
        public string[] note;
        public NotesStore() {}
        public void AddNote(String state, String name) {
            if (name == String.Empty)
            {
                throw new Exception("Name cannot be empty");
            }
            if (state != "completed" || state != "active" || state != "others") {
                throw new Exception($"Invalid state {state}");
            }
            Note n = new(name, state);
            Notes.Add(n);
        }
        public List<String> GetNotes(String state) {
            List<String> notes = new List<String>();
            foreach (var note in this.Notes)
            {
                if (note.state == state){
                    notes.Add(note.name);
                }
            }
            return notes;

        }
    } 

    public class Solution
    {
        public static void Main() 
        {
            var notesStoreObj = new NotesStore();
            var n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++) {
                var operationInfo = Console.ReadLine().Split(' ');
                try
                {
                    if (operationInfo[0] == "AddNote")
                        notesStoreObj.AddNote(operationInfo[1], operationInfo.Length == 2 ? "" : operationInfo[2]);
                    else if (operationInfo[0] == "GetNotes")
                    {
                        var result = notesStoreObj.GetNotes(operationInfo[1]);
                        if (result.Count == 0)
                            Console.WriteLine("No Notes");
                        else
                            Console.WriteLine(string.Join(",", result));
                    } else {
                        Console.WriteLine("Invalid Parameter");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }
    }
}