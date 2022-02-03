import React from 'react';
import ReactDOM from 'react-dom';
import App from './App';
import { Auth0Provider } from '@auth0/auth0-react';

ReactDOM.render(
  <Auth0Provider
    domain="dev-inpjx55j.us.auth0.com"
    clientId="eXMtTK8siHzGyTYVbg2rRh1i15edSM0w"
    redirectUri="https://localhost:3000"
  >
    <React.StrictMode>
    <App />
  </React.StrictMode>,
  </Auth0Provider>,
  document.getElementById('root')
);

