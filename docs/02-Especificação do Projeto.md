# Especificações do Projeto
A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foi consolidada com a participação dos usuários em um trabalho de imersão feita pelos membros da equipe a partir da observação dos usuários em seu local natural e por meio de entrevistas. Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários. 

## Personas

Pedro Paulo tem 26 anos, é arquiteto recém-formado e autônomo. Pensa em se desenvolver profissionalmente através de um mestrado fora do país, pois adora viajar, é solteiro e sempre quis fazer um intercâmbio. Está buscando uma agência que o ajude a encontrar universidades na Europa que aceitem alunos estrangeiros.

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários
| Amanda Oliveira                                                                                       |                                                             |                                                                                                                                                                                                                                                                                                                      |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Idade**: 20<br>**Ocupação**: mãe e enfermeira, trabalha em um hospital de plantão 3 dias da semana. | Aplicativos: <br><br>- Instagram <br>- Whatsapp             | Motivações:<br><br>- “Queria um aplicativo que me lembrasse das tarefas que tenho ao longo da semana, para que não esquecesse de nada por passar a maior parte do dia ocupada.”                                                                                                                                      |
| Roberto Silva                                                                                         |                                                             |                                                                                                                                                                                                                                                                                                                      |
| Idade: 18<br>Ocupação: Estudante do ensino médio e vestibulando.                                      | Aplicativos:<br><br>- Instagram<br>- Whatapp<br>- Facebook  | Motivações:<br><br>- “Como estudante, queria uma aplicação que me ajudasse a organizar meus estudos, e que me lembrasse dos horários e dias das minhas provas.”                                                                                                                                                      |
| Julieta Khalir                                                                                        |                                                             |                                                                                                                                                                                                                                                                                                                      |
| Idade: 40<br>Ocupação: Médica Veterinária, trabalha em uma clínica durante meio de semana.            | Aplicativos:<br><br>- Instagram<br>- Whatsapp               | Motivações:<br><br>- “Sou muito desorganizada com papelada. Queria um aplicativo que me ajudasse a organizar os horarios dos meus clientes e dos meus intervalos, sem precisar carregar uma agenda por ai.”                                                                                                          |
| Cláudio Pereira                                                                                       |                                                             |                                                                                                                                                                                                                                                                                                                      |
| Idade: 38<br>Ocupação: SCRUM Master em um banco.                                                      | Aplicativos:<br><br>- Linkedin<br>- Whatsapp<br>- Instagram | Motivações:<br><br>- “Há muita correria para entrega de tarefas, e confusão com as datas, tasks e reuniões. Queria um aplicativo onde todos os desenvolvedores da equipe pudessem acessar, e ver simultaneamente as tarefas a ser concluída e as datas.”                                                             |
| Brenda Ferreira                                                                                       |                                                             |                                                                                                                                                                                                                                                                                                                      |
| Idade: 15 <br>Ocupação: Estudante do ensino fundamental                                               | Aplicativos:<br><br>- Instagram<br>- Whatsapp               | Motivações:<br><br>- “Sou muito avoada, sempre tento manter uma rotina de estudos e afazeres de casa, mas sempre esqueço de reescrever o que tenho que fazer. Queria um aplicativo onde eu pudesse fazer minha rotina e que ela resetasse no dia seguinte, para poder fazer novamente.”                              |
| Lucas Mattos                                                                                          |                                                             |                                                                                                                                                                                                                                                                                                                      |
| Idade: 21 <br>Ocupação: Cursando Ensino Superior em Administração, e trabalha em um escritório.       | Aplicativos:<br><br>- Whatsapp<br>- Instagram               | Motivações:<br><br>- Eu estudo EAD e trabalho também. Tenho liberdade para estudar no escritório, mas eu perco o horario das aulas na maioria das vezes. Queria um aplicativo que me lembrasse o horario das aulas, que aulas seriam e que pudesse colocar um check nessas aulas, para saber que não perdi nenhuma.” |

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

| ID    | Descrição                                                                                                                  | Prioridade |
| ----- | -------------------------------------------------------------------------------------------------------------------------- | ---------- |
| RF-01 | A aplicação deverá ser capaz de cadastrar tarefas do usuário com descrição e data de entrega                               | ALTA       |
| RF-02 | A aplicação deverá ser capaz permitir que um usuário tenha colaboradores no seu grupo de trabalho                          | ALTA       |
| RF-02 | A aplicação deverá ser capaz comportar dois tipos de usuário em um projeto, um usuário colaborador e outro usuário gerente | ALTA       |
| RF-03 | Ao acessar a aplicação o usuário poderá ver uma lista de atividades a serem feitas, mostrando em vermelho as atrasadas     | ALTA       |
| RF-04 | A aplicação poderá mostrar um calendário com todas as tarefas cadastradas pro mês em evidencia                             | MÉDIA      |
| RF-05 | A aplicação deverá permitir que cada tarefa tenha uma subtarefa                                                            | BAIXA      |
| RF-06 | A aplicação deverá permitir o usuário fazer login                                                                          | ALTA       |


### Requisitos não Funcionais

| ID     | Descrição                                                     | Prioridade |
| ------ | ------------------------------------------------------------- | ---------- |
| RNF-01 | O código da aplicação deverá estar publicado no github da PUC | ALTA       |
| RNF-02 | O site da aplicação deverá ser responsivo                     | BAIXA      |


## Restrições


| ID    | Descrição                                                                                                 | Prioridade |
| ----- | --------------------------------------------------------------------------------------------------------- | ---------- |
| RE-01 | O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data final de entrega | ALTA       |
| RE-02 | O aplicativo deve se restringir às tecnologias básicas da Web no Frontend                                 | ALTA       |
| RE-03 | A equipe não pode subcontratar o desenvolvimento do trabalho.                                             | ALTA       |


## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
