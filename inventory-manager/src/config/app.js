export const app = {
    ItemServiceURL: process.env.NODE_ENV === 'production' ? 'http://localhost:5001/api' : 'https://localhost:5001/api'
}
