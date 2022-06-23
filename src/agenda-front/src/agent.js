const API_HOST = "http://agenda-puc-t5-back.herokuapp.com"
// const API_HOST = "http://localhost:5000"


const axios = require('axios');
//  headers: { 'Content-Type': 'application/json' },
axios.defaults.baseURL = API_HOST;
axios.defaults.headers.post['Content-Type'] ='application/json;charset=utf-8';
axios.defaults.headers.post['Access-Control-Allow-Origin'] = '*';
axios.defaults.headers.post['Access-Control-Allow-Methods'] = '*';

export const post = async (url, data) => {
    console.log(' >>> posting')
    const requestOptions = {
        method: 'POST',
		headers: {
			'Access-Control-Allow-Origin': '*',
			Accept: 'application/json',
			'Content-Type': 'application/json',
		},
        body: JSON.stringify(data)
    };
    console.log(requestOptions)
    const response = await fetch(`${API_HOST}/${url}`, requestOptions);
    console.log(response)
    const result = await response.json();
    return result
}


export const get = async (url) => {
    console.log(' >>> getting')
    const requestOptions = {
        method: 'GET',
		headers: {
			'Access-Control-Allow-Origin': '*',
			Accept: 'application/json',
			'Content-Type': 'application/json',
		}
    };
    console.log(requestOptions)
    const response = await fetch(`${API_HOST}/${url}`, requestOptions);
    console.log(response)
    const result = await response.json();
    console.log(result)
    return result
}

// export const post = async (url, data) => {
//     console.log(' >>> posting')
//     const requestOptions = {
//         method: 'POST',
//         body: JSON.stringify(data),
//         withCredentials: true
//     };
//     console.log(requestOptions)
//     return axios(`${url}`, requestOptions);
// }