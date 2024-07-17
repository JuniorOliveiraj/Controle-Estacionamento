# Controle de Estacionamento - Dashboard


![Dashboard Preview](https://raw.githubusercontent.com/JuniorOliveiraj/Controle-Estacionamento/main/JR%20Sofware/assts/GIT/interface%20dashboard.png)

## dados
![Adionar dados ]([https://raw.githubusercontent.com/JuniorOliveiraj/Controle-Estacionamento/main/JR%20Sofware/assts/GIT/interface%20dashboard.png](https://raw.githubusercontent.com/JuniorOliveiraj/Controle-Estacionamento/main/JR%20Sofware/assts/GIT/add%20entrada.png)

## Descrição
Este projeto é uma aplicação de controle de estacionamento desenvolvida em C# utilizando Windows Forms e MySQL. A aplicação permite o registro de entrada e saída de veículos, calculando o tempo de permanência e o valor a ser pago com base nas tarifas definidas para diferentes tipos de veículos. Além disso, gera relatórios mensais que incluem a soma dos valores arrecadados e a quantidade de veículos atendidos, apresentando esses dados em um gráfico para uma visualização clara.

## Funcionalidades
- Registro de entrada e saída de veículos
- Cálculo automático das horas de permanência
- Cálculo do valor a ser pago conforme a tarifa específica do veículo
- Geração de relatórios mensais com:
  - Soma dos valores arrecadados
  - Quantidade de veículos atendidos

## Tecnologias Utilizadas
- C# (linguagem de programação)
- Windows Forms (framework para desenvolvimento de aplicativos desktop)
- MySQL (sistema de gerenciamento de banco de dados)

## Instalação e Configuração
### Clonar o repositório

Para clonar o repositório e todos os submódulos necessários, execute o seguinte comando:

```sh
git clone --recursive https://github.com/JuniorOliveiraj/Controle-Estacionamento.git
```
1. **Pré-requisitos:**
   - Visual Studio (ou outro IDE para desenvolvimento em C#)
   - MySQL Server

2. **Configuração do Banco de Dados:**
   - Importe o script SQL fornecido (`/assts/script.sql`) para criar as tabelas necessárias no MySQL.

3. **Configuração do Projeto:**
   - Clone o repositório para a sua máquina local.
   - Abra o projeto no Visual Studio.
   - Certifique-se de configurar a conexão com o banco de dados no arquivo de configuração (`app.config` ou similar).

4. **Execução:**
   - Compile e execute o projeto no Visual Studio.
   - A aplicação estará pronta para uso.

## Uso
- Ao iniciar a aplicação, você será apresentado à interface principal de login da dashboard.
- Registre a entrada e saída de veículos clicando nos botões apropriados e preenchendo as informações solicitadas.
- Os cálculos de tempo e valor serão feitos automaticamente.
- Acesse os relatórios mensais através da seção correspondente na interface para visualizar os gráficos gerados.

![Relatório Mensal](images/monthly-report.png)




