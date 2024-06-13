# Controle de Equipamentos

Junior cuida do estoque de equipamentos na empresa onde trabalha. E sempre controla o inventário dos seus equipamentos e as manutenções que eles já sofreram em uma planilha do Excel.

Desta forma, ele resolveu pedir ajuda do pessoal da Academia do Programador no desenvolvimento de um Software para automatizar o seu serviço.  

![Gestao Equipamentos](gestao-equipamentos.gif)

## Autenticação

Criar uma tela para solicitar login de usuario.

Deve pedir logon
Deve pedir senha

## 1. CRUD
## 1.1 CREATE
Requisito 1.1: Como funcionário, Junior quer ter a possibilidade de registrar equipamentos.

Deve ter um nome com no mínimo 6 caracteres;
Deve ter um preço de aquisição;
Deve ter um número de série;
Deve ter uma data de fabricação;
Deve ter um fabricante;
Deve ter uma data da ultima manutenção

## 1.2 READ
Requisito 1.2: Como funcionário, Junior quer ter a possibilidade de visualizar todos os equipamentos registrados em seu inventário.

Deve mostrar o número;
Deve mostrar o nome;
Deve mostrar o preço;
Deve mostrar o nome;
Deve mostrar o fabricante;
Deve mostrar a data de fabricação;
Deve mostrar a data da ultima manutenção

## 1.3 UPDATE
Requisito 1.3: Como funcionário, Junior quer ter a possibilidade de editar um equipamento, sendo que ele possa editar todos os campos.

Deve ter os mesmos critérios que o Requisito 1.1.

## 1.4 DELETE
Requisito 1.4: Como funcionário, Junior quer ter a possibilidade de excluir um equipamento que esteja registrado.

## Planilha

```
Número;Nome do Equipamento;Preço;Número de Série;Data de Fabricação;Fabricante;Data da Última Manutenção
001;Computador Dell XPS;3500.00;SN123456;2022-01-15;Dell;2023-06-12
002;Impressora HP LaserJet;1200.00;SN234567;2021-11-20;HP;2023-06-01
003;Projetor Epson;2500.00;SN345678;2023-03-05;Epson;2023-06-05
004;Roteador TP-Link;300.00;SN456789;2020-07-18;TP-Link;2023-05-15
005;Telefone IP Cisco;600.00;SN567890;2019-09-25;Cisco;2023-04-20
006;Notebook Lenovo ThinkPad;4500.00;SN678901;2021-06-10;Lenovo;2023-05-30
007;Monitor LG UltraWide;1200.00;SN789012;2022-04-12;LG;2023-03-12
008;Scanner Canon;800.00;SN890123;2021-08-30;Canon;2023-02-15
009;Servidor Dell PowerEdge;15000.00;SN901234;2020-02-25;Dell;2023-01-25
010;Switch Cisco;2000.00;SN012345;2019-12-15;Cisco;2023-04-05
```

---
## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
---
## Como Usar

#### Fork repositorio
```
git clone https://github.com/Academia-programador-back-end-2024/bk-ap-gestao-equipamentos.git
```

#### Navegue até a pasta raiz da solução
```
cd gestao-equipamentos
```

#### Restaure as dependências
```
dotnet restore .\GestaoEquipamentos.sln
```

#### Navegue até a pasta do projeto
```
cd GestaoEquipamentos.WinFormsApp
```

#### Execute o projeto
```
dotnet run
```