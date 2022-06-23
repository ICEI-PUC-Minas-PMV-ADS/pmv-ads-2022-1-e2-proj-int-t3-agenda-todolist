const API_HOST = "https://agenda-puc-t5-back.herokuapp.com"

const axios = require('axios');

const headers = {
    headers: {
        'Access-Control-Allow-Origin': '*',
        'Content-Type': 'application/json',
      }
}

export const getData = (url) => {
    return axios.get(`${API_HOST}/${url}`, headers);
}

export const postData = (url, data) => {
    return axios.post(`${API_HOST}/${url}`, data, headers);
}

export const deleteData = (url) => {
    return axios.deleteData(`${API_HOST}/${url}`, headers);
}
