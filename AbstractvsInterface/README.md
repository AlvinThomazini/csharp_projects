*O que é uma Interface?* 
Uma interface é como um contrato que define regras. Ela diz o que uma classe precisa fazer, mas não diz como fazer.

- Você não pode criar objetos de uma interface (não é instanciável).
- Uma classe pode seguir várias interfaces ao mesmo tempo.
- Interfaces não têm código pronto (até o C# 8).

*O que é uma Classe Abstrata?*
Uma classe abstrata é como um "modelo" para outras classes. Ela pode ter métodos que já funcionam e métodos que precisam ser definidos nas classes filhas.
Agora, imagine que você tem apenas uma receita de bolo (classe abstrata). Você não pode comer uma receita, só um bolo real.

- Não pode ser usada diretamente (não pode criar um new Animal())
- Pode ter código pronto e também pode ter métodos abstratos (que devem ser implementados depois).
- Serve como base para outras classes (uso de herança).


*O que é o problema da "Herança Diamante"?*

- Ocorre quando uma classe herda de duas classes diferentes que têm um ancestral comum, gerando conflito na herança múltipla.
- C# resolve isso proibindo herança múltipla de classes, mas permite múltiplas interfaces.

Exemplo:

    A
   / \
  B   C
   \ /
    D