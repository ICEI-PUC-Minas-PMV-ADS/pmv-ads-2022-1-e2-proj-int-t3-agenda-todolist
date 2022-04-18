const API_HIST = "http://localhost:5000"

const axios = require('axios');

// Make a request for a user with a given ID
axios.get(`${API_HIST}/weatherforecast`)
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
