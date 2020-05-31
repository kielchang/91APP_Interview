export const queryOrders = () => fetch("api/Orders").then((res) => res.json());

export const shippedOrders = (payload) =>
  fetch("api/Orders/Shipped", {
    method: "PUT",
    headers: new Headers({
      "Content-Type": "application/json",
    }),
    body: JSON.stringify(payload),
  });
