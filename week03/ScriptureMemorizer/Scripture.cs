using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;


public class Scripture
{
    private Reference _reference ;
    private Random _random = new Random ();

    private  List<Word> _words = new List<Word>();

    

   public Scripture(Reference reference , string text)
    {
        _reference = reference;
         

       string [] parts = text.Split(" ");

       foreach(string part in parts)
        {
            Word word = new Word(part);
            _words.Add(word);
        }

    
       
    }

    public void HideRandomWords (int numberToHide)
    {




            int hiddenCount = 0;
            while (hiddenCount<numberToHide)
            {
                int index = _random.Next(_words.Count);

                Word word = _words[index];




                if(!_words[index].IsHidden())
                {
                    _words[index].Hide();
                    hiddenCount++;
                }

                if (IsCompletelyHidden())
                {
                    break;
                }
            
            
            }
     

     
       
    }

    public string GetDisplayText()
    {
        string display = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            display = display + word.GetDisplayText() + " ";
        }

        return display;
    }


    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
           if(!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }



    
}