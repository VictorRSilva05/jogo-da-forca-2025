# Jogo Da Forca

![gif jogo da forca](https://imgur.com/r8RgqlY.gif)

## Projeto

Desenvolvido durante o curso Fullstack da <a href="https://academiadoprogramador.net/">Academia do Programador</a> 2025.

## Detalhes 

O computador escolherá, de maneira aleatória, uma palavra entre várias possibilidades*, e o jogador deve chutar, letra por letra, até adivinhá-la.

Se o jogador chutar mais de 5 letras erradas, ele perde.

## Entrada

Os jogadores são solicitados a inserir uma letra por vez através do console. Se a letra estiver presente na palavra, ela será revelada nas posições correspondentes. Se a letra não estiver presente na palavra, uma parte do boneco da forca será desenhada.

## Funcionalidades

- **Escolha de Palavra Secreta:** Uma palavra é escolhida aleatoriamente no início de cada jogo.
- **Representação da Forca:** A forca é desenhada progressivamente no console, com cada erro do jogador.
- **Feedback Visual:** As letras corretamente adivinhadas são exibidas na posição correta, enquanto as não descobertas permanecem ocultas.
- **Contagem de Erros:** O jogo acompanha o número de erros cometidos pelo jogador e termina quando o máximo permitido é alcançado.

## Requisitos

- 
    .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.

## Como usar

**Clone o repositório**

```
git clone https://github.com/academiadoprogramador-fullstack/jogo-da-forca-2025.git
```

**Navegue até a pasta raiz da solução**

```
cd jogo-da-forca-2025
```

**Restaure as dependências**

```
dotnet restore
```

**Navegue até a pasta do projeto**

```
cd JogoDaForca.ConsoleApp
```

**Execute o projeto**

```
dotnet run
```





