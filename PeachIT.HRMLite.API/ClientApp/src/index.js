import 'bootstrap/dist/css/bootstrap.css';
import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter } from 'react-router-dom';
import App from './App';
import registerServiceWorker from './registerServiceWorker';

const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');
const rootElement = document.getElementById('root');

ReactDOM.render(
  <BrowserRouter basename={baseUrl}>
    <App />
  </BrowserRouter>,
  rootElement);

registerServiceWorker();


//import 'bootstrap/dist/css/bootstrap.css';
//import React from 'react';
//import ReactDOM from 'react-dom';
//import { Provider } from 'react-redux';
//import { ConnectedRouter } from 'react-router-redux';
//import { CreateBrowserHistory } from 'history';
//import configureStore from './store/configureStore';
//import App from './App';
//import registerServiceWorker from './registerServiceWorker';

//const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');
//const history = CreateBrowserHistory({ basename: baseUrl });

//const initialState = window.initialReduxState;
//const store = configureStore(history, initialState);

//const rootElement = document.getElementById('root');

//ReactDOM.render(
//    <Provider store={store}>
//        <ConnectedRouter history={history}>
//            <App />
//        </ConnectedRouter>
//    </Provider>,
//    rootElement);

//registerServiceWorker();

//import React from 'react';
//import ReactDOM from 'react-dom';
//import './index.css';
//import App from './App';
//import reportWebVitals from './reportWebVitals';

//ReactDOM.render(
//    <React.StrictMode>
//        <App />
//    </React.StrictMode>,
//    document.getElementById('root')
//);

//// If you want to start measuring performance in your app, pass a function
//// to log results (for example: reportWebVitals(console.log))
//// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
//reportWebVitals();
