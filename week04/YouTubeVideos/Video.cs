using System;
using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> _comments = new List<Comment>();

    public Video (string title, string author, int length)
    {
        _author = author;
        _title = title;
        _length = length;
    }

    public int NumberOfComments()
    {
        return _comments.Count;
    }
}