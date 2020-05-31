import { combineReducers } from "redux";
import ordersReducer from "./ordersReducer";
import ordersFormReducer from "./ordersFormReducer";

export default combineReducers({
  ordersState: ordersReducer,
  ordersFormState: ordersFormReducer,
});
