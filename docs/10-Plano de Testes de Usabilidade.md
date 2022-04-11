# Plano de Testes de Usabilidade

O teste de usabilidade busca avaliar a facilidade de uso e eficiência de uma interface, obter insights e compreender melhor a experiência do usuário com o produto.
Objetivo:
Observar usuários utilizando o produto para identificar problemas, descobrir oportunidades de melhorias e entender melhor sobre o comportamento e preferencias do seu público alvo.
O que será mensurado durante os testes?

- qualidade da navegação
- dificuldades no fluxo em que o usuário enfrenta durante o uso
- satisfação do usuário

Métodos utilizados: Avaliação e medição
Em cada tarefa realizada por cada participante, é possível medir:

- o grau de sucesso da execução,
- total de erros cometidos,
- quantos erros de cada tipo ocorreram,
- quanto tempo foi necessário para concluir a tarefa

Roteiro:

| Caso de Teste       | CT-01 – Prevenir erros                                                                                                                                     |
| ------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisito Associado | RNF-06 A aplicação deve ser intuitiva, de fácil utilização, entendimento e deve ser organizado de tal maneira que os erros dos usuários sejam minimizados. |
| Objetivo do Teste   | Verificar a existência de caixas de confirmação de ação.                                                                                                   |
| Passos              | Ao clicar em "Remover terefa” apresentar ao usuário uma mensagem para validar o remoção.                                                                   |
| Critérios de Êxito  | "Deseja remover essa tarefa? ".                                                                                                                            |

| Caso de Teste       | CT-02 – Fornecer feedbacks informativos e marcar o final dos diálogos                                                       |
| ------------------- | --------------------------------------------------------------------------------------------------------------------------- |
| Requisito Associado | RNF-05 A aplicação deverá retornar ao usuário mensagem com informação de ajuda e ao término de uma tarefa.                  |
| Objetivo do Teste   | Verificar a existência de caixas de mensagens informativas e de fim.                                                        |
| Passos              | Na ação do usuário a aplicação deve prover uma resposta informativa e deixar claro quando uma ação foi concluída com êxito. |
| Critérios de Êxito  | "Cadastro realizado com sucesso";                                                                                           |

| Caso de Teste       | CT-03 – Usuário reconhecer, diagnosticar e recuperar seus erros                                                                                                 |
| ------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisito Associado | RNF-03 Os formulários devem informar ao usuário quais são os campos de preenchimento obrigatório.                                                               |
| Objetivo do Teste   | Ajudar o usuário a reparar um erro.                                                                                                                             |
| Passos              | Informar ao usuário os campos obrigatórios, apresentar aviso de formulários.                                                                                    |
| Critérios de Êxito  | (*) Campo de preenchimento obrigatório; Mensagem de informação do tipo do campo, por exemplo no campo Nome da terefa mostrar o texto “Insira o nome da terefa”. |

| Caso de Teste       | CT-04 – Acessibilidade                                                                                                                                                                                           |
| ------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisito Associado | RNF-08 A aplicação ou parte dela deve ser acessível por pessoas com certo tipo de deficiência ou outra necessidade específica.                                                                                   |
| Objetivo do Teste   | Verificar se todas as imagens apresenta informação de descrição.                                                                                                                                                 |
| Passos              | Conferir se em todas as imagens, foi atribuído um texto alternativo, para que se por algum motivo a imagem não for carregada ou o usuário esteja utilizando leitor de tela ele consiga entender do que se trata. |
| Critérios de Êxito  | O atributo alt do HTML deve apresentar texto referente a exibição.                                                                                                                                               |

| Caso de Teste       | CT-05 – Reconhecer, em vez de recordar                                                                                              |
| ------------------- | ----------------------------------------------------------------------------------------------------------------------------------- |
| Requisito Associado | RNF-04 Utilizar símbolo e ícone para ajudar no entendimento e conseguir uma associação imediata sobre aplicações de reconhecimento. |
| Objetivo do Teste   | Verificar se a aplicação possui ícones que apenas olhando o símbolo já reconhece o que significa.                                   |
| Passos              | Prover interação por meio da imagem que significa o item que pretende representar.                                                  |
| Critérios de Êxito  | "Salvar Alterações" com o ícone de um disquete.                                                                                     |

| Caso de Teste       | CT-06 – Consistência e Padronização                                                                                                                                                          |
| ------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisito Associado | RNF-07 A aplicação deve possuir uma interface limpa, com visualização voltada apenas para as necessidades do usuário no momento, também como forma de melhorar a performance e o desempenho. |
| Objetivo do Teste   | Verificar a existência de padrões de uma mesma ação em diferentes momentos.                                                                                                                  |
| Passos              | Seguir sempre o mesmo padrão de interface e interação.                                                                                                                                       |
| Critérios de Êxito  | Verbos padronizados.                                                                                                                                                                         |

Perfil dos participantes: Usuários que se encaixam na persona definida na metodologia do trabalho, afim de obter detalhes mais precisos.
