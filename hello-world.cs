using System;
namespace				
public class Program
{
	enum ESentenceType
	{
		eStatement,
		eExclamation,
		sQuestion,
		eCommand
	}
	
	char GetPunctionMark(ESentenceType sentenceType) 
	{
		char puncMark = '.';
		switch(sentenceType) 
		{
			case ESentenceType.eStatement:
				puncMark = '.';
				break;
			case ESentenceType.eExclamation:
				puncMark = '!'; 
				break;
			case ESentenceType.sQuestion:
				puncMark = '?'; 
				break;
			case ESentenceType.eCommand: 
				puncMark = '.'; 
				break;
			default: 
				return GetPunctionMark(sentenceType); 				
    	}
    	return puncMark;
	}
	
	public static void Main()
	{
		int[] charHexes = {33, 69, 72,  76, 79, 82, 87};		
		
		for(int i = 0; i < charHexes.Length ; i++)
			Console.Write((char)charHexes[i]);
            
		Console.WriteLine("Hello World!");
	}
}
