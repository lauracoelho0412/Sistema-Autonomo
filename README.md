# 🦖 Sistema Autônomo Predadores – Draftosaurus

## 📋 Descrição do Projeto

O **Sistema Autônomo Predadores** é uma implementação do jogo **Draftosaurus**, desenvolvida em **C#**, na qual os jogadores são controlados por agentes autônomos capazes de tomar decisões estratégicas sem intervenção humana.

O objetivo do projeto é simular partidas completas do jogo, permitindo o estudo e a comparação de diferentes estratégias de seleção e posicionamento de dinossauros ao longo da partida.

---

## 🎯 Objetivos

* Simular partidas do jogo Draftosaurus de forma automática.
* Gerenciar regras, turnos e pontuação do jogo.
* Aplicar conceitos de Programação Orientada a Objetos (POO).

---

## 🎮 Sobre o Draftosaurus

Draftosaurus é um jogo de mesa baseado na mecânica de *draft*, onde cada jogador administra um parque de dinossauros.

Durante cada rodada:

1. Os jogadores recebem uma mão de dinossauros.
2. Escolhem um dinossauro para manter.
3. Passam os dinossauros restantes para outro jogador.
4. Posicionam o dinossauro escolhido em um recinto do parque.
5. Ao final da partida, os pontos são calculados de acordo com as regras dos recintos.

Neste projeto, todas essas ações são executadas automaticamente pelos agentes implementados.

---

## 🏗️ Estrutura do Projeto

```text
Sistema Autonomo Predadores
│
├── Program.cs
├── Lobby.cs
├── Partida.cs
├── Turno.cs
├── Jogador.cs
├── Dinossauro.cs
├── Ermlogo.cs
├── ListarPartidas.cs
│
├── App.config
├── Resources/
└── Referências/
```

---

## ⚙️ Tecnologias Utilizadas

* C#
* .NET Framework
* Programação Orientada a Objetos (POO)
* Algoritmos de tomada de decisão

---

## 🚀 Como Executar

### Pré-requisitos

* Visual Studio 2019 ou superior
* .NET Framework compatível com o projeto

### Instalação

1. Clone o repositório:

```bash
git clone https://github.com/seu-usuario/sistema-autonomo-predadores.git
```

2. Abra a solução no Visual Studio.

3. Compile o projeto:

```bash
Build > Build Solution
```

4. Execute o programa:

```bash
F5
```

---

## 📊 Funcionalidades

* Simulação automática de partidas de Draftosaurus.
* Gerenciamento de turnos e rodadas.
* Aplicação das regras do jogo.
* Controle de pontuação.
* Tomada de decisão autônoma pelos jogadores.

---

## 🎓 Conceitos Aplicados

* Programação Orientada a Objetos
* Encapsulamento
* Herança
* Polimorfismo
* Estruturas de Dados
* Sistemas Baseados em Agentes
* Algoritmos de Busca e Decisão

---

## 👥 Equipe

Projeto desenvolvido para fins acadêmicos, visando aplicar conceitos de Inteligência Artificial e Programação Orientada a Objetos na simulação de jogos de estratégia.
