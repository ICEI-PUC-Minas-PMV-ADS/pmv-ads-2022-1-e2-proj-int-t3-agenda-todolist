import * as React from 'react';
import Box from '@mui/material/Box';
import TextField from '@mui/material/TextField';
import Button from '@mui/material/Button';
import Grid from '@mui/material/Grid';
import {get} from '../../agent'
import {
    useParams,
    useNavigate,
    useLocation,
  } from "react-router-dom";

import SpeedDial from '@mui/material/SpeedDial';
import SpeedDialIcon from '@mui/material/SpeedDialIcon';
import SpeedDialAction from '@mui/material/SpeedDialAction';
import SaveIcon from '@mui/icons-material/Save';
import Typography from '@mui/material/Typography';
import Modal from '@mui/material/Modal';

const style = {
  position: 'absolute',
  top: '50%',
  left: '50%',
  transform: 'translate(-50%, -50%)',
  width: 400,
  bgcolor: 'background.paper',
  border: '2px solid #000',
  boxShadow: 24,
  p: 4,
};

const actions = [
  { icon: <SaveIcon />, name: 'Save' }
];


class Tarefas extends React.Component {
    constructor(props) {
      super(props);

      this.state = { // defino o estado da aplicação
        modalIsopen: false,
        newTask: {
          name: null,
          description: null
        },
        tarefas: [] // estado inicial da lsita de tarefas com tarefas nulas
        };
    }

  componentDidMount() { // quando o componente renderizar 
    get('task').then(res => { // ao renderizar será feito um get no servidor pra buscar todas as tarefas
      this.stateManager(res)// com todas as tarefas em maos, usa setManager para gerenciar o estado da LISTA de tarefas
    }) 
  }

  componentWillUnmount() { // quando o componente desrenderizar
    this.stateManager(null)
  }

  handleOpen = () =>  this.setState({ modalIsopen: true });
  handleClose = () =>  this.setState({ modalIsopen: false });
  enviar = () =>{
    console.log(this.state.newTask)
  }
  stateManager(value) {
    this.setState({
      tarefas: value
    });
  }

    render() {
      return (
        <div className="App">
          <Box sx={{ flexGrow: 1 }}>
              <Grid container spacing={2}>
                  <Grid item xs={12}>
                      <h1>Tarefas</h1>
                  </Grid>
                  <Grid item xs={12}>
                    <Grid container spacing={2}>
                       {/* coluna 1 - Em andamento */}
                      <Grid item xs={6}> 
                        <h2>Em andamento</h2>
                        {this.state.tarefas?.map(res => 
                        (
                        <div>
                          <p>{res.name}</p>
                          <p>x</p> 
                        </div>
                        ))}
                      </Grid>
                       {/* coluna 2 - Feito  */}
                      <Grid item xs={6}>
                        <h2>Feito ;)</h2>
                        {this.state.tarefas?.map(res => <p>{res.name}</p>)}
                      </Grid>
                    </Grid>
                  </Grid>
              </Grid>
          </Box>

          <Box sx={{ height: 320, transform: 'translateZ(0px)', flexGrow: 1 }}>
            <SpeedDial
              ariaLabel="SpeedDial basic example"
              sx={{ position: 'absolute', bottom: 16, right: 16 }}
              icon={<SpeedDialIcon />}
            >
              {actions.map((action) => (
                <SpeedDialAction
                  key={action.name}
                  icon={action.icon}
                  tooltipTitle={action.name}
                  onClick={() => this.handleOpen()}
                />
              ))}
            </SpeedDial>
          </Box>
          <Modal
            open={this.state.modalIsopen}
            onClose={this.handleClose}
            aria-labelledby="modal-modal-title"
            aria-describedby="modal-modal-description"
          >
            <Box sx={style}>
              {/* fazer igual ao login */}
              <TextField id="outlined-basic" label="nome" variant="outlined" value={this.state.newTask.name} 
              onChange={(e) => this.setState({ newTask: { ...this.state.newTask, name: e.target.value }})} 
              />
              <TextField id="outlined-basic" label="descricao" variant="outlined" value={this.state.newTask.description} 
              onChange={(e) => this.setState({ newTask: { ...this.state.newTask, description: e.target.value}})}  
              />
              <Button variant="contained" onClick={()=>this.enviar()}  >Enviar</Button>
            </Box>
          </Modal>
        </div>
      );
    }
  }

  const WrappedComponent = props => {
    console.log('WrappedComponent')
    const navigate = useNavigate();
    const location = useLocation();
    const params = useParams();
    console.log(props)
    props = {
        navigate,
        location,
        params,
        ...props
    }
    console.log(props)
  
    return <Tarefas {...props} />
  }

  export default WrappedComponent;