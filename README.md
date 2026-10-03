# Jogo do Herói em C#

Jogo de ação 2D desenvolvido como projeto de estudo durante minhas aulas de C# na ETEC de Embu. O principal objetivo do projeto foi entender, na prática, conceitos de Programação Orientada a Objetos (POO), como classes, objetos, herança, atributos e métodos.

## Sobre o jogo

Você controla um herói que precisa enfrentar os inimigos de cada cenário. O herói pode se movimentar pela tela e lançar projéteis, enquanto os chefes se movimentam e atacam de volta. É preciso desviar dos disparos, administrar os tiros disponíveis e derrotar cada chefe para avançar.

O jogo tem três cenários, cada um com um chefe. A dificuldade aumenta durante a progressão: os chefes seguintes têm mais vida e seus ataques ficam mais rápidos. Ao derrotar um chefe, avance para a direita para chegar ao próximo cenário.

## Objetivo

Derrote os chefes dos três cenários e sobreviva até o final. A partida termina em vitória após derrotar o último chefe ou em derrota se o herói perder toda a vida.

## Como jogar

| Tecla | Ação |
| --- | --- |
| `W` | Mover o herói para cima |
| `A` | Mover o herói para a esquerda |
| `S` | Mover o herói para baixo |
| `D` | Mover o herói para a direita |
| `Espaço` | Atirar na direção do inimigo |

Use as teclas de movimento para desviar dos projéteis inimigos. A barra na parte inferior indica os tiros disponíveis; no início, há quatro tiros. Os disparos são recuperados quando o projétil termina seu percurso ou acerta um inimigo. Os ícones na tela indicam as defesas e a vida do herói e do chefe.

## O projeto e POO

O jogo foi construído com Windows Forms. Algumas classes ilustram os conceitos estudados:

- `Personagem` reúne propriedades e comportamentos comuns aos personagens.
- `heroi` e `Inimigo` herdam de `Personagem` e implementam comportamentos específicos, como movimentação e perda de vida.
- `tiro` e `tiroInimigo` representam os projéteis do herói e dos chefes.
- `MainForm` organiza a janela do jogo, os controles, os cenários e os elementos visuais.

## Tecnologias

- C#
- Windows Forms
- .NET Framework 4.0

## Como abrir, compilar e executar

1. Abra `atividadeObjetoHeroi.sln` no Visual Studio.
2. Selecione a configuração **Debug** e compile com **Compilar > Compilar Solução** ou `Ctrl+Shift+B`.
3. Execute o projeto pelo Visual Studio. Também é possível iniciar `atividadeObjetoHeroi\bin\Debug\atividadeObjetoHeroi.exe`.

Os arquivos de imagem e animação usados pelo jogo são carregados durante a execução. Execute o programa em um diretório que contenha esses arquivos, como a pasta `atividadeObjetoHeroi\bin\Debug`.
