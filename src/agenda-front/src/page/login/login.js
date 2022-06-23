import * as React from 'react';
import Box from '@mui/material/Box';
import TextField from '@mui/material/TextField';
import Button from '@mui/material/Button';
import Grid from '@mui/material/Grid';
import {post} from '../../agent'
import {
    useParams,
    useNavigate,
    useLocation,
  } from "react-router-dom";

class Login extends React.Component {
    constructor(props) {
      super(props);
      this.state = {
          Username: null,
          Password: null
        };
    }
    
    doLogin = async () => {
        console.log('fazendo o login')
        // this.props.navigate('tarefas')

        await post('user/login', this.state)
        .then((res) => console.log(res))
        .catch((err) => console.log(err))
    }
  
    render() {
      return (
        <div className="App">
          <Box sx={{ flexGrow: 1 }}>
              <Grid container spacing={2}>
                  <Grid item xs={12}>
                      <h1>Login</h1>
                  </Grid>
                  <Grid item xs={12}>
                      <TextField id="outlined-basic" label="usuário" variant="outlined" value={this.state.Username} onChange={(e) => this.setState({ Username: e.target.value })} />
                  </Grid>
                  <Grid item xs={12}>
                      <TextField id="outlined-basic" label="senha" variant="outlined" type="password" value={this.state.passPasswordword} onChange={(e) => this.setState({ Password: e.target.value })} />
                  </Grid>
                  <Grid item xs={12}>
                      <Button variant="contained" onClick={()=>this.doLogin()}  >Logar</Button>
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
  
    return <Login {...props} />
  }

  export default WrappedComponent;