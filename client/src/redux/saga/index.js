import { all } from "redux-saga/effects";
import ordersSaga from "./ordersSaga";
import ordersFormSaga from "./ordersFormSaga";

function* rootSaga() {
  yield all([...ordersSaga]);
  yield all([...ordersFormSaga]);
}

export default rootSaga;
