import {getData} from '../agent'

const obtemTarefas = () => {
  return getData('task')
  .then(res =>{
    return JSON.parse(res);
  })

}

function PageTarefas() {
  console.log("PageTarefas")
  var lista_tarefas = obtemTarefas()
  return (
    <div className="Tarefas">
        {
            lista_tarefas.map(tarefa =>{
                <p>{tarefa.name}</p>
            })
        }    
    </div>
  );
}

export default PageTarefas;
