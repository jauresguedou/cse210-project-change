using System;
using System.Collections.Generic;
using System.IO;


public class Video
{
    private string _title;
    private string _author;
    private string _length;

    public List<Comment> _comments = new List<Comment>();



    public Video (string title,string author,string length)
    {
        _title = title;
        _author = author;
        _length = length;
    }


    public void AddComment (Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public string GetLength()
    {
        return _length;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }





}