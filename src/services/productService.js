import axios from 'axios'

const api = axios.create({
  baseURL: 'http://172.16.25.253:5022/api'
})

export const getProducts = async () => {

  const response = await api.get('/products')

  return response.data
}