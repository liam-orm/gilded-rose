export const app = {
    ItemServiceURL: process.env.NODE_ENV === 'production' ? 'http://item-service/api' : 'https://localhost:5001/api'
}
