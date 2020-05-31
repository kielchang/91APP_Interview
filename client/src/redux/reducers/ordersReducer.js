import { actionType } from "../actions/ordersAction";

const initialState = {
  orders: [],
  isFetch: false,
  error: null,
};

const applyOnFetch = (state, actions) => ({
  ...state,
  isFetch: true,
});

const applyUpdate = (state, { payload }) => ({
  ...state,
  isFetch: false,
  orders: payload,
});

const applyError = (state, { payload }) => ({
  ...state,
  isFetch: false,
  error: payload,
});

export default (state = initialState, action) => {
  switch (action.type) {
    case actionType.ORDERS_ON_FETCH:
      return applyOnFetch(state, action);
    case actionType.ORDERS_ON_UPDATE:
      return applyUpdate(state, action);
    case actionType.ORDERS_ON_ERROR:
      return applyError(state, action);
    default:
      return state;
  }
};
