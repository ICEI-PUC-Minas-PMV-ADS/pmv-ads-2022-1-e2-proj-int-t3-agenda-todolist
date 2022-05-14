const API_HOST = "http://localhost:5000"

const axios = require('axios');

getData = (url) => {
    return axios.get(`${API_HOST}/${url}`)
      .then(function (response) {
        // handle success
        console.log(response.data);
      })
      .catch(function (error) {
        // handle error
        console.log(error);
      })
      .then(function () {
        // always executed
      });
}

postData = (data, url) => {
    return axios.post(`${API_HOST}/${url}`, data)
      .then(function (response) {
        // handle success
        console.log(response.data);
      })
      .catch(function (error) {
        // handle error
        console.log(error);
      })
      .then(function () {
        // always executed
      });
}

deleteData = (url) => {
    return axios.deleteData(`${API_HOST}/${url}`)
      .then(function (response) {
        // handle success
        console.log(response.data);
      })
      .catch(function (error) {
        // handle error
        console.log(error);
      })
      .then(function () {
        // always executed
      });
}