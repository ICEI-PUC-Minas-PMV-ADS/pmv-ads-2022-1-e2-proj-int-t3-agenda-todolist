import * as React from 'react';
import Box from '@mui/material/Box';
import TextField from '@mui/material/TextField';
import Button from '@mui/material/Button';
import Grid from '@mui/material/Grid';
import {get, post, del} from '../../agent'
import {
    useParams,
    useNavigate,
    useLocation,
  } from "react-router-dom";

import SpeedDial from '@mui/material/SpeedDial';
import SpeedDialIcon from '@mui/material/SpeedDialIcon';
import SpeedDialAction from '@mui/material/SpeedDialAction';
import SaveIcon from '@mui/icons-material/Save';
import List from '@mui/material/List';
import ListItem from '@mui/material/ListItem';
import ListItemText from '@mui/material/ListItemText';
import ListItemAvatar from '@mui/material/ListItemAvatar';
import Avatar from '@mui/material/Avatar';
import ImageIcon from '@mui/icons-material/Image';
import IconButton from '@mui/material/IconButton';
import WorkIcon from '@mui/icons-material/Work';
import BeachAccessIcon from '@mui/icons-material/BeachAccess';
import Modal from '@mui/material/Modal';
import DeleteIcon from '@mui/icons-material/Delete';
import { CompressOutlined } from '@mui/icons-material';
import Switch from '@mui/material/Switch';


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

const listItemStyle = {
  padding: '6px',
  textAlign: 'center',
  backgroundColor: '#EAEAEA',
  borderRadius: '6px',
  marginRight: '7px',
  boxShadow: '1px 1px 8px gray',
  flexGrow: '1'
}

const actions = [
  { icon: <SaveIcon />, name: 'Save' }
];


class Tarefas extends React.Component {
    constructor(props) {
      super(props);

      this.state = { // defino o estado da aplicação
        modalIsopen: false,
        usrError: false,
        newTask: {
          name: null,
          status: "PENDING",
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

  deleteTask = async (id) => {
    await del(`task/${id}`) 
    .then(async (res) => { 
      await get('task').then(res => { 
        this.stateManager(res)
      }) 
    })
    .catch((err) => { // acha o erro caso dê
      console.log(err)
      this.setState({ usrError: true }) 
    })

  }


  updateTask = async (task) => {
    await post(`task/${task.id}`, task) 
    .then(async (res) => { 
      await get('task').then(res => { 
        this.stateManager(res)
      }) 
    })
    .catch((err) => { // acha o erro caso dê
      console.log(err)
      this.setState({ usrError: true }) 
    })

  }

  handleUpdateStatusTask = async (task) => {
    console.log(task)
    this.setState({
      tarefas: [
        ...this.state.tarefas.map(x => {
          if(x.id == task.id){
            x.status = "DONE";
            this.updateTask(task);
          }
          return x
        })] 
    });
  }

  handleOpen = () =>  this.setState({ modalIsopen: true });
  handleClose = () =>  this.setState({ modalIsopen: false });
  createtask =  async () =>{
    await post('task', this.state.newTask) 
    .then((res) => { 
      get('task').then(res => { 
        this.handleClose()
        this.stateManager(res)
      }) 
    })
    .catch((err) => { // acha o erro caso dê
      console.log(err)
      this.setState({ usrError: true }) 
    })
  }

  stateManager(value) {
    this.setState({
      tarefas: value
    });
  }

    render() {
      return (
        <div className="App" style={{backgroundColor: '#37a1ed'}}>
          <Box sx={{ margin: '0 0 0 20px', minHeight: '600px', width: '50%', flexGrow: 1, padding: '24px', backgroundColor: '#f5ef98', borderRadius: '10px' }}>
              <Grid container spacing={2}>
                  <Grid item xs={12}>
                      <h1 style={{ color: '#ebba34', textDecoration: 'underline'}}>Tarefas</h1>
                  </Grid>
                  <Grid item xs={12}>
                    <Grid container spacing={2}>
                       {/* coluna 1 - Em andamento */}
                      <Grid item xs={6}> 
                        <h2>Em andamento</h2>
                        <List sx={{ width: '100%', maxWidth: 360, bgcolor: 'background.paper' }}>
                          {this.state.tarefas?.filter(x => x.status == 'PENDING').map(res => 
                          (
                            <ListItem 
                            secondaryAction={
                              <IconButton edge="end" aria-label="delete" onClick={() =>{this.deleteTask(res.id)}}>
                                <DeleteIcon />
                              </IconButton>
                            }>
                              <ListItemAvatar>
                                <Avatar>
                                  <ImageIcon />
                                </Avatar>
                              </ListItemAvatar>
                              <ListItemText primary={res.name} secondary={res.description}/>
                              <Switch
                                edge="end"
                                onChange={() => {this.handleUpdateStatusTask(res)}}
                                checked={res.status == "DONE"}
                                inputProps={{
                                  'aria-labelledby': 'switch-list-label-bluetooth',
                                }}
                              />
                            </ListItem>

                          ))}
                          </List>
                      </Grid>
                       {/* coluna 2 - Feito  */}
                      <Grid item xs={6} style={{ display: 'flex', flexDirection: 'column'}}>
                        <h2>Feito ;)</h2>

                        <List sx={{ width: '100%', maxWidth: 360, bgcolor: 'background.paper' }}>
                          {this.state.tarefas?.filter(x => x.status == 'DONE').map(res => 
                          (
                            <ListItem 
                            secondaryAction={
                              <IconButton edge="end" aria-label="delete" onClick={() =>{this.deleteTask(res.id)}}>
                                <DeleteIcon />
                              </IconButton>
                            }>
                              <ListItemAvatar>
                                <Avatar>
                                  <ImageIcon />
                                </Avatar>
                              </ListItemAvatar>
                              <ListItemText primary={res.name} secondary={res.description}/>
                              <Switch
                                edge="end"
                                onChange={() => {this.handleUpdateStatusTask(res)}}
                                checked={res.status == "DONE"}
                                inputProps={{
                                  'aria-labelledby': 'switch-list-label-bluetooth',
                                }}
                              />
                            </ListItem>

                          ))}
                          </List>
                      </Grid>
                    </Grid>
                  </Grid>
              </Grid>

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

          <Box sx={{ height: 320, transform: 'translateZ(0px)', flexGrow: 1 }}>
          </Box>
          <Modal
            open={this.state.modalIsopen}
            onClose={this.handleClose}
            aria-labelledby="modal-modal-title"
            aria-describedby="modal-modal-description"
          >
            <Box sx={style}>
              <Grid container>
                <Grid item xs={12}> 
                  <h2>Cria uma task</h2>
                  <TextField id="outlined-basic" label="nome" variant="outlined" value={this.state.newTask.name} 
                  onChange={(e) => this.setState({ newTask: { ...this.state.newTask, name: e.target.value }})} 
                  />
                </Grid>

                <Grid item xs={12}>
                  <TextField id="outlined-basic" label="descricao" variant="outlined" value={this.state.newTask.description} 
                  onChange={(e) => this.setState({ newTask: { ...this.state.newTask, description: e.target.value}})}  
                  />
                </Grid>

                <Grid item xs={12}>
                  <Button variant="contained" onClick={()=>this.createtask()}  >Enviar</Button>
                </Grid>

              </Grid>
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