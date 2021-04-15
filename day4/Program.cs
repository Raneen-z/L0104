using System;

namespace day4
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "_This11 33 5e is ";

            //tokenizer(value);
            color("#ff43 #46 ## kkfr #2776555#5550d #");
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] >= 32 && value[i]<=57 && value[i] != ' ')
                {
                    
                    //Console.WriteLine("values ="+value[i]);
                }
            }
        }

        static void color(string palate)
        {
            int i = 0;
            string colors = "";
            while (i < palate.Length)
            {
                string token = "";
                if (palate[i] == '#')
                {
                    token += palate[i++];
                    int count = 1;
                    while (i < palate.Length && count<7)
                    {
                        if (Char.IsLetterOrDigit(palate[i]))
                        {
                            token += palate[i++];
                            count++;
                        }
                        else if (palate[i] == ' ' || palate[i] == '\n' || palate[i] == '\r' || palate[i] == '\t')
                        {
                            i++;
                            break;
                        }
                        else
                        {
                            i++;
                            token = "";
                            break;
                        }

                    }

                    if (token.Length > 2)
                    {
                        if (token.Length < 7)
                        {
                            var len = 6 - (token.Length - 1);
                            for (int j = 0; j < len; j++)
                            {
                                token += "0";
                            }
                        }
                        colors += token + " ";
                    }
                }
                else
                {
                    i++;
                    continue;
                }
                
            }
            Console.WriteLine(colors);
        }
        static void tokenizer (string source)
        {
            int i = 0;
            while (i < source.Length)
            {
                //Console.Writeine(source[i++]);
                string token = "";
                if (Char.IsLetter(source[i]) || source[i] =='_')
                {
                    
                    token += source[i++];
                    while (i < source.Length)
                    {
                        if (Char.IsLetterOrDigit(source[i]))
                        {
                            token += source[i++];
                        }
                        else if (source[i] == ' ' || source[i] == '\n' || source[i] == '\r' || source[i] == '\t')
                        {
                            i++;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Error: Token not expected");
                            break;
                        }
                    }
                    
                    Console.WriteLine(token);
                    token = "";

                }
                else if (Char.IsNumber(source[i]))
                {
                    token += source[i++];
                    while (i < source.Length)
                    {
                        if (Char.IsNumber(source[i]))
                        {
                            token += source[i++];
                        }
                        else if (source[i] == ' ' || source[i] == '\n' || source[i] == '\r' || source[i] == '\t')
                        {
                            i++;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Error: Token not expected");
                            break;
                        }
                    }

                    Console.WriteLine(token);
                    token = "";
                }
                else if (source[i] == '=')
                {

                }
                else if (source[i]==' '|| source[i]=='\n'|| source[i]=='\r'|| source[i]=='\t')
                {
                    i++;
                    continue;
                }
                else
                {
                    Console.WriteLine("Error: Token not expected");
                    break;
                }
            }
        }
    }
}
