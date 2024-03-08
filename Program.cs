using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

class PP
{
    static void Main()
    {
        string email1;
        int senha1;


        string email2;
        int senha2;

        bool condicao;


        Console.Write("Digite seu email: ");
        email1 = Console.ReadLine();

        Console.Write("Digite seu sua senha (Apenas Números!!!): ");
        senha1 = int.Parse(Console.ReadLine());



        Console.Write("email: ");
        email2 = Console.ReadLine();

        Console.Write("senha: ");
        senha2 = int.Parse(Console.ReadLine());

        if (email2 == email1)
        {
            Console.Write("\nEmail correto!\n");
        }
        else
        {
            string no;
            Console.Write("Ops... email incorreto. Digite Novamente: ");
            no = Console.ReadLine();
            while (no != email1)
            {
                string na;
                Console.Write("Ops... email incorreto.\n\nDigite Novamente: ");
                na = Console.ReadLine();
                if (na == email1)
                {
                    Console.Write("\nemail correto!\n");
                    break;
                }
            }

        }
        if (senha2 == senha1)
        {
            Console.Write("Senha correta!\n    Logando...");
        }
        else
        {
            int so;
            Console.Write("Senha incorreta! Digite Novamente: ");
            so = int.Parse(Console.ReadLine());
            while (so != senha1)
            {
                int sa;
                Console.Write("Senha incorreta! Digite Novamente: ");
                sa = int.Parse(Console.ReadLine());
                if (sa == senha1)
                {
                    Console.Write("senha correta!\n   Logando...");
                    break;

                }
                
            }
        }

    }
}
