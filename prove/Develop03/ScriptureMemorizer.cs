using System;

class ScriptureMemorizer
{
    private scripture;
    private List<string> scripWordsAndList;
    public ScriptureMemorizer(Scripture _scripture);
    {
        scripture = _scripture;
        scripWordsAndList = new List<string>();
        changewordtoitslist();
    }

    private void changewordtoitslist()
    {
        scripWordsAndList = Scripture.returnString().Split();
    }

    public void removewords()
    {
        int numberofWords = new Random().Next(2, 4);
        int wordremove = 0;
        {
            int randomComplete = new Random().Next(0, scriptureList.Count());
            {
                scriptureList[randomComplete] = new string("_".Length);
                wordremove++;
            }
        }
    }

    public string returnString()
    {
        return string.Join('', scripWordsAndList);
    }

    public string haswords()
    {
        string value = false;
        [
            if(word.Has('_' == false))
            {
                value = true;
                break;
            }
        ]
    }

}