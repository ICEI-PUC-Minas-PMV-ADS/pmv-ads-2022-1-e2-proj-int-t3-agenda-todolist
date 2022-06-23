import * as React from 'react';
import Box from '@mui/material/Box';
import TextField from '@mui/material/TextField';
import Button from '@mui/material/Button';
import Grid from '@mui/material/Grid';
import client from '../../agent'
import {
    useParams,
    useNavigate,
    useLocation,
  } from "react-router-dom";

class Tarefas extends React.Component {
    constructor(props) {
      super(props);

      this.state = { // defino o estado da aplicação
        tarefas: [] // estado inicial com tarefas nulas
        };
    }

  componentDidMount() { // quando o componente renderizar
    client.get('task').then(res => this.stateManager(res)) // busco todas as tarefas na url 'task' e coloco no estado
  }

  componentWillUnmount() { // quando o componente desrenderizar
    this.stateManager(null)
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
                  </Grid>
              </Grid>
          </Box>
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