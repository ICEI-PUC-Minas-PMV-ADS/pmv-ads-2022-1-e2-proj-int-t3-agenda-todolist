const API_HOST = "http://agenda-puc-t5-back.herokuapp.com"
// const API_HOST = "http://localhost:5000"

export const post = async (url, data) => {
    const requestOptions = {
        method: 'POST',
		headers: {
			'Access-Control-Allow-Origin': '*',
			Accept: 'application/json',
			'Content-Type': 'application/json',
		},
        body: JSON.stringify(data)
    };

    return new Promise((resolve, reject) => {  
        fetch(`${API_HOST}/${url}`, requestOptions).then(response => {  
            if(response.status === 200) {                
                resolve()
            }
            if(response.status === 400 || response.status === 404) {
                reject()
            }
        }).catch(err => reject())
    })
}

export const get = async (url) => {
    const requestOptions = {
        method: 'GET',
		headers: {
			'Access-Control-Allow-Origin': '*',
			Accept: 'application/json',
			'Content-Type': 'application/json',
		}
    };

    return new Promise((resolve, reject) => {  
        fetch(`${API_HOST}/${url}`, requestOptions).then(response => {  
            if(response.status === 200) {
                console.log(response)
                resolve(response.json())
            }
            if(response.status === 400 || response.status === 404) {
                reject()
            }
        }).catch(err => reject())
    })
}