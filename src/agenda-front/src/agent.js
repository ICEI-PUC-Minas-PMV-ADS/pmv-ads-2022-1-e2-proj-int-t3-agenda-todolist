const API_HOST = "http://localhost:5000"

const axios = require('axios');

export const getData = (url) => {
    return axios.get(`${API_HOST}/${url}`);
}

export const postData = (data, url) => {
    return axios.post(`${API_HOST}/${url}`, data);
}

export const deleteData = (url) => {
    return axios.deleteData(`${API_HOST}/${url}`);
}
