class Program
{
    static char CheckChar(char inputFlower)
    {
        char check;
        switch(inputFlower)
        {
            case'J':
            case'G':
            case'R':
            case'O': check = 'Y';break;
            default: check = 'N';break;
        }
        return check;
    }
    static void InputFlower(CircularLinkedList<char> MalaiList)
    {
        char inputFlower;
        while(true)
        {
            inputFlower = char.Parse(Console.ReadLine());
            
            if(inputFlower == 'R')
            {
                MalaiList.Add(inputFlower);
                inputFlower = char.Parse(Console.ReadLine());
                if(CheckChar(inputFlower)=='N')
                {
                    break;
                }

                MalaiList.Add(inputFlower);
                int a = MalaiList.GetLength();
                if(MalaiList.Get(-1)==MalaiList.Get(-3))
                {
                    MalaiList.Remove(a-1);
                    Console.WriteLine("invaid pattern");
                }
                inputFlower = char.Parse(Console.ReadLine());
                if(CheckChar(inputFlower)=='N')
                {
                    break;
                }
                MalaiList.Add(inputFlower);
                while(MalaiList.Get(-1)==MalaiList.Get(-3))
                {
                    MalaiList.Remove(-1);
                    Console.WriteLine("invaid pattern");
                    inputFlower = char.Parse(Console.ReadLine());
                    if(CheckChar(inputFlower)=='N')
                    {
                        break;
                    }
                    MalaiList.Add(inputFlower);
                }
            }

            else if(inputFlower == 'J')
            {
                MalaiList.Add(inputFlower);
            }

            else if(inputFlower == 'O')
            {
                MalaiList.Add(inputFlower);
            }
            
            else if(inputFlower == 'G')
            {
                MalaiList.Add(inputFlower);
                inputFlower = char.Parse(Console.ReadLine());
                if(CheckChar(inputFlower)=='N')
                {
                    break;
                }
                MalaiList.Add(inputFlower);
                if(inputFlower == 'R')
                {
                    inputFlower = char.Parse(Console.ReadLine());
                    while(inputFlower == 'G')
                    {
                        Console.WriteLine("invaid pattern");
                        inputFlower = char.Parse(Console.ReadLine());
                        if(CheckChar(inputFlower)=='N')
                        {
                            break;
                        }
                    }

                }
                MalaiList.Add(inputFlower);
                if(MalaiList.Get(-1)==MalaiList.Get(-2))
                {
                    inputFlower = char.Parse(Console.ReadLine());
                    if(CheckChar(inputFlower)=='N')
                    {
                        break;
                    }
                    MalaiList.Add(inputFlower);
                    if(MalaiList.Get(-1)==MalaiList.Get(-2)&&MalaiList.Get(-2)==MalaiList.Get(-3))
                    {
                        inputFlower = char.Parse(Console.ReadLine());
                        if(CheckChar(inputFlower)=='N')
                        {
                            break;
                        }
                        while(inputFlower == 'G')
                        {
                            Console.WriteLine("invaid pattern");
                            inputFlower = char.Parse(Console.ReadLine());
                        }
                        if(CheckChar(inputFlower)=='N')
                        {
                            break;
                        }
                        MalaiList.Add(inputFlower);
                    }
                    
                }
                
            }
            
            else
            {
                break;
            }
            
            
        }
    }
    
    static void Main(string[] args)
    {
        CircularLinkedList<char> MalaiList = new CircularLinkedList<char>();
        InputFlower(MalaiList);


        for(int i=0; i<MalaiList.GetLength(); i++)
        {
            Console.WriteLine(MalaiList.Get(i));
        }
    }
}
