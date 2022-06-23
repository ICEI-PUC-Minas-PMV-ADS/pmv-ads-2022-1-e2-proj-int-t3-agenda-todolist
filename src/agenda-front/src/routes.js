import {
    BrowserRouter,
    Routes,
    Route,
  } from "react-router-dom";
  import Tarefas from './page/tarefas/tarefas'
  import Login from './page/login/login'

const RoutesManaging = () => {
    return(
        <Routes>
            <Route path="/" element={<Login />} />
            <Route path="/tarefas" element={<Tarefas />} />
        </Routes>
    )
 }
 
 export default RoutesManaging;