using System.Collections;
using System.Collections.Generic;

namespace bookshop;

public class Books
{
private List<string> BookName=new List<string>();

public Books()
{
this.BookName.Add("HP1");
this.BookName.Add("HP2");
this.BookName.Add("HP3");
}


public string this[int index]
{
    get{
        return this.BookName[index];
    }

    set{
        this.BookName[index]=value;
    }
}


}

