 Console.Clear();
string tecla = "";
while (tecla != "N")
{
    double pontoYdeA, pontoXdeA, 
           pontoYdeB, pontoXdeB, 
           tamanhoRaioA, tamanhoRaioB;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("--- COLISÃO CIRCULAR 2D ---\n");
    Console.ResetColor();
    Console.WriteLine("Forneça informações dos círculos A e B\n");
    
    pontoXdeA = lerInformacao("Coordenada x de A: ");
    pontoYdeA = lerInformacao("Coordenada y de A: ");
    tamanhoRaioA = lerInformacao("Tamanho do raio de A: ");

    pontoXdeB = lerInformacao("\nCoordenada x de B: ");
    pontoYdeB = lerInformacao("Coordenada y de B: ");
    tamanhoRaioB = lerInformacao("Tamanho do raio de B: ");

      bool colisao = DetectarColisao(pontoXdeA, pontoYdeA, tamanhoRaioA,
                                     pontoXdeB, pontoYdeB, tamanhoRaioB);

        if (colisao)
        {
            Console.WriteLine("\nColisão detectada");
        }
        else
        {
            Console.WriteLine("\nNão há colisão");
        }
  
    Console.Write("\nVericar outro valor? [S] [N] ");
    tecla = Console.ReadLine()!.Substring(0,1).ToUpper().Trim();
  }

    double lerInformacao(string mensagem)
    {
       Console.Write(mensagem);
       double valorDigitado = Convert.ToDouble(Console.ReadLine());
       return valorDigitado;
    }

    bool DetectarColisao(double pontoXdeA, double pontoYdeA, double tamanhoRaioA, double pontoXdeB, double pontoYdeB, double tamanhoRaioB)
    {
        // Calcula a distância entre os centros das circunferências
        double distanciaCentros = Math.Sqrt(Math.Pow(pontoXdeB - pontoXdeA, 2) + Math.Pow(pontoYdeB - pontoYdeA, 2));

        if (distanciaCentros <= tamanhoRaioA + tamanhoRaioB)
        {
            return true; // Colisão detectada
        }
        else
        {
            return false; // Não há colisão
        }

  }