using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botao_da_probabilidade.Funcoes;

internal class Funcoes
{
    public static int Pontuacao { get; set; }
    public static int PontuacaoMaxima { get; set; }


    public static void ExibirTelaInicial()
    {
        Console.Clear();
        Console.WriteLine(@"       █████                               █████              ███        ███
      ░░███                               ░░███              ░░░       ███░ 
       ░███ ██████  ███████ ██████      ███████  ██████              ███░   
       ░██████░░██████░░██████░░███    ███░░███ ░░░░░███           ███░     
       ░██░███ ░██░███ ░██░███ ░███   ░███ ░███  ███████         ███░       
 ███   ░██░███ ░██░███ ░██░███ ░███   ░███ ░███ ███░░███       ███░         
░░████████░░██████░░██████░░██████    ░░███████░░████████    ███░       ███ 
 ░░░░░░░░  ░░░░░░  ░░░░░███░░░░░░      ░░░░░░░░ ░░░░░░░░    ░░░        ░░░  
                   ███ ░███                                                 
                  ░░██████                                                  
                   ░░░░░░                                                   ");
        Console.WriteLine($@"
                            @@@@@@@@@@@@@@@@@@                            
                        @@@@                  @@@@                        
                     @@@                          @@@                    
                  @@@                                @@@                  
                 @@                                    @@                
               @@                                        @@               
              @@                                          @@              
             @@                                             @@            
            @@                                               @@          
           @@                                                 @@          
           @@                                                 @@           
          @@                                                   @@         
          @@                Pressione 'Espaço'                 @@         
          @@               para apertar o botão                @@         
          @@                                                   @@         
          @@               Pontuação Máxima: {PontuacaoMaxima.ToString().PadLeft(3)}               @@         
          @@               Pontuação Atual:  {Pontuacao.ToString().PadLeft(3)}               @@         
          @@                                                   @@         
           @@                                                 @@          
           @@                                                 @@          
            @@                                               @@          
             @@                                             @@            
              @@                                           @@            
               @@                                        @@@              
                @@@                                     @@                
                  @@@                                @@@                  
                    @@@@                           @@@                    
                       @@@@                    @@@@                       
                          @@@@@@@@@@@@@@@@@@@@@@                          
                                   @@@@                                  
        ");
        
    }

    public static void ApertarBotao()
    {
        Console.ReadKey();

        int numeroAleatorio = new Random().Next(1, 101);

        if (Pontuacao < numeroAleatorio)
        {
            Pontuacao++;

            if (Pontuacao > PontuacaoMaxima)
            {
                PontuacaoMaxima = Pontuacao;
            }
        }
        else
        {
            Pontuacao = 0;
        }
    }

}
