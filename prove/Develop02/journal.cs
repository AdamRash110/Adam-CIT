using system;
public class Journal {
    private class Entry {
        public string _WhatTheyEnter = "";
        public string _prompt = "";
        public entry(string prompt, string WhatTheyEnter) {
            _prompt = prompt;
            _WhatTheyEnter  = WhatTheyEnter;
        }
    }

    private List<entry> _entries = new List<entry>();

    public void Display() {
        // I don't know what to do here.
    }

    public void Entry(string _prompt, string _WhatTheyEnter) {
        Entry ent = new entry(_prompt, _WhatTheyEnter);
    }

    public void Load(string openName) {
        string[] = line;
        _entries.Add(new Entry);
    }

    public void Save(string openName) {
    }
}