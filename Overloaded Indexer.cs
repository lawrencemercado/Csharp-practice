using System;

class IndexerOverload
{
    private string[] data;
    private int size;
    
    public IndexerOverload(int z)
    {
        size =z;
        data = new string [size];
        for(int counter = 0; counter<size;counter++)
        {
            data[counter] = "empty";
        }
        
    }
    
    public string this[int pos]
    {
        get 
        {
            return data[pos];
        }
        
        set
        {
            data[pos] = value;
        }
    }
    
    public string this[string alter]
    {
        get
        {
            int count =0;
          for(int x =0; x<size; x++)
          {
              if(data[x]==alter)
              count++;
          }
          
          return count.ToString();
        }
        
        set
        {
           for(int x = 0; x<size; x++)
           {
               if (data[x]==alter)
               data[x]= value;
           }
        }
    }
    static void Main()
    {
        int y = 10;
     IndexerOverload ind = new IndexerOverload(y);
     
     ind[5] = "testing";
     ind[7] = "gumana";
     ind[9] = "good job lawrence!";
     
     ind["empty"] = "ok";
     
     Console.WriteLine("Output of Indexer");
     
     for(int x = 0; x<y; x++)
     {
         Console.WriteLine("ind[{0}]: {1}", x, ind[x]);
     }
     Console.WriteLine("\nNumber of \"no value\" entries: {0}", ind["ok"]);
    }
}