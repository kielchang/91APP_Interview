import { createStore, applyMiddleware } from "redux";
import createSagaMiddleware from "redux-saga";
import rootReducer from "../reducers";
import rootSaga from "../saga";

const saga = createSagaMiddleware();

const store = createStore(rootReducer, undefined, applyMiddleware(saga));

saga.run(rootSaga);

export default store;
