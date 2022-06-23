const API_HOST = "https://agenda-puc-t5-back.herokuapp.com"

// const axios = require('axios');
//  headers: { 'Content-Type': 'application/json' },

const post = (url, data) => {
    console.log('posting')
    const requestOptions = {
        method: 'POST',
        mode: 'cors',
        credentials: 'include',
        headers: {"Access-Control-Allow-Origin": "*" , 'Content-Type': 'application/json'},
        body: JSON.stringify(data)
    };
    return fetch(`${API_HOST}/${url}`, requestOptions)
}

const client = () => {
    console.log('client');
    const defaultOptions = {
        baseURL: API_HOST,
        headers: {"Access-Control-Allow-Origin": "*"},
    };

    return {
        get: (url, options = {}) => post(url, 'data'),
        post: (url, data, options = {}) => post(url, data),
        // put: (url, data, options = {}) => axios.put(url, data, { ...defaultOptions, ...options }),
        // delete: (url, options = {}) => axios.delete(url, { ...defaultOptions, ...options }),
    };
};


export default client