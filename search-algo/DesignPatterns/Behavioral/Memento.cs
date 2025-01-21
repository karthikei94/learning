using System;
using System.Collections.Generic;

namespace search_algo.DesignPatterns.Behavioral;

// Memento class
public class TextMemento
{
    public string Content { get; private set; }

    public TextMemento(string content)
    {
        Content = content;
    }
}

// Originator class
public class TextEditor
{
    public string Content { get; set; }

    public Func<TextMemento> Save => () => new TextMemento(Content);

    public Action<TextMemento> Restore => memento => Content = memento.Content;
}

// Caretaker class
public class EditorHistory
{
    private readonly List<TextMemento> _history = new List<TextMemento>();
    private readonly TextEditor _editor;

    public EditorHistory(TextEditor editor)
    {
        _editor = editor;
    }

    public Action Backup => () => _history.Add(_editor.Save());

    public Action Undo => () =>
    {
        if (_history.Count == 0)
        {
            return;
        }

        var memento = _history[^1];
        _history.RemoveAt(_history.Count - 1);
        _editor.Restore(memento);
    };
}

// Client code
public static class MementoPatternExecutor{
    public static void Execute()
    {
        TextEditor editor = new TextEditor();
        EditorHistory history = new EditorHistory(editor);

        editor.Content = "Hello, World!";
        history.Backup();

        editor.Content = "Hello, Design Patterns!";
        history.Backup();

        editor.Content = "Hello, Memento Pattern!";
        Console.WriteLine("Current Content: " + editor.Content);

        history.Undo();
        Console.WriteLine("Restored Content: " + editor.Content);

        history.Undo();
        Console.WriteLine("Restored Content: " + editor.Content);
    }
}    
