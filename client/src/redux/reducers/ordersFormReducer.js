import { actionType } from "../actions/ordersFormAction";

const initialState = {
  selectedIds: new Set(),
  isFetch: false,
  error: null,
};

const applySelected = (state, { payload }) => {
  const selectedIds = state.selectedIds;
  selectedIds.add(payload);

  return {
    ...state,
    selectedIds,
  };
};

const applyCancel = (state, { payload }) => {
  const selectedIds = state.selectedIds;
  selectedIds.delete(payload);

  return {
    ...state,
    selectedIds,
  };
};

const applyOnFetch = (state, actions) => ({
  ...state,
  isFetch: true,
});

const applyDone = (state, action) => ({
  ...state,
  isFetch: false,
});

const applyError = (state, { payload }) => ({
  ...state,
  isFetch: false,
  error: payload,
});

export default (state = initialState, action) => {
  switch (action.type) {
    case actionType.ORDERSFORM_SELECTED_ORDER:
      return applySelected(state, action);
    case actionType.ORDERSFORM_SELECTED_CANCEL:
      return applyCancel(state, action);
    case actionType.ORDERSFORM_ON_SUBMIT:
      return applyOnFetch(state, action);
    case actionType.ORDERSFORM_ON_DONE:
      return applyDone(state, action);
    case actionType.ORDERSFORM_ON_ERROR:
      return applyError(state, action);
    case actionType.ORDERSFORM_ON_INIT:
      return {
        ...initialState,
        selectedIds: new Set(),
      };
      
    default:
      return state;
  }
};
