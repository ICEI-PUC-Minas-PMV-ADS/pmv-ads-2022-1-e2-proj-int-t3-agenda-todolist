# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

<img width="860" alt="image" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-agenda-todolist/blob/main/docs/img/diagrama%20de%20classes.jpeg">

## Modelo ER

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.]

<img width="860" alt="image" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-agenda-todolist/blob/main/docs/img/diagrama%20ER.jpeg">

## Esquema Relacional

O Esquema Relacional corresponde à representação dos dados em tabelas juntamente com as restrições de integridade e chave primária.
 
<img width="860" alt="image" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-agenda-todolist/blob/main/docs/img/esquema%20relacional.jpeg">

## Tecnologias Utilizadas

Para o backend utilizaremos da linguagem C# utilizando o framework hibernate para gerenciamento do bando de dados.
Para o frontend, nos utilizamos de javascript vanila nos utilizando também do materaial framework utilizando Grids.

## Hospedagem

Toda a stack será hospedada no heroku, onde teremos uma app de back em C# e outra de front em JS.
