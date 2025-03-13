# Jogo Da Forca

![gif jogo da forca](https://imgur.com/r8RgqlY.gif)

## Projeto

Desenvolvido durante o curso Fullstack da <a href="https://academiadoprogramador.net/">Academia do Programador</a> 2025.

## Detalhes 

O computador escolher�, de maneira aleat�ria, uma palavra entre v�rias possibilidades*, e o jogador deve chutar, letra por letra, at� adivinh�-la.

Se o jogador chutar mais de 5 letras erradas, ele perde.

## Entrada

Os jogadores s�o solicitados a inserir uma letra por vez atrav�s do console. Se a letra estiver presente na palavra, ela ser� revelada nas posi��es correspondentes. Se a letra n�o estiver presente na palavra, uma parte do boneco da forca ser� desenhada.

## Funcionalidades

- **Escolha de Palavra Secreta:** Uma palavra � escolhida aleatoriamente no in�cio de cada jogo.
- **Representa��o da Forca:** A forca � desenhada progressivamente no console, com cada erro do jogador.
- **Feedback Visual:** As letras corretamente adivinhadas s�o exibidas na posi��o correta, enquanto as n�o descobertas permanecem ocultas.
- **Contagem de Erros:** O jogo acompanha o n�mero de erros cometidos pelo jogador e termina quando o m�ximo permitido � alcan�ado.

## Requisitos

- 
    .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.

## Como usar

**Clone o reposit�rio**

```
git clone https://github.com/academiadoprogramador-fullstack/jogo-da-forca-2025.git
```

**Navegue at� a pasta raiz da solu��o**

```
cd jogo-da-forca-2025
```

**Restaure as depend�ncias**

```
dotnet restore
```

**Navegue at� a pasta do projeto**

```
cd JogoDaForca.ConsoleApp
```

**Execute o projeto**

```
dotnet run
```





