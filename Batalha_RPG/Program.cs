// inicializa a integridade dos personagens
int heroi = 10;
int monstro = 10;

Random dados = new Random();

//Loop do jogo
do 
{
    //O primeiro ataque é do herói
    int ataqueHeroi = dados.Next(1, 11);
    monstro -= ataqueHeroi;
    Console.WriteLine($"O Monstro foi atacado e perdeu {ataqueHeroi} de vida, restam {monstro} ");

    //Verifica se o monstro está morto
    if (monstro > 0)
    {
        int ataqueMonstro = dados.Next(1, 11);
        heroi -= ataqueMonstro;
        Console.WriteLine($"O Herói foi atacado e perdeu {ataqueMonstro} de vida, restam {heroi}"); 
    }

} while (heroi > 0 && monstro > 0 );

// verifica quem venceu essa batalha mortal

Console.WriteLine(heroi > monstro ? "Heroi Venceu!" : "Monstro Venceu!");